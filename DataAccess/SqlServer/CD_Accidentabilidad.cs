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
    public class CD_Accidentabilidad
    {
        
            //mostrar accidentabilidad
            private ConnectionToSql conexion = new ConnectionToSql();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            public DataTable MostrarAccidentabilidad()
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "MostrarAccidentabilidad";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;

            }

        //insertar datos de accidentabilidad de cada empresa
        public void InsertarAccident(string empresa, String Ntrabajadores, string Naccidentes)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAccidentabilidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@empresa", empresa);
            comando.Parameters.AddWithValue("@Ntrabajadores", Ntrabajadores);
            comando.Parameters.AddWithValue("@Naccidentes", Naccidentes);
            comando.ExecuteNonQuery();
        }
    }
}
