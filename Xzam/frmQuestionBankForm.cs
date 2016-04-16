using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xzam.DA;
using Xzam.Models;
namespace Xzam
{
    public partial class frmQuestionBankSetup : Form
    {
        QuestionBankDataAccess qda;
        
        private int mode=0; // 0 for nothing, 1 for new, 2 for edit
        public frmQuestionBankSetup()
        {
            qda = new QuestionBankDataAccess();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            QuestionBank qb = new QuestionBank(0,txtName.Text,chkBackTracking.Checked,chkShuffleQuestions.Checked);
            if (mode == 1)
                qda.SaveData(qb);
            else
                qb.ID =Int32.Parse( lvwQuestionBank.SelectedItems[0].Text);
                qda.UpdateData(qb);
        }

        private void lvwQuestionBank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwQuestionBank_DoubleClick(object sender, EventArgs e)
        {
            ListView lvw = (ListView)sender;
            if (lvw.SelectedItems.Count > 0) {
                mode = 2;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            mode = 1;
            ClearAll();
        }
        private void ClearAll() {
            txtName.Text = "";
            chkBackTracking.Checked = false;
            chkShuffleQuestions.Checked = false;
            
        }
    }
}
