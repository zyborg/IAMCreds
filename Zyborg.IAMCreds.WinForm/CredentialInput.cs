using Amazon;
using Amazon.Runtime.CredentialManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zyborg.IAMCreds.WinForm
{
    public partial class CredentialInput : Form
    {
        public CredentialInput()
        {
            InitializeComponent();

            regionComboBox.DataSource = RegionEndpoint.EnumerableAllRegions;
            regionComboBox.SelectedItem = RegionEndpoint.USEast1;
        }

        public string CredentialProfileFilePath
        {
            set
            {
                profileFileTextBox.Text = value;
            }
        }

        public List<CredentialProfile> CredentialProfiles
        {
            set
            {
                profileComboBox.DataSource = value;
            }
        }

        public bool UseCredentialProfile => credentialTabControl.SelectedTab == credentialProfileTabPage;

        public string AccessKey => accessKeyTextBox.Text;
        public string SecretKey => secretKeyTextBox.Text;

        public CredentialProfile CredentialProfile => UseCredentialProfile
            ? profileComboBox.SelectedItem as CredentialProfile
            : null;

        public RegionEndpoint RegionEndpoint => regionComboBox.SelectedItem as RegionEndpoint;
        public string RegionSystemName => this.RegionEndpoint?.SystemName ??
            regionComboBox.Text;

        public bool IgnoreTlsCertErrors => ignoreTlsCertErrorsCheckBox.Checked;

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!UseCredentialProfile)
            {
                if (string.IsNullOrEmpty(AccessKey) || string.IsNullOrEmpty(SecretKey))
                {
                    MessageBox.Show("You must specify an Access Key ID and Secret Key to authenticate.");
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void CredentialInput_Load(object sender, EventArgs e)
        {
            // We have to handle and reset the state because of a possible
            // compatibility bug when running on MONO -- TODO: research
            this.DialogResult = DialogResult.None;
        }
    }
}
