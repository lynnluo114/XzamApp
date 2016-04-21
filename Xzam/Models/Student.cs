using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xzam.Models
{
    public class Student
    {
        private String sid;
        private String studentName;
        private String userName;
        private String password;
        private int scheduleid;
        private int userid;

        public String StudentID
        {
            get { return this.sid; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Student ID is required!");
                }
                this.sid = value;
            }
        }

        public String StudentName
        {
            get { return this.studentName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Student Name is required!");
                }
                this.studentName = value;
            }
        }

        public String UserName
        {
            get { return this.userName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("User Name is required!");
                }
                this.userName = value;
            }
        }

        public String Password
        {
            get { return this.password; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Password is required!");
                }
                this.password = value;
            }
        }

        public int ScheduleID
        {
            get { return this.scheduleid; }
            set { this.scheduleid = value; }
        }

        public int UserID
        {
            get { return this.userid; }
            set
            {
                this.userid = value;
            }
        }

        public Student(String studentID, String studentName, String userName, String password)
        {
            StudentID = studentID;
            StudentName = studentName;
            UserName = userName;
            Password = password;
        }

        public Student(String studentID,String studentName)
        {
            StudentID = studentID;
            StudentName = studentName;
        }

        public Student(String studentID, int scheduleID)
        {
            StudentID = studentID;
            ScheduleID = scheduleID;
        }
    }
}
