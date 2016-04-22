using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xzam.Models;
using System.Data.SqlClient;

namespace Xzam.DA
{
    class StudentGradeDataAccess
    {
        public StudentGradeDataAccess()
        {
            XDbConnection.Connect();
        }
        ~StudentGradeDataAccess()
        {
            XDbConnection.Disconnect();
        }

        public int SaveStudentGrade(String studentid, String examcode, double gradepoints)
        {
            int affectedRow;
            try
            {
                SqlParameter[] scol = new SqlParameter[3];
                scol[0] = new SqlParameter("@studentid", studentid);
                scol[1] = new SqlParameter("@examcode", examcode);
                scol[2] = new SqlParameter("@gradepoints", gradepoints);
                affectedRow = XDbConnection.ExecuteWithParam("proc_saveStudentGrade", scol);
                return affectedRow;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public StudentGradeCollection GetList()
        {
            StudentGradeCollection studentGradeList = new StudentGradeCollection();
            StudentGrade studentGrade;

            using (SqlDataReader sdr = XDbConnection.ReadDataProc("proc_getStudentGrade", null))
            {
                while (sdr.Read())
                {
                    studentGrade = new StudentGrade(sdr["studentid"].ToString(), sdr["examcode"].ToString(), (double)sdr["gradepoints"]);
                    studentGradeList.AddStudentGrade(studentGrade);
                }
                studentGrade = null;
                sdr.Close();// not necessary but still to be on the safe side
            }
            return studentGradeList;
        }
    }
}
