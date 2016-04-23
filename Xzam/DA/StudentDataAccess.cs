using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xzam.Models;
using System.Data.SqlClient;

namespace Xzam.DA
{
    class StudentDataAccess
    {
        public StudentDataAccess()
        {
            XDbConnection.Connect();
        }
        ~StudentDataAccess()
        {
            XDbConnection.Disconnect();
        }

        public StudentCollection GetList()
        {
            StudentCollection studentlist = new StudentCollection();
            Student student;

            using (SqlDataReader sdr = XDbConnection.ReadDataProc("proc_getStudents", null))
            {
                while (sdr.Read())
                {
                    student = new Student(sdr["Username"].ToString(), sdr["Fullname"].ToString());
                    studentlist.AddStudent(student);
                }
                student = null;
                sdr.Close();// not necessary but still to be on the safe side
            }
            return studentlist;
        }
    }
}
