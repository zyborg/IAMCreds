using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zyborg.IAMCreds.WinForm
{
    public partial class MainForm : Form
    {
        IAmazonIdentityManagementService _iam;

        User _user;
        string _authAccessKeyId;

        LoginProfile _login;
        AccessKeyMetadata[] _accessKeys;
        AccessKeyLastUsed[] _accessKeyLasts;
        object[] _accessKeyDetails;

        NewAccessKey _newAK = new NewAccessKey();
        ChangePassword _changePW = new ChangePassword();

        public MainForm(IAmazonIdentityManagementService iam, User user, string authAccessKeyId)
        {
            _iam = iam;
            _user = user;
            _authAccessKeyId = authAccessKeyId;

            InitializeComponent();
        }

        public Task BindUser()
        {
            usernameTextBox.Text = _user.UserName;
            userIdTextBox.Text = _user.UserId;
            arnTextBox.Text = _user.Arn;

            return Task.CompletedTask;
        }

        public async Task LoadAccessKeys()
        {
            try
            {
                var listAkResp = await _iam.ListAccessKeysAsync(new ListAccessKeysRequest
                {
                    UserName = _user.UserName,
                });
                _accessKeys = listAkResp.AccessKeyMetadata?.ToArray();

                var getAkLast = await Task.WhenAll(
                    listAkResp.AccessKeyMetadata?.Select(async x =>
                    {
                        return (await _iam.GetAccessKeyLastUsedAsync(new GetAccessKeyLastUsedRequest
                        {
                            AccessKeyId = x.AccessKeyId,
                        }))?.AccessKeyLastUsed;
                    }));
                _accessKeyLasts = getAkLast?.ToArray();
            }
            catch (AmazonIdentityManagementServiceException ex)
                when (ex.StatusCode == HttpStatusCode.Forbidden)
            {
                // User does not have permission to describe their own keys
                return;
            }
            finally
            {

            }

            _accessKeyDetails = _accessKeys?.Select((x, y) =>
                new
                {
                    x.AccessKeyId,
                    Status = (x.Status.Value == StatusType.Active.Value),
                    x.CreateDate,
                    _accessKeyLasts[y].LastUsedDate,
                    ServiceName = SvcReg(_accessKeyLasts[y]),

                    // Weird bug in MONO version of DataGridViewLinkColumn that doesn't respect
                    // the `UseColumnTextForLinkValue` property to allow static link text
                    // TODO: Submit a GH issue for mono
                    DeleteLinkLabel = "Delete",
                }).ToArray();
            accessKeysDataGrid.DataSource = _accessKeyDetails;

            string SvcReg(AccessKeyLastUsed akLast)
            {
                var svc = akLast.ServiceName ?? "";
                var reg = akLast.Region ?? "";

                if (svc == "" || svc == "N/A")
                    if (reg == "" || reg == "N/A")
                        return "(N/A)";
                    else
                        return $"[(unknown)] in [{akLast.Region}]";
                else
                    return $"{akLast.ServiceName} in {akLast.Region}";
            }
        }

        public async Task LoadLoginProfile()
        {
            try
            {
                var getLoginResp = await _iam.GetLoginProfileAsync(new GetLoginProfileRequest
                {
                    UserName = _user.UserName,
                });
                _login = getLoginResp.LoginProfile;
            }
            catch (Exception)
            {
                // User does not have login ability or cannot self-manage 
                return;
            }

            passwordCreateDateTextBox.Text = $"{_login?.CreateDate}";
            passwordLastUsedTextBox.Text = _user.PasswordLastUsed.ToString();
            passwordResetRequiredCheckBox.Checked = _login?.PasswordResetRequired??false;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await BindUser();
            await LoadAccessKeys();
            await LoadLoginProfile();
        }

        private  async void refreshButton_Click(object sender, EventArgs e)
        {
            await BindUser();
            await LoadAccessKeys();
            await LoadLoginProfile();
        }

        private async void akCreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var resp = await _iam.CreateAccessKeyAsync();
                _newAK.AccessKey = resp.AccessKey.AccessKeyId;
                _newAK.SecretKey = resp.AccessKey.SecretAccessKey;

                _newAK.ShowDialog(this);

                await LoadAccessKeys();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create: " + ex.Message);
            }
        }

        private async void accessKeysDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                // Clicked on header
                return;

            var ak = _accessKeys[e.RowIndex];
            var akLast = _accessKeyLasts[e.RowIndex];

            if (accessKeysDataGrid.Columns[e.ColumnIndex].Name == nameof(activeColumn))
            {
                try
                {
                    if (_accessKeys[e.RowIndex].Status == StatusType.Active &&
                        MessageBox.Show($"Are you sure you want to DEACTIVATE '{ak.AccessKeyId}'?",
                            "Update Access Key", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var resp = await _iam.UpdateAccessKeyAsync(
                            new UpdateAccessKeyRequest(ak.AccessKeyId, StatusType.Inactive));
                        await LoadAccessKeys();
                        return;
                    }
                    if (_accessKeys[e.RowIndex].Status == StatusType.Inactive &&
                        MessageBox.Show($"Are you sure you want to ACTIVATE '{ak.AccessKeyId}'?",
                            "Update Access Key", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var resp = await _iam.UpdateAccessKeyAsync(
                            new UpdateAccessKeyRequest(ak.AccessKeyId, StatusType.Active));
                        await LoadAccessKeys();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update Access Key: " + ex.Message);
                }
                return;
            }
        
            if (accessKeysDataGrid.Columns[e.ColumnIndex].Name == nameof(deleteLinkColumn))
            {
                try
                {
                    var msg = $"Are you sure you want to DELETE '{ak.AccessKeyId}'?";
                    if (ak.AccessKeyId == _authAccessKeyId)
                    {
                        msg += "\r\n";
                        msg += "\r\nNOTE: This is the Access Key that you are authenticated with!";
                        msg += "\r\n      You will need to exit and re-authenticate afterwards.";
                    }

                    if (MessageBox.Show(msg, "Delete Access Key",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var resp = await _iam.DeleteAccessKeyAsync(
                            new DeleteAccessKeyRequest(ak.AccessKeyId));
                        await LoadAccessKeys();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete Access Key: " + ex.Message);
                }
                return;
            }
        }

        private async void resetPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var ppResp = await _iam.GetAccountPasswordPolicyAsync();
                _changePW.PasswordPolicy = ppResp?.PasswordPolicy;
            }
            catch (Exception)
            {
                _changePW.PasswordPolicy = null;
            }


            try
            {
                if (_changePW.ShowDialog(this) == DialogResult.OK)
                {
                    var resp = await _iam.ChangePasswordAsync(new ChangePasswordRequest
                    {
                        OldPassword = _changePW.OldPassword,
                        NewPassword = _changePW.NewPassword,
                    });
                    MessageBox.Show("Password has been changed.");
                    await LoadLoginProfile();
                }
            }
            catch (Exception ex)
            {
                // The error message may be misleading as per:
                //  http://edunham.net/2017/11/29/user_is_not_authorized_to_perform_iam_changepassword.html
                // So we append some more helpful info

                MessageBox.Show("Failed to change password: " + ex.Message
                    + "\r\n\r\n"
                    + "Make sure that your current password is correct and your new password conforms to the password policy.");
            }
        }
    }
}
