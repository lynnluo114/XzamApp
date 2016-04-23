using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xzam
{
    public partial class frmAdminChangePassword : Form
    {
        public frmAdminChangePassword()
        {
            InitializeComponent();
        }

        private void btnUserChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" )
            {
                MessageBox.Show("Please enter new password");
            }
            else
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Text = string.Concat(txtPassword.Text.Where(char.IsLetterOrDigit));
        }
    }
}
