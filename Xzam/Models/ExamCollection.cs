using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Xzam.Models
{
    class ExamCollection:IEnumerable
    {
        private List<Exam> examList;

        public ExamCollection()
        {
            this.examList = new List<Exam>();
        }
        public ExamCollection(List<Exam> collection)
        {
            this.examList = collection;
        }
        public ExamCollection(Exam[] collection)
        {
            this.examList = new List<Exam>();
            this.examList.AddRange(collection);
        }


        public int Count
        {
            get
            {
                return examList.Count;
            }
        }
        public List<Exam> StudentList
        {
            get
            {
                return examList;
            }
            set
            {
                examList = value;
            }
        }

        public void AddExam(Exam exam)
        {
            if (exam != null)
            {
                examList.Add(exam);
            }
        }
        public void AddExamRange(IEnumerable<Exam> collection)
        {
            if (collection != null)
            {

                examList.AddRange(collection);
            }
        }

        public List<Exam> ToList()
        {
            return this.examList;
        }
        public void AddExamRange(ExamCollection collection)
        {
            if (collection != null)
            {
                examList.AddRange(collection.ToList());
            }
        }

        public void RemoveExam(String examCode)
        {
            int i = 0;
            foreach (Exam e in examList)
            {
                if (e.ExamCode == examCode)
                {
                    this.examList.RemoveAt(i);
                }
                ++i;
            }
        }


        public void Clear()
        {

            this.examList.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < examList.Count; i++)
            {
                yield return (examList[i]);
            }
        }
    }
}
