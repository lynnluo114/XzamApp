using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xzam.Models;
using System.Data.SqlClient;
namespace Xzam.DA
{
    class QuestionBankDataAccess
    { 
        public QuestionBankDataAccess( ) {
            XDbConnection.Connect(); 
        }
        ~QuestionBankDataAccess() {
            XDbConnection.Disconnect();
        }

        public void SaveData(QuestionBank qbank) { 
            if(qbank==null){
                throw new Exception("No data found to save");
            }
            try
            {
                SqlParameter[] scol =new SqlParameter[4]; 
                scol[0] = new SqlParameter("@name", qbank.Name);
                scol[1]=new SqlParameter("@backtrack", qbank.Name);
                scol[2]=new SqlParameter("@shufflequestions", qbank.Name);
                scol[3] = new SqlParameter();
                scol[3].ParameterName = "@id";
                scol[3].Direction = System.Data.ParameterDirection.Output;
                int id = XDbConnection.ExecuteWithParam("proc_saveData",scol,"@id"); 
                        /*
                        String.Format("INSERT INTO [dbo].[QuestionBank]" +
                   "([name]" +
                   ",[backtrack]" +
                   ",[shufflequestions])" +
                " VALUES" +
                   "('{0}'" +
                   ",{1}" +
                   ",{2})", qbank.Name, (qbank.BackTrack ? 1 : 0), (qbank.ShuffleQuestions ? 1 : 0)));
             */
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
        public void UpdateData(QuestionBank qbank) {
            if (qbank == null)
            {
                throw new Exception("No data found to update");
            }
 

            try 
	        {	        
		            XDbConnection.ExecuteSQL(String.Format("update  [dbo].[QuestionBank]" +
                   "set name='{0}'" +
                   ",set backtrack={1}" +
                   ",shufflequestions={2} where id={3}"  , 
                   qbank.Name, (qbank.BackTrack ? 1 : 0), (qbank.ShuffleQuestions ? 1 : 0),qbank.ID));
	        }
	        catch (Exception e)
	        {
		
		        throw new Exception(e.Message);
	        }
             
        }

        public List<QuestionBank> GetList() {
             List<QuestionBank> qblist = new List<QuestionBank>();
            QuestionBank qb;
            using (SqlDataReader sdr = XDbConnection.ReadData(String.Format("Select id,name,backtrack,shufflequestions from questionbank")))
            {
                while (sdr.Read())
                {
                    qb = new QuestionBank(sdr.GetInt32(0), sdr.GetString(1), sdr.GetBoolean(2), sdr.GetBoolean(3));

                    qblist.Add(qb);
                }
                qb = null;
                sdr.Close();// not necessary but still to be on the safe side
            }
            return qblist;
        }
        
    }
}
