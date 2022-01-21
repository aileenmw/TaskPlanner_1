using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskPlanner.Helpers
{
    public class SqlServer
    {
        // Enter Your SQL Server name here:
        private static string YourSqlServer = "";

        private static string serverName = YourSqlServer != "" ? YourSqlServer : System.Environment.MachineName;
        public static string Connection = $"Server={serverName};Database=TaskPlanner;Trusted_Connection=True;MultipleActiveResultSets=True";
        public bool IsServerConnected(string connectionString)
        {
            bool con = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    con = true;
                }
                catch (SqlException)
                {
                    con = false;
                }
                
                finally
                {
                    try
                    {
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                    }
                }
                
            }
            return con;
        }

        public void setConnection(string connectionString)
        {
            bool con = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    con = true;
                }
                catch (SqlException)
                {
                    con = false;
                }
            }
        }
             
    }
}
