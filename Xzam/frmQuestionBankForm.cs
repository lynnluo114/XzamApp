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
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                }
                else if (mode == 2) {
                    lvwQuestionBank.Enabled = false;
                    btnNew.Enabled = false;
                    btnSave.Enabled = true;
                    groupDetails.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = true;
                }
                else if (mode == 0) {
                    lvwQuestionBank.Enabled = true;
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    groupDetails.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = false;
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
                QuestionDataAccess qa = new QuestionDataAccess();
                if (mode == 1)
                {

                    int id = qda.SaveData(qb);
                    int xa;
                    Question ques;
                    foreach (ListViewItem item in lvwQuestions.Items)
                    {
                        ques = (Question)item.Tag;
                        ques.Questionbankid = id;
                            xa = qa.SaveData(ques);
                    }
                    MessageBox.Show(id.ToString());
                }
                else
                {
                    qb.ID = Int32.Parse(lvwQuestionBank.SelectedItems[0].Text);
                    qda.UpdateData(qb);
                    qa.DeleteData(qb.ID);

                    int xa;
                    Question ques;
                    foreach (ListViewItem item in lvwQuestions.Items)
                    {
                        ques = (Question)item.Tag;
                        ques.Questionbankid = qb.ID;
                        xa = qa.SaveData(ques);
                    }
                }
                qa = null;
                Mode = 0;
                MessageBox.Show("Data saved successfully", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                LoadQuestions(selected.ID);

            }
        }
        private void LoadQuestions(int questionbankid) {
            QuestionDataAccess qa = new QuestionDataAccess();
            lvwQuestions.Items.Clear();
            ListViewItem litem;
            foreach(Question question in qa.GetList(questionbankid)){
                litem = new ListViewItem(question.CorrectOption.ToString());
                litem.SubItems.Add( question.QuestionTitle);
                litem.Tag = question;
                lvwQuestions.Items.Add(litem);
                
                
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

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {

            Question q = null;
            frmQuestionSetup questions = new frmQuestionSetup(1,q);
            DialogResult qdialog = questions.ShowDialog();
            if (qdialog == System.Windows.Forms.DialogResult.OK) {

                ListViewItem litem = new ListViewItem();
                litem.Text = q.CorrectOption.ToString();
                litem.SubItems.Add(q.QuestionTitle);
                litem.Tag = q;
                lvwQuestions.Items.Add(litem);
                questions.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            lvwQuestions.Items.RemoveAt(lvwQuestions.SelectedIndices[0]);
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            SetupFromMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            
            mode = 0;
            SetupFromMode();
        }

        private void lvwQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwQuestions_DoubleClick(object sender, EventArgs e)
        {
            Question q = (Question)lvwQuestions.SelectedItems[0].Tag;
            frmQuestionSetup questions = new frmQuestionSetup(2, q);
            DialogResult qdialog = questions.ShowDialog();
            if (qdialog == System.Windows.Forms.DialogResult.OK)
            {
                ListViewItem litem=null;
                if(mode==1){
                     litem = new ListViewItem();
                     litem.Text = q.CorrectOption.ToString();
                     litem.SubItems.Add(q.QuestionTitle);
                     litem.Tag = q;
                     lvwQuestions.Items.Add(litem);
                }
                else if (mode == 2) { 
                    litem = lvwQuestions.SelectedItems[0];
                    litem.Text = q.CorrectOption.ToString();
                    litem.SubItems[1].Text = q.QuestionTitle;
                    litem.Tag = q;
                     
                }

                
                questions.Close();
            }
        }
    }
}
