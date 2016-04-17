using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Xzam.Models
{
    public class Question : IEnumerable
    {
        private int qid;

        private Char correctOption;
        private OptionCollection options;
        private String questionTitle;
        private Boolean shuffleOptions;
        private int questionbankid;

        public int Questionbankid
        {
            get { return questionbankid; }
            set { questionbankid = value; }
        }
        private double gradePoint = 1;
        public int QuestionID
        {
            get
            {
                return qid;
            }
            set
            {
                this.qid = value;
            }

        }
        public Boolean ShuffleOptions
        {
            get
            {
                return shuffleOptions;
            }
            set
            {
                shuffleOptions = value;
            }

        }

        public double GradePoint
        {
            get { return gradePoint; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Grade must be a valid positive number. Decimals also supported.");
                }
                this.gradePoint = value;
            }

        }
        public Char CorrectOption
        {
            get
            {
                return correctOption;
            }
            set
            {

                correctOption = value;
            }
        }
        public String QuestionTitle
        {
            get { return this.questionTitle; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Question title is required");
                }
                this.questionTitle = value;
            }

        }
        public Question() {
            options = new OptionCollection();
        }
        public Question(int questionID, String questionTitle, Char correctOption)
        {
            QuestionTitle = questionTitle;
            CorrectOption = correctOption;
            options = new OptionCollection();
        }
        public Question(int questionID, String questionTitle, Char correctOption, Boolean shuffleOptions,double gradepoint, int questionbankid)
        {
            QuestionID = questionID;
            QuestionTitle = questionTitle;
            CorrectOption = correctOption;
            ShuffleOptions = shuffleOptions;
            GradePoint = gradepoint;
            Questionbankid =questionbankid;
            this.options = new OptionCollection();
        }
        public OptionCollection Options {
            get {
                return this.options;
                
            }
        }

        public void Clear() {
            this.options = null;
            this.options = new OptionCollection();
        }
        public Question(int questionID, String questionTitle, Char correctOption, Boolean shuffleOptions,double gradepoint, int questionbankid, OptionCollection collection)
        {
            QuestionID = questionID;
            QuestionTitle = questionTitle;
            CorrectOption = correctOption;
            ShuffleOptions = shuffleOptions;
            GradePoint = gradepoint;
            Questionbankid = questionbankid;
            if (collection != null)
                options.AddOptionRange(collection);


        }

        public void AddOption(Option opt)
        {
            if (opt != null)
            {
                options.AddOption(opt);
            }
        }
        public void AddOptionRange(OptionCollection collection)
        {
            options.AddOptionRange(collection);
        }

        // for non generic iteration
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < options.Count; i++)
            {
                yield return (options.ToList()[i]);
            }
        }
    }
}
