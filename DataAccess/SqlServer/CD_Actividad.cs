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
    public class CD_Actividad
    {
        //mostrar actividad
        private ConnectionToSql conexion = new ConnectionToSql();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarActividad";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        //insertar nueva actividad
        public void Insertar(string Empresa, string Fecha, string Checklist1, string Checklist2, string Checklist3, string Checklist4, string Checklist5, string Comentarios)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarActividad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Empresa", Empresa);
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@Checklist1", Checklist1);
            comando.Parameters.AddWithValue("@Checklist2", Checklist2);
            comando.Parameters.AddWithValue("@Checklist3", Checklist3);
            comando.Parameters.AddWithValue("@Checklist4", Checklist4);
            comando.Parameters.AddWithValue("@Checklist5", Checklist5);
            comando.Parameters.AddWithValue("@Comentarios", Comentarios);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }


        //editar actividad
 

        public void editar(string Empresa, string Fecha, string Checklist1, string Checklist2, string Checklist3, string Checklist4, string Checklist5, string Comentarios, int idactivity)

        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarActividad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Empresa", Empresa);
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@Checklist1", Checklist1);
            comando.Parameters.AddWithValue("@Checklist2", Checklist2);
            comando.Parameters.AddWithValue("@Checklist3", Checklist3);
            comando.Parameters.AddWithValue("@Checklist4", Checklist4);
            comando.Parameters.AddWithValue("@Checklist5", Checklist5);
            comando.Parameters.AddWithValue("@Comentarios", Comentarios);
            comando.Parameters.AddWithValue("@idactivity", idactivity);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void EliminarActividad(int idactivity)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarActividad";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idactivity", idactivity);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}

