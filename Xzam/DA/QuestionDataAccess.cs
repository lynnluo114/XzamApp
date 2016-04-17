using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xzam.Models;
using System.Data.SqlClient;
namespace Xzam.DA
{
    class QuestionDataAccess
    { 
        public QuestionDataAccess( ) {
            XDbConnection.Connect(); 
        }
        ~QuestionDataAccess() {
            XDbConnection.Disconnect();
        }

        public int SaveData(Question ques) {
            if (ques == null)
            {
                throw new Exception("No data found to save");
            }
            int id;
            try
            {
                //(@title nvarchar(50), @gradepoint bit,@shuffleoptions bit=0,@correctoption char(1),
                //@qbankid int, @qid int output)  
                SqlParameter[] scol =new SqlParameter[6]; 
                scol[0] = new SqlParameter("@title", ques.QuestionTitle); 
                scol[1]=new SqlParameter("@gradepoint", ques.GradePoint);
                scol[2] = new SqlParameter("@shuffleoptions", ques.ShuffleOptions);
                scol[3] = new SqlParameter("@correctoption", ques.CorrectOption);
                scol[4] = new SqlParameter("@qbankid", ques.Questionbankid);
                scol[5] = new SqlParameter();
                scol[5].ParameterName = "@qid";
                scol[5].SqlDbType = System.Data.SqlDbType.Int;
                scol[5].Direction = System.Data.ParameterDirection.Output;
                id = XDbConnection.ExecuteWithParam("proc_saveQuestion", scol, "@qid");
                ques.QuestionID = id;
                if (ques.Options != null)
                {
                    OptionDataAccess oda = new OptionDataAccess();
                    if (ques.Options.Count > 0) {
                        oda.DeleteData(ques.QuestionID);
                        foreach (Option item in ques.Options)
                        {
                            oda.SaveData(item);
                            // statements to save options
                        }
                    }
                }

                 return id;
            }
            catch (Exception)
            {
                
                throw;
            } 
            
        }
        public void DeleteData(int questionbankid) {
            try
            {
                //(@title nvarchar(50), @gradepoint bit,@shuffleoptions bit=0,@correctoption char(1),
                //@qbankid int, @qid int output)  
                SqlParameter[] scol = new SqlParameter[1];
                scol[0] = new SqlParameter("@qbankid", questionbankid);

                XDbConnection.ExecuteWithParam("proc_deleteQuestions", scol); ;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int UpdateData(Question ques)
        {
            if (ques == null)
            {
                throw new Exception("No data found to update");
            } 
            try
            {
                //(@title nvarchar(50), @gradepoint bit,@shuffleoptions bit=0,@correctoption char(1),
                //@qbankid int, @qid int output)  
                SqlParameter[] scol = new SqlParameter[6];
                scol[0] = new SqlParameter("@title", ques.QuestionTitle);
                scol[1] = new SqlParameter("@gradepoint", ques.GradePoint);
                scol[2] = new SqlParameter("@shufflequestions", ques.ShuffleOptions);
                scol[3] = new SqlParameter("@correctoption", ques.CorrectOption);
                scol[4] = new SqlParameter("@qbankid", ques.Questionbankid);
                scol[5] = new SqlParameter("@qid", ques.QuestionID);
  
                return XDbConnection.ExecuteWithParam("proc_updateQuestion", scol);;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public QuestionCollection GetList(int questionbankid) {
            QuestionCollection qblist = new QuestionCollection();
            OptionDataAccess oda = new OptionDataAccess();
            Question qb; 
 
            using (SqlDataReader sdr = XDbConnection.ReadDataProc("proc_getQuestions", 
                    new SqlParameter[1]{ new SqlParameter("@qbankid",questionbankid) }))
            {
                while (sdr.Read())
                {
                    qb = new Question((int)sdr["qid"],sdr["title"].ToString(),
                                sdr["correctoption"].ToString().ToCharArray()[0],
                               (bool)sdr["shuffleoptions"],
                                double.Parse(sdr["gradepoint"].ToString()),questionbankid);
                    
                     
                    qblist.AddQuestion(qb);
                    
                }
                foreach (Question ques in qblist)
                {
                    ques.AddOptionRange(oda.GetList(ques));
                }
                qb = null;
                sdr.Close();// not necessary but still to be on the safe side
            }
 
            return qblist;
        }
        
    }
}
