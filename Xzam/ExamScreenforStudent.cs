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
    public partial class ExamScreenforStudent : Form
    {
        private QuestionBank qb;
        private Question q;
        private int index;
        public ExamScreenforStudent(QuestionBank qb,int index)
        {
            InitializeComponent();
            this.qb = qb;
            this.q = qb.QuestionList.ToList()[index];
        }

        private void LoadQuestion()
        {
            lblQuestionText.Text = this.q.QuestionTitle;
            opt1.Text = this.q.Options.ToList()[0].Value;
            opt2.Text = this.q.Options.ToList()[1].Value;
            opt3.Text = this.q.Options.ToList()[2].Value;
            opt4.Text = this.q.Options.ToList()[3].Value;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.q = qb.QuestionList.ToList()[index - 1];
            LoadQuestion();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.q = qb.QuestionList.ToList()[index + 1];
            LoadQuestion();
        }
    }
}
