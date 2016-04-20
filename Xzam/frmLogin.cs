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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Connect String Datasource
        string cs = System.Configuration.ConfigurationSettings.AppSettings["constr"].ToString();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUserNLogin.Text == "")
            {
                MessageBox.Show("Please enter your Username");
                return;
            }
            else if (txtPasswordLogin.Text == "")
            {
                MessageBox.Show("Please enter your Password");
                return;
            }
            try
            {

                //Create SqlConnection
                System.Data.SqlClient.SqlConnection connectSql = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from USER_TABLE where Username=@username and Password=@password", connectSql);
                cmd.Parameters.AddWithValue("username", txtUserNLogin.Text);
                cmd.Parameters.AddWithValue("password", txtPasswordLogin.Text);
                connectSql.Open();
                SqlDataReader reader = cmd.ExecuteReader(); //Nó đọc từng dòng trong bảng được trả về. Nếu nó thoải điều kiện nào đó thì ta làm 1 việc gì đó
                DataTable tbl = reader.GetSchemaTable();

                
                if (reader.Read())
                {
                    //MessageBox.Show(reader[0].ToString());// check dong da duoc doc
                     
                    frmMain frm = new frmMain(txtUserNLogin.Text,txtPasswordLogin.Text);
                    frm.Show(); 
                     
                }
                else
                {
                    MessageBox.Show("Please correct your username and password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
