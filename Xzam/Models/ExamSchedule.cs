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
        private DateTime startTime;
        private DateTime endTime;

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
                if (value < DateTime.Now.Date)
                {
                    throw new Exception("Schedule Date must be later than current date!");
                }
                this.scheduleDate = value;
            }
        }

        public DateTime StartTime
        {
            get { return this.startTime; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new Exception("Start Time must be later than now!");
                }
                this.startTime = value;
            }
        }

        public DateTime EndTime
        {
            get { return this.endTime; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new Exception("End Time must be later than now!");
                }
                this.endTime = value;
            }
        }

        public ExamSchedule(int scheduleID, int questionBankID, String examCode, DateTime scheduleDate, DateTime startTime, DateTime endTime)
        {
            ScheduleID = scheduleID;
            QuestionBankID = questionBankID;
            ExamCode = examCode;
            ScheduleDate = scheduleDate;
            StartTime = startTime;
            EndTime = endTime;
        }

    }
}
