using Amazon.IdentityManagement.Model;
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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        public string OldPassword => oldPasswordTextBox.Text;
        public string NewPassword => newPasswordTextBox.Text;

        public PasswordPolicy PasswordPolicy
        {
            set
            {
                if (value == null)
                {
                    passwordPolicyLabel.TextAlign = ContentAlignment.MiddleCenter;
                    passwordPolicyLabel.Text = "(Password Policy Could Not Be Retrieved)";
                }
                else
                {
                    var polRules = new StringBuilder();

                    int val;

                    if ((val = value.MaxPasswordAge) > 0)
                        polRules.AppendLine($"● Maximum age is {value.MaxPasswordAge} day{Plural(val)}");
                    if ((val = value.PasswordReusePrevention) > 0)
                        polRules.AppendLine($"● Cannot reuse the last {value.PasswordReusePrevention} password{Plural(val)}");
                    if ((val = value.MinimumPasswordLength) > 0)
                        polRules.AppendLine($"● Must be at least {value.MinimumPasswordLength} character{Plural(val)}");
                    if (value.RequireLowercaseCharacters)
                        polRules.AppendLine("● Must include at least one lowercase letter");
                    if (value.RequireUppercaseCharacters)
                        polRules.AppendLine("● Must include at least one uppercase letter");
                    if (value.RequireNumbers)
                        polRules.AppendLine("● Must include at least one number");
                    if (value.RequireSymbols)
                        polRules.AppendLine("● Must include at least one non-alphanumeric character");

                    passwordPolicyLabel.TextAlign = ContentAlignment.TopLeft;
                    passwordPolicyLabel.Text = polRules.ToString();

                    string Plural(int v) => v == 1 ? "" : "s";
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldPasswordTextBox.Text))
            {
                MessageBox.Show("You must provide an existing password.");
                return;
            }
            if (string.IsNullOrEmpty(newPasswordTextBox.Text))
            {
                MessageBox.Show("You must provide an new password.");
                return;
            }
            if (newPasswordTextBox.Text != confirmTextBox.Text)
            {
                MessageBox.Show("New Passwords do not match!");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
