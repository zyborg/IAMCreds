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
    public partial class NewAccessKey : Form
    {
        public NewAccessKey()
        {
            InitializeComponent();
        }

        public string AccessKey
        {
            set => this.accessKeyTextBox.Text = value;
        }

        public string SecretKey
        {
            set => this.secretKeyTextBox.Text = value;
        }

        private void accessKeyTextBox_Enter(object sender, EventArgs e)
        {
            accessKeyTextBox.SelectAll();
        }

        private void secretKeyTextBox_Enter(object sender, EventArgs e)
        {
            secretKeyTextBox.SelectAll();
        }
    }
}
