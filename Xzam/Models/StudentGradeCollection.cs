using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Xzam.Models
{
    class StudentGradeCollection : IEnumerable
    {
        private List<StudentGrade> studentGradeList;

        public StudentGradeCollection()
        {
            this.StudentGradeList = new List<StudentGrade>();
        }
        public StudentGradeCollection(List<StudentGrade> collection)
        {
            this.StudentGradeList = collection;
        }
        public StudentGradeCollection(StudentGrade[] collection)
        {
            this.StudentGradeList = new List<StudentGrade>();
            this.StudentGradeList.AddRange(collection);
        }


        public int Count
        {
            get
            {
                return studentGradeList.Count;
            }
        }
        public List<StudentGrade> StudentGradeList
        {
            get
            {
                return StudentGradeList;
            }
            set
            {
                StudentGradeList = value;
            }
        }

        public void AddStudentGrade(StudentGrade StudentGrade)
        {
            if (StudentGrade != null)
            {
                StudentGradeList.Add(StudentGrade);
            }
        }
        public void AddStudentGradeRange(IEnumerable<StudentGrade> collection)
        {
            if (collection != null)
            {

                StudentGradeList.AddRange(collection);
            }
        }

        public List<StudentGrade> ToList()
        {
            return this.StudentGradeList;
        }
        public void AddStudentGradeRange(StudentGradeCollection collection)
        {
            if (collection != null)
            {
                StudentGradeList.AddRange(collection.ToList());
            }
        }

        public void RemoveStudentGrade(String studentID, String examCode)
        {
            int i = 0;
            foreach (StudentGrade sg in StudentGradeList)
            {
                if (sg.StudentID == studentID && sg.ExamCode == examCode)
                {
                    this.StudentGradeList.RemoveAt(i);
                }
                ++i;
            }
        }


        public void Clear()
        {

            this.StudentGradeList.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < StudentGradeList.Count; i++)
            {
                yield return (StudentGradeList[i]);
            }
        }
    }
}
