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
        private Exam exam;
        public ExamDataAccess(Exam exam)
        {
            XDbConnection.Connect();
            this.exam = exam;
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
    }
}
