using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TicketChecker
{
    class DBConnection
    {
        private static SqlConnection conn;
        private static string conString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ThemePark;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private DBConnection()
        {

        }

        public static SqlConnection getConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(conString);
                return conn;
            }
            else
            {
                return conn;
            }
        }
    }
}
