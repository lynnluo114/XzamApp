using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xzam.Models
{
    class Exam
    {
        private String examCode;
        private String examTitle;

        public String ExamCode
        {
            get { return examCode; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Exam Code cannot be empty!");
                }
                this.examCode = value;
            }
        }

        public String ExamTitle
        {
            get { return examTitle; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Exam Title cannot be empty!");
                }
                this.examTitle = value;
            }
        }
    }
}
