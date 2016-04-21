using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xzam.Models;
using System.Data.SqlClient;

namespace Xzam.DA
{
    class ExamScheduleDataAccess
    {
        public ExamScheduleDataAccess()
        {
            XDbConnection.Connect();
        }
        ~ExamScheduleDataAccess()
        {
            XDbConnection.Disconnect();
        }

        public int SaveData(ExamSchedule schedule)
        {
            if (schedule == null)
            {
                throw new Exception("No data found to save");
            }
            int id;
            try
            {
                SqlParameter[] scol = new SqlParameter[6];
                scol[0] = new SqlParameter("@examcode", schedule.ExamCode);
                scol[1] = new SqlParameter("@qbankid", schedule.QuestionBankID);
                scol[2] = new SqlParameter("@scheduledate", schedule.ScheduleDate);
                scol[3] = new SqlParameter("@starttime", schedule.StartTime);
                scol[4] = new SqlParameter("@endtime", schedule.EndTime);
                scol[5] = new SqlParameter();
                scol[5].ParameterName = "@scheduleid";
                scol[5].SqlDbType = System.Data.SqlDbType.Int;
                scol[5].Direction = System.Data.ParameterDirection.Output;
                id = XDbConnection.ExecuteWithParam("proc_saveExamSchedule", scol, "@scheduleid");
                schedule.ScheduleID = id;
                return id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ExamSchedule> GetStudentScheduleList(int userID)
        {
            List<ExamSchedule> studentScheduleList = new List<ExamSchedule>();
            ExamSchedule es;

            using (SqlDataReader sdr = XDbConnection.ReadDataProc("proc_getStudentSchedule", new SqlParameter[1] { new SqlParameter("@userid", userID) }))
            {
                while (sdr.Read())
                {
                    es = new ExamSchedule((int)sdr["scheduleid"], (int)sdr["qbankid"], sdr["examcode"].ToString(),sdr["examtitle"].ToString(), sdr["scheduledate"].ToString(),sdr["starttime"].ToString(),sdr["endtime"].ToString());
                    studentScheduleList.Add(es);
                }
                es = null;
                sdr.Close();// not necessary but still to be on the safe side
            }
            return studentScheduleList;
        }
    }
}
