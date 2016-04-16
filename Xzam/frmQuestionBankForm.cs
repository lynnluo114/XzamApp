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

        private int Mode {
            get { return mode; }
            set{mode = value;}
        }
        private void SetupFromMode (){
                if (mode == 1) {
                    btnNew.Enabled = false;
                    btnSave.Enabled = true;
                    lvwQuestionBank.Enabled = false;
                    groupDetails.Enabled = true;

                }
                else if (mode == 2) {
                    lvwQuestionBank.Enabled = false;
                    btnNew.Enabled = false;
                    btnSave.Enabled = true;
                    groupDetails.Enabled = true;
                }
                else if (mode == 0) {
                    lvwQuestionBank.Enabled = true;
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    groupDetails.Enabled = false;
                } 
        }
        public frmQuestionBankSetup()
        {
            qda = new QuestionBankDataAccess();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            QuestionBank qb = new QuestionBank(0,txtName.Text,chkBackTracking.Checked,chkShuffleQuestions.Checked);
            try
            {
                if (mode == 1)
                {
                    int id = qda.SaveData(qb);
                    MessageBox.Show(id.ToString());
                }
                else
                {
                    qb.ID = Int32.Parse(lvwQuestionBank.SelectedItems[0].Text);
                    qda.UpdateData(qb);
                }
                Mode = 0;
                SetupFromMode();
                LoadList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                qb = null;
            }
            
        }

        private void lvwQuestionBank_SelectedIndexChanged(object sender, EventArgs e)
        { 
            ListView lvw = (ListView)sender;
            if (lvw.SelectedItems.Count > 0) {
                QuestionBank selected = (QuestionBank)lvw.SelectedItems[0].Tag;
                txtName.Text = selected.Name;
                chkBackTracking.Checked = selected.BackTrack;
                chkShuffleQuestions.Checked = selected.ShuffleQuestions;
            }
        }

        private void lvwQuestionBank_DoubleClick(object sender, EventArgs e)
        {
            ListView lvw = (ListView)sender;
            if (lvw.SelectedItems.Count > 0) {
                Mode = 2;
                SetupFromMode();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Mode = 1;
            SetupFromMode();
            ClearAll();
        }
        private void ClearAll() {
            txtName.Text = "";
            chkBackTracking.Checked = false;
            chkShuffleQuestions.Checked = false;
            
        }

        private void frmQuestionBankSetup_Load(object sender, EventArgs e)
        {
            Mode = 0;
            SetupFromMode();
            LoadList();
        }
        private void LoadList() {
            lvwQuestionBank.Items.Clear();
            ListViewItem litem;
            foreach (QuestionBank qb in qda.GetList()) {
                litem = new ListViewItem();
                litem.Text = qb.ID.ToString();
                litem.Tag = qb;
                litem.SubItems.Add(qb.Name);
                litem.SubItems.Add(qb.BackTrack ? "Yes" : "No");
                litem.SubItems.Add(qb.ShuffleQuestions ? "Yes" : "No");
                lvwQuestionBank.Items.Add(litem);
            }

        }
    }
}
