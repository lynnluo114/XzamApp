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
using Xzam.DA;

namespace Xzam
{
    public partial class ExamScreenforStudent : Form
    {
        private QuestionBank _qb;
        private Question _q;
        private int index = 0;
        private double totalPoints = 0;
        private RadioButton[] rd = null;
        private List<Option> _options = null;

        public QuestionBank QuesBank
        {
            set { _qb = value; }
            get { return _qb; }
        }

        public Question Ques
        {
            set { _q = value; }
            get { return _q; }
        }

        private void ExamScreenforStudent_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        public ExamScreenforStudent(QuestionBank qb)
        {
            InitializeComponent();
            this._qb = qb;
            this._q = qb.QuestionList.ToList()[0];
        }

        private void LoadQuestion()
        {
            if (_q != null)
            {
                this.lblQuestionText.Text = _q.QuestionTitle;
                RadioButton[] radioButton = new RadioButton[_q.Options.Count];
                rd = new RadioButton[_q.Options.Count];

                _options = _q.Options.ToList();
                for (int i = 0; i < _q.Options.Count; i++)
                {
                    radioButton[i] = new RadioButton();
                    radioButton[i].Location = new Point(30, 65 + i * 20);
                    radioButton[i].Text = _options[i].Value;
                    radioButton[i].AutoSize = true;
                    this.Controls.Add(radioButton[i]);
                    rd[i] = radioButton[i];
                }
            }            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                for (int i = 0; i < rd.Length; i++)
                {
                    if (rd[i].Checked) 
                    {
                        if (_options[i].Code == _q.CorrectOption)
                            totalPoints += _q.GradePoint;
                    }
                }
                index--;
                this._q = _qb.QuestionList.ToList()[index];
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("This is the first question!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < _qb.QuestionList.Count-1)
            {
                for (int i = 0; i < rd.Length; i++)
                {
                    if (rd[i].Checked)
                    {
                        if (_options[i].Code == _q.CorrectOption)
                            totalPoints += _q.GradePoint;
                    }
                }
                index++;
                this._q = _qb.QuestionList.ToList()[index];
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("This is the last question!");
            }            
        }
    }
}
