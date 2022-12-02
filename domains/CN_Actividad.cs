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
    public class CN_Actividad
    {

        private CD_Actividad objetoCD = new CD_Actividad();
        public DataTable MostrarActividad()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }

        public void InsertarActividad(string Empresa, string Fecha, string Checklist1, string Checklist2, string Checklist3, string Checklist4, string Checklist5, string Comentarios)
        {
            objetoCD.Insertar(Empresa, Fecha, Checklist1, Checklist2, Checklist3, Checklist4, Checklist5, Comentarios);

        }

        public void editarActividad(string Empresa, string Fecha, string Checklist1, string Checklist2, string Checklist3, string Checklist4, string Checklist5, string Comentarios, string idactivity)
        {
            objetoCD.editar(Empresa, Fecha, Checklist1, Checklist2, Checklist3, Checklist4, Checklist5, Comentarios, Convert.ToInt32(idactivity));
        }

        public void eliminaractividad(string idactivity)

        {
            objetoCD.EliminarActividad(Convert.ToInt32(idactivity));
        }
    }


}
