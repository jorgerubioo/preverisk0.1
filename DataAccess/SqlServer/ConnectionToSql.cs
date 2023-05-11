using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataAccess
{

    

    public class ConnectionToSql
        {
            private SqlConnection connectionString = new SqlConnection("Server=LAPTOP-VTLJ41I5\\SQLEXPRESS;DataBase=PreveriskFinal; integrated security= true");
            public SqlConnection AbrirConexion()
            {
                if (connectionString.State == ConnectionState.Closed)
                    connectionString.Open();
                return connectionString;
            }
            public SqlConnection CerrarConexion()
            {
                if (connectionString.State == ConnectionState.Open)
                    connectionString.Close();
                return connectionString;
            }
        }



}

