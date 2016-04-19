using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Xzam.Models
{
    public class StudentCollection:IEnumerable
    {
        private List<Student> studentList;

        public StudentCollection()
        {
            this.studentList = new List<Student>();
        }
        public StudentCollection(List<Student> collection)
        {
            this.studentList = collection;
        }
        public StudentCollection(Student[] collection)
        {
            this.studentList = new List<Student>();
            this.studentList.AddRange(collection);
        }


        public int Count
        {
            get
            {
                return studentList.Count;
            }
        }
        public List<Student> StudentList
        {
            get
            {
                return studentList;
            }
            set
            {
                studentList = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (student != null)
            {
                studentList.Add(student);
            }
        }
        public void AddStudentRange(IEnumerable<Student> collection)
        {
            if (collection != null)
            {

                studentList.AddRange(collection);
            }
        }

        public List<Student> ToList()
        {
            return this.studentList;
        }
        public void AddStudentRange(StudentCollection collection)
        {
            if (collection != null)
            {
                studentList.AddRange(collection.ToList());
            }
        }

        public void RemoveStudent(String Studentid)
        {
            int i = 0;
            foreach (Student q in studentList)
            {
                if (q.StudentID == Studentid)
                {
                    this.studentList.RemoveAt(i);
                }
                ++i;
            }
        }


        public void Clear()
        {

            this.studentList.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                yield return (studentList[i]);
            }
        }
    }
}
