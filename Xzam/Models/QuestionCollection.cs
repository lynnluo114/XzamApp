using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Xzam.Models
{
    public class QuestionCollection : IEnumerable
    {
        private List<Question> questionList;

        public QuestionCollection()
        {
            this.questionList = new List<Question>();
        }
        public QuestionCollection(List<Question> collection)
        {
            this.questionList = collection;
        }
        public QuestionCollection(Question[] collection)
        {
            this.questionList = new List<Question>();
            this.questionList.AddRange(collection);
        }


        public int Count
        {
            get
            {
                return questionList.Count;
            }
        }
        public List<Question> QuestionList
        {
            get
            {
                return questionList;
            }
            set
            {
                questionList = value;
            }
        }

        public void AddQuestion(Question question)
        {
            if (question != null)
            {
                questionList.Add(question);
            }
        }
        public void AddQuestionRange(IEnumerable<Question> collection)
        {
            if (collection != null)
            {

                questionList.AddRange(collection);
            }
        }
        public void AddQuestionRange(Question[] collection)
        {


        }
        public List<Question> ToList()
        {
            return this.questionList;
        }
        public void AddQuestionRange(QuestionCollection collection)
        {
            if (collection != null)
            {
                questionList.AddRange(collection.ToList());
            }
        }

        public void RemoveQuestion(int questionid)
        {
            int i = 0;
            foreach (Question q in questionList)
            {
                if (q.QuestionID == questionid)
                {
                    this.questionList.RemoveAt(i);
                }
                ++i;
            }
        }


        public void Clear()
        {

            this.questionList.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < questionList.Count; i++)
            {
                yield return (questionList[i]);
            }
        }
    }
}
