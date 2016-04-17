using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xzam.Models
{
    public class Option
    {
        private char code;
        private String _value;
        private Question question;
        private int oid;
        public int OId {
            get { return oid; }
            set { oid = value; }
        }
        public Question Quest {
            get {
                return question;
            }
            set {
                if (value == null) {
                    throw new Exception("Question is not associated");
                }
                question = value;
            }
        }
        public Option() {
            
        }
        public char Code
        {
            get { return code; }
            set
            {
                if (value == ' ')
                {
                    throw new Exception("Code cannot be empty");
                }
                this.code = value;
            }
        }
        public String Value
        {
            get { return _value; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Code cannot be empty");
                }
                this._value = value;
            }
        }
        public Option(char code, String value, Question question)
        {
            Code = code;
            Value = value;
            Quest = question;
        }
    }
}
