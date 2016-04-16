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

        public int SaveData(QuestionBank qbank) { 
            if(qbank==null){
                throw new Exception("No data found to save");
            }
            int id;
            try
            {
                SqlParameter[] scol =new SqlParameter[4]; 
                scol[0] = new SqlParameter("@name", qbank.Name); 
                scol[1]=new SqlParameter("@backtrack", qbank.BackTrack); 
                scol[2]=new SqlParameter("@shufflequestions", qbank.ShuffleQuestions);
                scol[3] = new SqlParameter();
                scol[3].ParameterName = "@id";
                scol[3].SqlDbType = System.Data.SqlDbType.Int;
                scol[3].Direction = System.Data.ParameterDirection.Output;
                 id = XDbConnection.ExecuteWithParam("proc_saveQuestionBank",scol,"@id");
                 return id;
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
                SqlParameter[] scol = new SqlParameter[4];
                scol[0] = new SqlParameter("@name", qbank.Name);
                scol[1] = new SqlParameter("@backtrack", qbank.BackTrack);
                scol[2] = new SqlParameter("@shufflequestions", qbank.ShuffleQuestions);
                scol[3] = new SqlParameter("@id",qbank.ID); 
                int id = XDbConnection.ExecuteWithParam("proc_updateQuestionBank",scol); 
	        }
	        catch (Exception)
	        {

                throw;
	        }
             
        }

        public List<QuestionBank> GetList() {
             List<QuestionBank> qblist = new List<QuestionBank>();
            QuestionBank qb;
            using (SqlDataReader sdr = XDbConnection.ReadData("proc_getQuestionBank"))
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
