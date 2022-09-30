using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Configuration;

namespace DataAccess.SqlServer
{
    public class CD_emergenciacliente
    {

        //mostrar asesorias
        private ConnectionToSql conexion = new ConnectionToSql();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VerEmergencia";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertarEme (string numero, string desc)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEmergencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("numero", numero);
            comando.Parameters.AddWithValue("desc", desc);
            comando.ExecuteNonQuery();
        }
    }
}
