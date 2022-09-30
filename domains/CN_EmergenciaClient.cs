using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using DataAccess.SqlServer;

namespace domains
{
    public class CN_EmergenciaClient
    {
        private CD_emergenciacliente objetoemecd = new CD_emergenciacliente();

        public DataTable MostrarEme()
        {
            DataTable tabla = new DataTable();
            tabla = objetoemecd.Mostrar();
            return tabla;

        }

        public void InsertarEme(string numero, String desc)
        {
            objetoemecd.InsertarEme(numero, desc);



        }
    }
}
