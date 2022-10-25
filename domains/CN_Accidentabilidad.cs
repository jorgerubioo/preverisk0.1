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
    public class CN_Accidentabilidad
    {
        private CD_Accidentabilidad objetoCD = new CD_Accidentabilidad();

        public DataTable MostrarAccident()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarAccidentabilidad();
            return tabla;

        }

        public void insertarAccident(string empresa, String Ntrabajador, string Naccidentes)
        {
            objetoCD.InsertarAccident(empresa, Ntrabajador, Naccidentes);



        }
    }
}
