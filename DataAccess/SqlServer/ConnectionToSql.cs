using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString; 
        public ConnectionToSql ()
        {
            connectionString = "Server=LAPTOP-VTLJ41I5\\SQLEXPRESS;DataBase= PortafolioTest; integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
