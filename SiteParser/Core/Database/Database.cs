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

        private static string DBSource = "(localdb)\\MSSQLLocalDB";
        private static string DBName = "siteparser";
        private static string User = "master";
        private static string Password = "qwerty1";

        private static string connectionString = String.Format
            ("Server={0}; Database={1}; User ID={2}; Password={3};" +
            "Persist Security Info=True; Integrated Security=false",
            DBSource, DBName, User, Password);
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
            using (var command = new SqlCommand("INSERT INTO ModelName (name)" +
                                                "VALUES (@name1)", conn)) 
            {
                command.Parameters.AddWithValue("name1", "CAMRY");

                int nRows = command.ExecuteNonQuery();
            }
        }

        #endregion
    }
}
