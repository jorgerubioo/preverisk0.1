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
    public class CD_Asesorias
    {

         
        //mostrar asesorias
            private ConnectionToSql conexion = new ConnectionToSql();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAsesoria";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

       public void Insertar(string empresa, String rut, string descripcion, string fecha, string estadosolicitud ) {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAsesoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@empresa", empresa);
            comando.Parameters.AddWithValue("@rut", rut);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@estadosolicitud", estadosolicitud);
            comando.ExecuteNonQuery();
        }
}

}


