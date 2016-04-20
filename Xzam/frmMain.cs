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
    public partial class frmMain : Form
    {
        private string username;
        private string password;

        private frmQuestionBankSetup frm3;

        public frmMain()
        {
            InitializeComponent();

        }
        public frmMain(string username, string password) : this()
        {
            this.username = username;
            this.password = password;
            lblCurrentUser.Text = username;
        }

        frmUserMaintenance frm1 = new frmUserMaintenance();
        private void toolStripButtonUserManagement_Click(object sender, EventArgs e)
        {
            if (frm1.IsDisposed)
            {
                frm1 = new frmUserMaintenance();
            }
            frm1.ShowDialog(); 
        }
        ExamSetup frm2 = new ExamSetup();
        private void toolStripButtonExamManagement_Click(object sender, EventArgs e)
        {
            if (frm2.IsDisposed) { frm2 = new ExamSetup(); }
            frm2.ShowDialog(); 
        }
        private void toolStripButtonQuestionBank_Click(object sender, EventArgs e)
        {
            frm3 = new frmQuestionBankSetup();
            frm3.ShowDialog(); 
        }
        frmSchedulerCreation frm4 = new frmSchedulerCreation();
        private void toolStripButtonTimeSchedule_Click(object sender, EventArgs e)
        {
            if (frm4.IsDisposed) { frm4 = new frmSchedulerCreation(); }
            frm4.ShowDialog(); 
        }

        private void toolStripButtonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (username == "admin")
            {
                toolStripButtonChangePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
                toolStripButtonChangePassword.Enabled = false;
            }
            else
            {
                toolStripButtonExamManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
                toolStripButtonExamManagement.Enabled = false;
                toolStripButtonQuestionBank.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
                toolStripButtonQuestionBank.Enabled = false;
                toolStripButtonUserManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
                toolStripButtonUserManagement.Enabled = false;
            }
        }
        frmChangePassword frm5 = new frmChangePassword();
        private void toolStripButtonChangePassword_Click(object sender, EventArgs e)
        {
            frm5.passValuePassword = password;
            frm5.passValueUsername = username;
    
            if (frm5.IsDisposed)
            {
                frm5 = new frmChangePassword();
                var text = frm5.Controls["txtCurrentPassword"];
                text.Text = password;
            }
            frm5.ShowDialog(); 
        }


        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm1.IsDisposed)
            {
                frm1 = new frmUserMaintenance();
            }
            frm1.ShowDialog();
        }

        private void managerExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm2.IsDisposed) { frm2 = new ExamSetup(); }
            frm2.ShowDialog(); 
        }

        private void questionBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm3.IsDisposed) { frm3 = new frmQuestionBankSetup(); }
            frm3.ShowDialog(); 
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm5.passValuePassword = password;
            frm5.passValueUsername = username;
            //if (username != "Admin" )
            //{
            //    MessageBox.Show("user");
            if (frm5.IsDisposed)
            {
                frm5 = new frmChangePassword();
                var text = frm5.Controls["txtCurrentPassword"];
                text.Text = password;
            }
            frm5.ShowDialog(); 
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm4.IsDisposed) { frm4 = new frmSchedulerCreation(); }
            frm4.ShowDialog(); 
        }


        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
