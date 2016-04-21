using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xzam.Models
{
    public class StudentGrade
    {
        private String _studentid;
        private String _examcode;
        private double _gradepoints;

        public String StudentID
        {
            get { return this._studentid; }
            set { _studentid = value; }
        }

        public String ExamCode
        {
            get { return this._examcode; }
            set { _examcode = value; }
        }

        public double GradePoints
        {
            get { return this._gradepoints; }
            set { _gradepoints = value; }
        }

        public StudentGrade(String studentID,String examCode,double gradePoints)
        {
            StudentID = studentID;
            ExamCode = examCode;
            GradePoints = gradePoints;
        }
    }
}
