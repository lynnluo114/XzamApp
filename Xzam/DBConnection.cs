﻿using System;
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
            if(conn!=null)
                conn.Close();
        }

 

        public static int ExecuteSQL(string dmlstatement){
            
            cmd = new SqlCommand(dmlstatement, conn);
 
            return cmd.ExecuteNonQuery();
        }

        public static SqlDataReader ReadData(string selectstatement){
            cmd.CommandText = selectstatement;
            reader = cmd.ExecuteReader();
            return reader;
        }
         
    }
}
