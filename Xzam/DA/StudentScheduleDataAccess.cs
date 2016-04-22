using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xzam.Models;
using System.Data.SqlClient;

namespace Xzam.DA
{
    class StudentScheduleDataAccess
    {
        public StudentScheduleDataAccess()
        {
            XDbConnection.Connect();
        }
        ~StudentScheduleDataAccess()
        {
            XDbConnection.Disconnect();
        }

        public int SaveStudentSchedule(String studentid,int scheduleid,double grade)
        {
            int affectedRow;
            try
            {
                SqlParameter[] scol = new SqlParameter[3];
                scol[0] = new SqlParameter("@studentid", studentid);
                scol[1] = new SqlParameter("@scheduleid", scheduleid);
                scol[2] = new SqlParameter("@grade", grade);
                affectedRow = XDbConnection.ExecuteWithParam("proc_saveStudentSchedule", scol);
                return affectedRow;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public StudentScheduleCollection GetList()
        {
            StudentScheduleCollection studentScheduleList = new StudentScheduleCollection();
            StudentSchedule studentSchedule;

            using (SqlDataReader sdr = XDbConnection.ReadDataProc("proc_getStudentSchedule", null))
            {
                while (sdr.Read())
                {
                    studentSchedule = new StudentSchedule(sdr["studentid"].ToString(), (int)sdr["scheduleid"], (double)sdr["grade"]);
                    studentScheduleList.AddStudentSchedule(studentSchedule);
                }
                studentSchedule = null;
                sdr.Close();// not necessary but still to be on the safe side
            }
            return studentScheduleList;
        }
    }
}
