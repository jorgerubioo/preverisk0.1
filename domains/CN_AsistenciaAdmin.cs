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
    public class CN_AsistenciaAdmin
    {

        private CD_AsistenciaAdmin objetoCD = new CD_AsistenciaAdmin();
        public DataTable MostrarAsistencia()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }
    }
}
