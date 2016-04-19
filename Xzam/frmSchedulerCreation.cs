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
            String examcode = examCodeList.SelectedItem.ToString();
            int qbankid = 0;
            String studentid = "";
            int scheduleid = 0;
            foreach (QuestionBank qbank in qbda.GetList())
            {
                if (qbank.Name.Equals(qbankList.SelectedItem.ToString()))
                    qbankid = qbank.ID;
            }
            foreach (Student stu in sda.GetList())
            {
                if (stu.StudentName.Equals(studentList.SelectedItem.ToString()))
                    studentid = stu.StudentID;
            }
            String scheduledate = scheduledDate.Value.ToShortDateString();
            String starttime = startTime.Value.ToShortTimeString();
            String endtime = endTime.Value.ToShortTimeString();
            ExamSchedule es = new ExamSchedule(scheduleid,qbankid,examcode,scheduledate,starttime,endtime);
            try
            {
                scheduleid = esda.SaveData(es);
                Student student = new Student(studentid, scheduleid);
                sda.SaveData(student);
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

        private void moveRight_Click(object sender, EventArgs e)
        {
            string ErrNoSelection = "Cannot move - please select a student!";

            if (studentList.SelectedItems.Count == 0)
                MessageBox.Show(ErrNoSelection);
            else
            {
                foreach (string item in studentList.SelectedItems)
                {
                    attendStudentList.Items.Add(item);
                }
                while (studentList.SelectedItems.Count > 0)
                {
                    studentList.Items.Remove(studentList.SelectedItems[0]);
                }
            }
        }

        private void moveLef_Click(object sender, EventArgs e)
        {
            string ErrNoSelection = "Cannot move - please select a student!";
            if (attendStudentList.SelectedItems.Count == 0)
                MessageBox.Show(ErrNoSelection);
            else
            {
                foreach (string item in attendStudentList.SelectedItems)
                {
                    studentList.Items.Add(item);
                }
                while (attendStudentList.SelectedItems.Count > 0)
                {
                    attendStudentList.Items.Remove(attendStudentList.SelectedItems[0]);
                }
            }
        }
    }   
}
