using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteParser
{
    public class DBHandler
    {
        public static Database db;

        static DBHandler() 
        {
            db = new Database();
        }

        public static ref Database GetDatabase() 
        {
            return ref db;
        }
    }
}
