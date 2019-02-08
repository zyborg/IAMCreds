using Amazon;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime.CredentialManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zyborg.IAMCreds.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var credInput = new CredentialInput();

            IAmazonIdentityManagementService iam;
            User user;

            string authAccessKeyId = null;

            while (true)
            {
                var scf = new SharedCredentialsFile();
                credInput.CredentialProfileFilePath = scf.FilePath;
                credInput.CredentialProfiles = scf.ListProfiles();
                if (credInput.ShowDialog() != DialogResult.OK)
                    // Aborting, end of app
                    return;

                try
                {
                    if (credInput.IgnoreTlsCertErrors)
                    {
                        ServicePointManager.ServerCertificateValidationCallback =
                            (sender, certificate, chain, sslPolicyErrors) => true;
                    }
                    else
                    {
                        ServicePointManager.ServerCertificateValidationCallback = null;
                    }

                    var reg = credInput.RegionEndpoint ??
                        RegionEndpoint.GetBySystemName(credInput.RegionSystemName);
                    if (credInput.UseCredentialProfile)
                    {
                        var awsCred = credInput.CredentialProfile.GetAWSCredentials(null);
                        authAccessKeyId = awsCred.GetCredentials().AccessKey;
                        iam = new AmazonIdentityManagementServiceClient(awsCred, reg);
                    }
                    else
                    {
                        authAccessKeyId = credInput.AccessKey;
                        iam = new AmazonIdentityManagementServiceClient(
                            credInput.AccessKey, credInput.SecretKey, reg);
                    }

                    var userRequ = new GetUserRequest();
                    var userResp = iam.GetUser(userRequ);

                    if (userResp.User == null)
                    {
                        MessageBox.Show("Failed to authenticate with the provided credentials: " + userResp.HttpStatusCode);
                    }
                    else
                    {
                        user = userResp.User;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Application.Run(new MainForm(iam, user, authAccessKeyId));
        }
    }
}
