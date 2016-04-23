using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xzam
{
    public partial class frmChangePassword : Form
    {

        public frmChangePassword()
        {
            InitializeComponent();
        }
        //Connect String Datasource
        string cs = @"Data Source=VAIO\SQLEXPRESS;Initial Catalog=USER;Integrated Security=True";

        private static string password;
        private static string username;
        public string passValueUsername
        {
            set { username = value; }
            get { return username; }
        }
        public string passValuePassword
        {
            set { password = value; }
            get { return password; }
        }

        private void btnUserChangePassword_Click(object sender, EventArgs e)
        {
            //txtCurrentPassword.Text = password;
            string t1 = txtConfirmPassword.Text;
            string t2 = txtNewPassword.Text;
            string t3 = txtCurrentPassword.Text;
            try
            {
                //check password validate value
                if (t3 == t2)
                {
                    MessageBox.Show("Password is not changed, please enter your new password");
                }
                //if it done
                else if (t1 == t2 && t1 != null && t2 != null && t3 == password)
                {

                    SqlConnection connectSql = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("update USER_TABLE SET Password=@Pass WHERE username = @uname", connectSql);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.Parameters.AddWithValue("@Pass", txtConfirmPassword.Text);
                    connectSql.Open();
                    cmd.ExecuteNonQuery();
                    connectSql.Close();
                    MessageBox.Show("Change Password Successful!");
                    this.Close();
                }
                //else it's not correct

                else
                {
                    MessageBox.Show("Please enter your password and confirm your new password again");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Password is not changed" + ex);
            }

        }

        private void btnUserCancelChangePass_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Current " + password);


        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtNewPassword.Text = string.Concat(txtNewPassword.Text.Where(char.IsLetterOrDigit));
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.Text = string.Concat(txtConfirmPassword.Text.Where(char.IsLetterOrDigit));
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            txtCurrentPassword.Text = string.Concat(txtCurrentPassword.Text.Where(char.IsLetterOrDigit));
        }


    }
}
