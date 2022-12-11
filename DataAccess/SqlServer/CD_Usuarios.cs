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
    

        public class CD_Usuarios
        {
        //mostrar registros
            private ConnectionToSql conexion = new ConnectionToSql();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            public DataTable Mostrar()
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "MostrarUsuarios";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;

            }

        //insertar registro con procedimiento almacenado
        public void Insertar(string loginname, string password, string firstname, string lastname, string position, string email)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@loginname", loginname);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@firstname", firstname);
            comando.Parameters.AddWithValue("@lastname", lastname);
            comando.Parameters.AddWithValue("@position", position);
            comando.Parameters.AddWithValue("@email", email);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }


        //editar registros con procedimiento almacenado
        public void Editar(string loginname, string password, string firstname, string lastname, string position, string email, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@loginname", loginname);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@firstname", firstname);
            comando.Parameters.AddWithValue("@lastname", lastname);
            comando.Parameters.AddWithValue("@position", position);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
       

        public void EliminarUsuario(int id) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            }

        public DataTable MostrarProfessional()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProfessional";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }

}

