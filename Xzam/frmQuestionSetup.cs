using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xzam.Models;
namespace Xzam
{
    public partial class frmQuestionSetup : Form
    {
        private Question q;
        private ListViewItem lastcheckeditem;
        public Question Quest { 
            get{
                return q;
            } 
        }
        private int mode;
        public frmQuestionSetup():this(0)
        {
            
        }
        public frmQuestionSetup(int mode) :this(mode,null){
            
        }
        public frmQuestionSetup(int mode, Question q) {
            this.mode = mode;
            
            this.q = q;
             
            InitializeComponent();
        }
        private void btnAddOption_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text) || String.IsNullOrEmpty(txtText.Text))
            { 
                MessageBox.Show("Please fill both code and option text.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (ListViewItem item in lvwOptions.Items)
                {
                    if (item.Text.Equals(txtCode.Text)) { 
                        MessageBox.Show("Option with same code already exists",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                ListViewItem litem = new ListViewItem(txtCode.Text);
                litem.SubItems.Add(txtText.Text);
                lvwOptions.Items.Add(litem);

                txtCode.Text = "";
                txtText.Text = "";

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitle.Text) || String.IsNullOrEmpty(txtGrade.Text)) {
 
                MessageBox.Show("Please enter all the required fields", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               return; 
            }
            double value;
            if  (!double.TryParse(txtGrade.Text,out value)) {
                MessageBox.Show("Please enter a valid grade point. Grades are a valid positive numbers.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lvwOptions.CheckedIndices.Count < 1)
            {
                MessageBox.Show("Atleast one option should be checked to mark the correct answer.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(q==null){
                q = new Question();
            }
            q.QuestionID= 0;
            q.QuestionTitle= txtTitle.Text;
            q.CorrectOption = lvwOptions.CheckedItems[0].Text.ToCharArray()[0];
            q.GradePoint = Double.Parse( txtGrade.Text);
            q.ShuffleOptions = false;
            q.Options.Clear();
            foreach(ListViewItem litem in lvwOptions.Items){
                q.AddOption(new Option(litem.Text.ToCharArray()[0],litem.SubItems[1].Text,q));
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Hide();
        }

        private void lvwOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        { 
            if (lastcheckeditem != null && lastcheckeditem.Checked
                && lastcheckeditem != lvwOptions.Items[e.Index])
            { 
                lastcheckeditem.Checked = false;
            } 
            lastcheckeditem = lvwOptions.Items[e.Index]; 
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCode.Text = e.KeyChar.ToString().ToUpper();
        }

        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) || e.KeyChar=='\b' ) {
                e.KeyChar = (Char)Keys.Escape;
            }
        }

        private void txtGrade_KeyDown(object sender, KeyEventArgs e)
        { 

        }

        private void btnRemoveOption_Click(object sender, EventArgs e)
        {
            lvwOptions.Items.RemoveAt(lvwOptions.SelectedIndices[0]);
        }

        private void frmQuestionSetup_Load(object sender, EventArgs e)
        {
            if (mode == 2) {
                LoadQuestionDetails();
            }
        }
        private void LoadQuestionDetails() {
            if (this.q != null) {
                this.txtTitle.Text = q.QuestionTitle;
                txtGrade.Text = q.GradePoint.ToString();
                ListViewItem litem;
                foreach (Option item in q.Options)
                {
                    litem = new ListViewItem();
                    litem.Text = item.Code.ToString();
                    litem.SubItems.Add(item.Value);
                    if (q.CorrectOption == item.Code)
                        litem.Checked = true;

                    lvwOptions.Items.Add(litem);
                }

            }
        }
    }
}
