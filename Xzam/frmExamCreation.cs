using System;
using System.Windows.Forms;
using Xzam.Models;
using Xzam.DA;

namespace Xzam
{
    public partial class ExamSetup : Form
    {
        public ExamSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = true;
            if (text_ExamCode.Text == "")
            {
                success = false;
                MessageBox.Show("Exam Code is required!");
            }

            if (text_ExamTitle.Text == "")
            {
                success = false;
                MessageBox.Show("Exam Title is required!");
            }
            if (success)
            {
                Exam exam = new Exam(text_ExamCode.Text, text_ExamTitle.Text);
                try
                {
                    ExamDataAccess ea = new ExamDataAccess();
                    ea.SaveData(exam);
                    MessageBox.Show("Data saved successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    exam = null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
