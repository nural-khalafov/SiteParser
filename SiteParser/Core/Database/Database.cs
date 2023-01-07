using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteParser
{
    public class Database
    {
        public static bool isConnected;

        private static string DBSource = @"(localdb)\MSSQLLocalDB";
        private static string Catalog = "siteparser";

        private static string connectionString = String.Format
            ("Data Source={0};Initial Catalog={1};Persist Security Info=True;Integrated Security=true;",
            DBSource, Catalog);
            //("Server = {0}, Authentication = Windows Authentication, Integrated Security = true, Database = siteparser",
            //DBSource);

        private SqlConnection conn = new SqlConnection(connectionString);

        public Database() 
        {
            try 
            {
                Console.WriteLine("Opening connection...");

                conn.Open();

                Console.WriteLine("Connection successful!");

                isConnected = true;
            }
            catch(Exception e) 
            {
                isConnected = false;
                Console.WriteLine("Error: " + e.Message);
            }
        }

        ~Database() 
        {
            Console.WriteLine("Closing connection...");
            conn.Close();
        }


        #region MSSQL INSERT Methods

        public void InsertTestRequest() 
        {
            // do smth
        }

        #endregion
    }
}
