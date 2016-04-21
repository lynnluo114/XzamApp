using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xzam.Models
{
    public class StudentSchedule
    {
        private String _studentid;
        private int _scheduleid;
        private double _grade;

        public String StudentID
        {
            get { return this._studentid; }
            set { _studentid = value; }
        }

        public int ScheduleID
        {
            get { return this._scheduleid; }
            set { _scheduleid = value; }
        }

        public double Grade
        {
            get { return this._grade; }
            set { _grade = value; }
        }

        public StudentSchedule()
        {
        }

        public StudentSchedule(String studentID, int scheduleID, double grade)
        {
            StudentID = studentID;
            ScheduleID = scheduleID;
            Grade = grade;
        }
    }
}
