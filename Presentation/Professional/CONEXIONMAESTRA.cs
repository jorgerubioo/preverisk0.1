﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Presentation.Professional
{
   public class CONEXIONMAESTRA
    {
        public static string conexion = "Server=LAPTOP-VTLJ41I5\\SQLEXPRESS;DataBase= test1; Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if(conectar.State ==ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if(conectar.State== ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
