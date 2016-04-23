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
    public partial class frmUserMaintenance : Form
    {
        public frmUserMaintenance()
        {
            InitializeComponent();
        }
        //Connect String Datasource
        string cs = @"Data Source=VAIO\SQLEXPRESS;Initial Catalog=USER;Integrated Security=True";

        private void frmUserMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uSERDataSet.USER_TABLE' table. You can move, or remove it, as needed.
            //this.uSER_TABLETableAdapter.Fill(this.uSERDataSet.USER_TABLE);
            userDataGridView.DataSource = GetData();
        }

        DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmdSql = new SqlCommand("Select Id, username, password from USER_TABLE", con);
                SqlDataAdapter adpt = new SqlDataAdapter(cmdSql);
                adpt.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        private void uSER_TABLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSER_TABLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uSERDataSet);

        }

        private void ClickEdit(object sender, DataGridViewCellEventArgs e)
        {


            if (userDataGridView.CurrentCell.ColumnIndex == 3)
            {
                var row = userDataGridView.CurrentRow;
                frmAdminChangePassword form = new frmAdminChangePassword();

                var txt1 = form.Controls["txtUsername"];
                var txt2 = form.Controls["txtPassword"];
                txt1.Text = row.Cells[1].Value.ToString();
                //MessageBox.Show(txt1.Text);
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        row.Cells[2].Value = "123";
                        //if (txt2.Text != null)
                        //{
                        //    row.Cells[2].Value = txt2.Text;
                        //    SqlConnection connectSql = new SqlConnection(cs);

                        //    SqlCommand cmd = new SqlCommand("update USER_TABLE SET Password=@Pass WHERE Id = @uid", connectSql);
                        //    cmd.Parameters.AddWithValue("@uid", id);
                        //    cmd.Parameters.AddWithValue("@Pass", txt2.Text);
                        //    connectSql.Open();
                        //    cmd.ExecuteNonQuery();
                        //    connectSql.Close();
                        //}
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Password is not changed" + ex);
                    }
                }
            }




        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            int id;
            int index = this.userDataGridView.Rows.Count;
            index++;

            frmAddNewStudent form = new frmAddNewStudent();
            var textId = form.Controls["txtAddId"];
            var textUsername = form.Controls["txtAddUsername"];
            var textPassword = form.Controls["txtAddPassword"];

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    id = Int32.Parse(textId.Text);
                    uSER_TABLETableAdapter.Insert(id, textUsername.Text, textPassword.Text); //Check user table Adapter
                    userDataGridView.DataSource = GetData();
                    MessageBox.Show("New student is added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
