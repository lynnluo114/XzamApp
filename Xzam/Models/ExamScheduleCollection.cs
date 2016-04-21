using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Xzam.Models
{
    class ExamScheduleCollection:IEnumerable
    {
        private List<ExamSchedule> examScheduleList;

        public ExamScheduleCollection()
        {
            this.examScheduleList = new List<ExamSchedule>();
        }
        public ExamScheduleCollection(List<ExamSchedule> collection)
        {
            this.examScheduleList = collection;
        }
        public ExamScheduleCollection(ExamSchedule[] collection)
        {
            this.examScheduleList = new List<ExamSchedule>();
            this.examScheduleList.AddRange(collection);
        }


        public int Count
        {
            get
            {
                return examScheduleList.Count;
            }
        }
        public List<ExamSchedule> ExamScheduleList
        {
            get
            {
                return examScheduleList;
            }
            set
            {
                examScheduleList = value;
            }
        }

        public void AddExamSchedule(ExamSchedule examSchedule)
        {
            if (examSchedule != null)
            {
                examScheduleList.Add(examSchedule);
            }
        }
        public void AddExamScheduleRange(IEnumerable<ExamSchedule> collection)
        {
            if (collection != null)
            {

                examScheduleList.AddRange(collection);
            }
        }

        public List<ExamSchedule> ToList()
        {
            return this.examScheduleList;
        }
        public void AddExamScheduleRange(ExamScheduleCollection collection)
        {
            if (collection != null)
            {
                examScheduleList.AddRange(collection.ToList());
            }
        }

        public void RemoveExamSchedule(int scheduleID)
        {
            int i = 0;
            foreach (ExamSchedule e in examScheduleList)
            {
                if (e.ScheduleID == scheduleID)
                {
                    this.examScheduleList.RemoveAt(i);
                }
                ++i;
            }
        }


        public void Clear()
        {

            this.examScheduleList.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < examScheduleList.Count; i++)
            {
                yield return (examScheduleList[i]);
            }
        }
    }
}
