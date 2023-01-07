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
        private static string DBSource = @"(localdb)\MSSQLLocalDB";
        private static string Catalog = "siteparser";

        private static string connectionString = String.Format
            ("Data Source={0};Initial Catalog={1};Persist Security Info=True;Integrated Security=true;",
            DBSource, Catalog);

        private SqlConnection conn = new SqlConnection(connectionString);

        public Database() 
        {
            Console.WriteLine("Opening connection");
            conn.Open();
        }

        ~Database() 
        {
            Console.WriteLine("Closing connection");
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
