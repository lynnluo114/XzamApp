using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xzam.Models;
namespace Xzam.DA
{
    class QuestionBankDataAccess
    {
        private QuestionBank qbank;
        public QuestionBankDataAccess(QuestionBank qbank) {
            XDbConnection.Connect();
            this.qbank = qbank;
        }
        ~QuestionBankDataAccess() {
            XDbConnection.Disconnect();
        }

        public void SaveData() { 
            if(this.qbank==null){
                throw new Exception("No data found to save");
            }
            XDbConnection.ExecuteSQL(String.Format("INSERT INTO [dbo].[QuestionBank]" +
           "([name]" +
           ",[backtrack]" +
           ",[shufflequestions])" +
        " VALUES" +
           "('{0}'" +
           ",{1}" +
           ",{2})",this.qbank.Name,(qbank.BackTrack?1:0),(qbank.ShuffleQuestions?1:0)));

            if (qbank.QuestionList != null) { 
                 
            }

        }
        
    }
}
