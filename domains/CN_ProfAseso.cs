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
    public class CN_ProfAseso
    {
        private CD_ProfAseso objetoCD = new CD_ProfAseso();

        public DataTable MostrarAses()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }

        public void InsertarAses(string empresa, String rut, string descripcion, string fecha, string estadosolicitud)
        {
            objetoCD.Insertar(empresa, rut, descripcion, fecha, estadosolicitud);
        


    }


        public void EditarAses(string empresa, String rut, string descripcion, string fecha, string estadosolicitud, string id)
        {
          
            objetoCD.Editar(empresa, rut, descripcion, fecha, estadosolicitud, Convert.ToInt32(id));
        }
    }
}



