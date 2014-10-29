using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdminKPIsDataLogger
{
    class Program
    {
        //define global variables
        private static string MYSQLCONN = Properties.Resources.MySQLConnectionString;
        private static string MSSQLCONN = Properties.Resources.MSSQLConnectionString;

        static void Main(string[] args)
        {
            MySqlConnection mySQLConn = new MySqlConnection(MYSQLCONN);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mySQLConn;
            cmd.CommandText = @"SELECT  HISTORYID,  WORKORDERID,  OPERATIONOWNERID,  OPERATIONTIME,   OPERATION 
                                FROM workorderhistory
                                WHERE WORKORDERID = 79703        
                                ORDER BY HISTORYID ASC ";
            mySQLConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            mySQLConn.Close();

        }
    }
}
