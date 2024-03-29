﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Configuration;

namespace DataAccess.SqlServer
{
   
         public class CD_AsistenciaAdmin
        {
            //mostrar registros
            private ConnectionToSql conexion = new ConnectionToSql();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            public DataTable Mostrar()
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "MostrarAsistencia";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;

            }

         public DataTable Buscar(string userID)
        {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "BuscarAsistencia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@userID", userID);
                 leer = comando.ExecuteReader();
               tabla.Load(leer);
                      conexion.CerrarConexion();
            return tabla;
              

        }
    }
    
    }

