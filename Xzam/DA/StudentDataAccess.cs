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

        public int SaveData(Student student)
        {
            if (student == null)
            {
                throw new Exception("No data found to save");
            }
            int affectedRow;
            try
            {
                SqlParameter[] scol = new SqlParameter[2];
                scol[0] = new SqlParameter("@scheduleid", student.ScheduleID);
                scol[1] = new SqlParameter("@studentid", student.StudentID);               
                affectedRow = XDbConnection.ExecuteWithParam("proc_saveStduentSchedule", scol);
                return affectedRow;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int SaveGrade(Student student,double grade)
        {
            if (student == null)
            {
                throw new Exception("No data found to save");
            }
            int affectedRow;
            try
            {
                SqlParameter[] scol = new SqlParameter[3];
                scol[0] = new SqlParameter("@scheduleid", student.ScheduleID);
                scol[1] = new SqlParameter("@studentid", student.StudentID);
                scol[2] = new SqlParameter("@grade", grade);
                affectedRow = XDbConnection.ExecuteWithParam("proc_saveStudentGrade", scol);
                return affectedRow;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public StudentCollection GetList()
        {
            StudentCollection studentlist = new StudentCollection();
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
        }
    }
}
