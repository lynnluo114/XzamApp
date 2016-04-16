using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Xzam.Models
{
    public class QuestionBank : IEnumerable
    {
        public QuestionBank()
        {
            this.questionList = new QuestionCollection();
        }
        public QuestionBank(QuestionCollection collection)
        {
            this.questionList = collection;
        }
        public QuestionBank(Question[] collection)
        {
            this.questionList = new QuestionCollection(collection);
        }

        private String name;
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }

        }

        public String Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Title should be a valid name");
                }
                this.name = value;
            }
        }
        private Boolean backTrack;
        private Boolean shuffleQuestions;

        public Boolean BackTrack
        {
            get
            {
                return this.backTrack;
            }
            set
            {
                this.backTrack = value;
            }

        }
        public Boolean ShuffleQuestions
        {
            get
            {
                return this.shuffleQuestions;
            }
            set
            {
                this.shuffleQuestions = value;
            }

        }

        private QuestionCollection questionList;

        public QuestionCollection QuestionList
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
                questionList.AddQuestion(question);
            }
        }


        public void RemoveQuestion(int questionid)
        {
            this.questionList.RemoveQuestion(questionid);

        }

        public QuestionBank(int id, String Name)
        {
            Name = name;
            ID = id;
            questionList = new QuestionCollection();
        }

        public void Clear()
        {

            this.questionList.Clear();
        }

        public IEnumerator GetEnumerator()
        {

            for (int i = 0; i < questionList.Count; i++)
            {
                yield return (questionList.ToList()[i]);
            }
        }
    }
}
