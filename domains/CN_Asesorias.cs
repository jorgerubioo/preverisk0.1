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
    public class CN_Asesorias
    {

        private CD_Asesorias objetoCD = new CD_Asesorias();
        public DataTable MostrarAses()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }

        public void InsertarAsese(string empresa, String rut, string descripcion, string fecha, string estadosolicitud)
        {
            objetoCD.Insertar(empresa, rut, descripcion, fecha, estadosolicitud);



        }


    }
}

