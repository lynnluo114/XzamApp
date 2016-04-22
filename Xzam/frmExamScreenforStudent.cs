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
    public partial class frmExamScreenforStudent : Form
    {
        private QuestionBank _qb;
        private Question _q;
        private String _studentid;
        private String _examcode;
        private int _scheduleid;
        private int _index = 0;
        private double _gradePoints = 0;
        private double _grade = 0;
        private RadioButton[] rd;
        private List<Option> _options;
        QuestionDataAccess qda;
        StudentGradeDataAccess sgda;
        StudentScheduleDataAccess ssda;

        private void ExamScreenforStudent_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        public frmExamScreenforStudent(String studentid,int scheduleid,String examcode, int qbankid)
        {
            InitializeComponent();
            qda = new QuestionDataAccess() ;
            sgda = new StudentGradeDataAccess();
            ssda = new StudentScheduleDataAccess();
            _qb = new QuestionBank(qda.GetList(qbankid));
            _q = _qb.QuestionList.ToList()[0];
            _studentid = studentid;
            _examcode = examcode;
            _scheduleid = scheduleid;
            foreach (Question q in _qb.QuestionList)
                _gradePoints += q.GradePoint;
            //this.btnPrev.Visible = _qb.BackTrack;
        }

        private void LoadQuestion()
        {
            if (_q != null)
            {
                if (rd != null)
                {
                    for (int i = 0; i < rd.Length; i++)
                        this.Controls.Remove(rd[i]);
                }
                this.labelQuestionText.Text = _q.QuestionTitle;
                RadioButton[] radioButton = new RadioButton[_q.Options.Count];
                rd = new RadioButton[_q.Options.Count];

                _options = _q.Options.ToList();
                for (int i = 0; i < _q.Options.Count; i++)
                {
                    radioButton[i] = new RadioButton();
                    radioButton[i].Location = new Point(20, 5 + i * 20);
                    radioButton[i].Text = _options[i].Code + "." + _options[i].Value;
                    radioButton[i].AutoSize = true;
                    this.Controls.Add(radioButton[i]);                    
                    rd[i] = radioButton[i];
                }
                this.panelOptions.Controls.AddRange(rd);
                //this.Controls.AddRange(rd);
            }            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_index > 0)
            {
                for (int i = 0; i < rd.Length; i++)
                {
                    if (rd[i].Checked) 
                    {
                        if (_options[i].Code == _q.CorrectOption)
                            _grade += _q.GradePoint;
                    }
                }
                _index--;
                this._q = _qb.QuestionList.ToList()[_index];
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("This is the first question!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_index < _qb.QuestionList.Count-1)
            {
                for (int i = 0; i < rd.Length; i++)
                {
                    if (rd[i].Checked)
                    {
                        if (_options[i].Code == _q.CorrectOption)
                            _grade += _q.GradePoint;
                    }
                }
                _index++;
                this._q = _qb.QuestionList.ToList()[_index];
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("This is the last question!");
            }            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attempt score: " + _grade + " out of " + _gradePoints);
            ssda.SaveStudentSchedule(_studentid, _scheduleid, _grade);
            sgda.SaveStudentGrade(_studentid, _examcode, _gradePoints);
        }
    }
}
