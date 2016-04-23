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
    public partial class frmAddNewStudent : Form
    {
        public frmAddNewStudent()
        {
            InitializeComponent();
        }

        private void frmAddNewStudent_Load(object sender, EventArgs e)
        {
            //DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtAddId_TextChanged(object sender, EventArgs e)
        {
            txtAddId.Text = string.Concat(txtAddId.Text.Where(char.IsLetterOrDigit));
        }

        private void txtAddUsername_TextChanged(object sender, EventArgs e)
        {
            txtAddUsername.Text = string.Concat(txtAddUsername.Text.Where(char.IsLetterOrDigit));
        }

        private void txtAddPassword_TextChanged(object sender, EventArgs e)
        {
            txtAddPassword.Text = string.Concat(txtAddPassword.Text.Where(char.IsLetterOrDigit));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddId.Text == "" || txtAddPassword.Text == "" || txtAddUsername.Text == "")
            {
                MessageBox.Show("Please enter new student id, username, password");
            }
            else
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
