using Amazon;
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

        public string AccessKey => accessKeyTextBox.Text;
        public string SecretKey => secretKeyTextBox.Text;
        public RegionEndpoint RegionEndpoint => regionComboBox.SelectedItem as RegionEndpoint;
        public string RegionSystemName => this.RegionEndpoint?.SystemName ??
            regionComboBox.Text;

        public bool IgnoreTlsCertErrors => ignoreTlsCertErrorsCheckBox.Checked;

        private void okButton_Click(object sender, EventArgs e)
        {
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
