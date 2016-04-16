using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient; 
namespace Xzam
{
    class XDbConnection
    {
        /*
         * 
         * Created by Luja Manandhar
         * Purpose: Dynamic class which uses base class for all the connection providers
         * 
         * */
          
        private static SqlConnection conn;
        private static SqlCommand cmd; 
        private static SqlDataReader reader; 

        private static string constr = ConfigurationSettings.AppSettings["constr"].ToString() ;
        
        public static void Connect(){ 
            if(conn==null)
                conn = new SqlConnection(constr);
            if(conn.State==System.Data.ConnectionState.Closed)
                    conn.Open();
        }
        public static void Disconnect(){
            if (conn != null) { 
                if (conn.State == System.Data.ConnectionState.Open) {
                    conn =null;
                }
            }
        }

 

        public static int ExecuteSQL(string dmlstatement){
            
            cmd = new SqlCommand(dmlstatement, conn);
             
            return cmd.ExecuteNonQuery();
        }
        public static int ExecuteWithParam(string dmlstatement, SqlParameter[] parameters)
        {

            cmd = new SqlCommand(dmlstatement, conn);
            cmd.Parameters.AddRange(parameters);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            
            return cmd.ExecuteNonQuery(); ;
        }
        public static int ExecuteWithParam(string dmlstatement, SqlParameter[] parameters, string outParamName) {

            cmd = new SqlCommand(dmlstatement, conn);
            cmd.Parameters.AddRange(parameters);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int result = 0;
            int rowsaffected = cmd.ExecuteNonQuery();
            if (rowsaffected > 0)
            {
                result = int.Parse(cmd.Parameters[outParamName].Value.ToString());
            }
            return result;
        }
        public static SqlDataReader ReadData(string selectstatement){
            cmd = new SqlCommand(selectstatement,conn); 
            return  cmd.ExecuteReader(); 
        }
        public static SqlDataReader ReadDataProc(string selectstatement,SqlParameter[] param)
        {
            cmd.CommandText = selectstatement;
            if (param != null) 
                cmd.Parameters.AddRange( param);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           return cmd.ExecuteReader();
             
        }
    }
}
