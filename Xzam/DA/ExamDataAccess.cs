using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Xzam.Models;

namespace Xzam.DA
{
    class ExamDataAccess
    {
        public ExamDataAccess()
        {
            XDbConnection.Connect();
        }
        ~ExamDataAccess()
        {
            XDbConnection.Disconnect();
        }

        public int SaveData(Exam exam)
        {
            if (exam == null)
            {
                throw new Exception("No data found to save");
            }
            int affectedRow;
            try
            {
                SqlParameter[] scol = new SqlParameter[2];
                scol[0] = new SqlParameter("@examcode", exam.ExamCode);
                scol[1] = new SqlParameter("@examtitle", exam.ExamTitle);
                affectedRow = XDbConnection.ExecuteWithParam("proc_saveExam", scol);                
                return affectedRow;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ExamCollection GetList()
        {
            ExamCollection examlist = new ExamCollection();
            Exam exam;

            using (SqlDataReader sdr = XDbConnection.ReadDataProc("proc_getExams", null))
            {
                while (sdr.Read())
                {
                    exam = new Exam(sdr["examcode"].ToString(), sdr["examtitle"].ToString());
                    examlist.AddExam(exam);
                }
                exam = null;
                sdr.Close();// not necessary but still to be on the safe side
            }
            return examlist;
        }
    }
}
