using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Xzam.Models
{
    class StudentScheduleCollection : IEnumerable
    {
        private List<StudentSchedule> studentScheduleList;

        public StudentScheduleCollection()
        {
            this.studentScheduleList = new List<StudentSchedule>();
        }
        public StudentScheduleCollection(List<StudentSchedule> collection)
        {
            this.studentScheduleList = collection;
        }
        public StudentScheduleCollection(StudentSchedule[] collection)
        {
            this.studentScheduleList = new List<StudentSchedule>();
            this.studentScheduleList.AddRange(collection);
        }


        public int Count
        {
            get
            {
                return StudentScheduleList.Count;
            }
        }
        public List<StudentSchedule> StudentScheduleList
        {
            get
            {
                return StudentScheduleList;
            }
            set
            {
                StudentScheduleList = value;
            }
        }

        public void AddStudentSchedule(StudentSchedule StudentSchedule)
        {
            if (StudentSchedule != null)
            {
                StudentScheduleList.Add(StudentSchedule);
            }
        }
        public void AddStudentScheduleRange(IEnumerable<StudentSchedule> collection)
        {
            if (collection != null)
            {

                StudentScheduleList.AddRange(collection);
            }
        }

        public List<StudentSchedule> ToList()
        {
            return this.StudentScheduleList;
        }
        public void AddStudentScheduleRange(StudentScheduleCollection collection)
        {
            if (collection != null)
            {
                StudentScheduleList.AddRange(collection.ToList());
            }
        }

        public void RemoveStudentSchedule(String studentID, int scheduleID)
        {
            int i = 0;
            foreach (StudentSchedule ss in StudentScheduleList)
            {
                if (ss.StudentID == studentID && ss.ScheduleID == scheduleID)
                {
                    this.StudentScheduleList.RemoveAt(i);
                }
                ++i;
            }
        }


        public void Clear()
        {

            this.StudentScheduleList.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < StudentScheduleList.Count; i++)
            {
                yield return (StudentScheduleList[i]);
            }
        }
    }
}
