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
    public partial class frmSchedulerCreation : Form
    {
        private ExamDataAccess eda;
        private StudentDataAccess sda;
        private ExamScheduleDataAccess esda;
        private QuestionBankDataAccess qbda;
        

        public frmSchedulerCreation()
        {
            InitializeComponent();
            eda = new ExamDataAccess();
            sda = new StudentDataAccess();
            esda = new ExamScheduleDataAccess();
            qbda = new QuestionBankDataAccess();
        }

        private void LoadExam()
        {
            examCodeList.Items.Clear();
            examTitleList.Items.Clear();

            foreach (Exam exam in eda.GetList())
            {
                examCodeList.Items.Add(exam.ExamCode);
                examTitleList.Items.Add(exam.ExamTitle);
            }
        }

        private void LoadStudent()
        {
            studentList.Items.Clear();

            foreach (Student student in sda.GetList())
            {
                if (!student.StudentID.Equals("admin"))
                    studentList.Items.Add(student.StudentName);
            }
        }

        private void LoadQbank()
        {
            qbankList.Items.Clear();
            foreach (QuestionBank qbank in qbda.GetList())
            {
                qbankList.Items.Add(qbank.Name);
            }
        }
        private void frmSchedulerCreation_Load(object sender, EventArgs e)
        {
            LoadExam();
            LoadStudent();
            LoadQbank();
        }

        private void examCodeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Exam exam in eda.GetList())
            {
                if (exam.ExamCode.Equals(examCodeList.SelectedItem.ToString()))
                {
                    examTitleList.SelectedItem = exam.ExamTitle;
                }
            }
        }

        private void examTitleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Exam exam in eda.GetList())
            {
                if (exam.ExamTitle.Equals(examTitleList.SelectedItem.ToString()))
                {
                    examCodeList.SelectedItem = exam.ExamCode;
                }
            }
        }

        private void but_Create_Click(object sender, EventArgs e)
        {
            bool success = true;
            String examcode = "";
            String examtitle = "";
            int qbankid = 0;
            int scheduleid = 0;
            DateTime scheduledate = DateTime.Now;
            String starttime = "";
            String endtime = "";
            //Valiate and get Exam Code from user input
            if (examCodeList.SelectedItem.ToString().Equals(""))
            {
                success = false;
                MessageBox.Show("Please select an Exam Code!");
            }
            else
            {
                examcode = examCodeList.SelectedItem.ToString();
            }
            //Validate and get Exam Title from user input
            if (examTitleList.SelectedItem.ToString().Equals(""))
            {
                success = false;
                MessageBox.Show("Please select an Exam Title!");
            }
            else
            {
                examtitle = examTitleList.SelectedItem.ToString();
            }

            //Validate and get QuestionBank ID from user input
            if (qbankList.SelectedItem.ToString().Equals(""))
            {
                success = false;
                MessageBox.Show("Please select Question Bank!");
            }
            else
            {
                foreach (QuestionBank qbank in qbda.GetList())
                {
                    if (qbank.Name.Equals(qbankList.SelectedItem.ToString()))
                        qbankid = qbank.ID;
                }
            }

            if (scheduledDate.Value.ToString().Equals(""))
            {
                success = false;
                MessageBox.Show("Schdule Date is required!");
            }
            else
            {
                scheduledate = scheduledDate.Value;
            }
            if (startTime.Value.ToString().Equals(""))
            {
                success = false;
                MessageBox.Show("Start Time is required!");
            }
            else
            {
                starttime = startTime.Value.ToShortTimeString();
            }
            if (endTime.Value.ToString().Equals(""))
            {
                success = false;
                MessageBox.Show("End Time is required!");
            }
            else
            {
                endtime = endTime.Value.ToShortTimeString();
            }

            ExamSchedule es = new ExamSchedule(scheduleid, qbankid, examcode, examtitle, scheduledate, starttime, endtime);
            try
            {
                scheduleid = esda.SaveData(es);
                MessageBox.Show("Data saved successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                es = null;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
