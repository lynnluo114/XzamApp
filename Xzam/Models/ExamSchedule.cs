using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xzam.Models
{
    class ExamSchedule
    {
        private int scheduleID;
        private int questionBankID;
        private String examCode;
        private String examTitle;
        private DateTime scheduleDate;
        private String startTime;
        private String endTime;

        public int ScheduleID
        {
            get { return this.scheduleID; }
            set { this.scheduleID = value; }
        }

        public int QuestionBankID
        {
            get { return this.questionBankID; }
            set { this.questionBankID = value; }
        }
        public String ExamCode
        {
            get { return this.examCode; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Exam Code is required!");
                }
                this.examCode = value;
            }
        }

        public String ExamTitle
        {
            get { return this.examTitle; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Exam Title is required!");
                }
                this.examTitle = value;
            }
        }

        public DateTime ScheduleDate
        {
            get { return this.scheduleDate; }
            set
            {
                this.scheduleDate = value;
            }
        }

        public String StartTime
        {
            get { return this.startTime; }
            set
            {
                /*if (value < DateTime.Now)
                {
                    throw new Exception("Start Time must be later than now!");
                }*/
                this.startTime = value;
            }
        }

        public String EndTime
        {
            get { return this.endTime; }
            set
            {
                /*if (value < DateTime.Now)
                {
                    throw new Exception("End Time must be later than now!");
                }*/
                this.endTime = value;
            }
        }

        public ExamSchedule(int scheduleID, int questionBankID, String examCode,String examTitle, DateTime scheduleDate, String startTime, String endTime)
        {
            ScheduleID = scheduleID;
            QuestionBankID = questionBankID;
            ExamCode = examCode;
            ExamTitle = examTitle;
            ScheduleDate = scheduleDate;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
