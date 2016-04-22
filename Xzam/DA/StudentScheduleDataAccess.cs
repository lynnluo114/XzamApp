using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /*public StudentScheduleCollection GetList()
        {
            StudentScheduleCollection studentlist = new StudentCollection();
            Student student;

            using (SqlDataReader sdr = XDbConnection.ReadDataProc("proc_getStudents", null))
            {
                while (sdr.Read())
                {
                    student = new Student(sdr["studentid"].ToString(), sdr["studentname"].ToString());
                    studentlist.AddStudent(student);
                }
                student = null;
                sdr.Close();// not necessary but still to be on the safe side
            }
            return studentlist;
        }*/
    }
}
