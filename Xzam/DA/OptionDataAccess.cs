using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xzam.Models;
using System.Data.SqlClient;
namespace Xzam.DA
{
    class OptionDataAccess
    {
        public OptionDataAccess( ) {
            XDbConnection.Connect(); 
        }
        ~OptionDataAccess()
        {
            XDbConnection.Disconnect();
        }

        public int SaveData(Option option) {
            if (option == null)
            {
                throw new Exception("No data found to save");
            }
            int id;
            try
            {
                //(@title nvarchar(50), @gradepoint bit,@shuffleoptions bit=0,@correctoption char(1),
                //@qbankid int, @qid int output)  
                SqlParameter[] scol =new SqlParameter[4]; 
                scol[0] = new SqlParameter("@qid", option.Quest.QuestionID);
                scol[1] = new SqlParameter("@code", option.Code);
                scol[2] = new SqlParameter("@optiontext", option.Value); 
                scol[3] = new SqlParameter();
                scol[3].ParameterName = "@oid";
                scol[3].SqlDbType = System.Data.SqlDbType.Int;
                scol[3].Direction = System.Data.ParameterDirection.Output;
                id = XDbConnection.ExecuteWithParam("proc_SaveOptions", scol, "@oid");
                 
                 return id;
            }
            catch (Exception)
            {
                
                throw;
            } 
            
        }
        public void DeleteData(int questionid) {
            try
            {
                //(@title nvarchar(50), @gradepoint bit,@shuffleoptions bit=0,@correctoption char(1),
                //@qbankid int, @qid int output)  
                SqlParameter[] scol = new SqlParameter[1];
                scol[0] = new SqlParameter("@qid", questionid);

                XDbConnection.ExecuteWithParam("proc_deleteOptions", scol); ;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int UpdateData(Option option)
        {
            if (option == null)
            {
                throw new Exception("No data found to update");
            } 
            try
            {
                //(@title nvarchar(50), @gradepoint bit,@shuffleoptions bit=0,@correctoption char(1),
                //@qbankid int, @qid int output)  
                SqlParameter[] scol = new SqlParameter[4];
                scol[0] = new SqlParameter("@qid", option.Quest.QuestionID);
                scol[1] = new SqlParameter("@code", option.Code);
                scol[2] = new SqlParameter("@optiontext", option.Value); 
                scol[3] = new SqlParameter("@oid", option.OId);
  
                return XDbConnection.ExecuteWithParam("proc_updateOptions", scol);;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public OptionCollection GetList(Question question) {
            OptionCollection optionlist = new OptionCollection();
            Option option;
 
            using (SqlDataReader sdr = XDbConnection.ReadDataProc("proc_getOptions",
                    new SqlParameter[1] { new SqlParameter("@questionid", question.QuestionID) }))
            {
                while (sdr.Read())
                {
                    option = new Option(sdr["code"].ToString().ToCharArray()[0],sdr["optiontext"].ToString(),question);
                    optionlist.AddOption(option);
                }
                option = null;
                sdr.Close();// not necessary but still to be on the safe side
            }
            return optionlist;
        }
    }
}
