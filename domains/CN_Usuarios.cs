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
    public class CN_Usuarios
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }

        public void insertarUsuario (string loginname, string password, string firstname, string lastname, string position, string email) {
            objetoCD.Insertar(loginname, password, firstname, lastname, position, email);  
            
    }

        public void editarUsuario(string loginname, string password, string firstname, string lastname, string position, string email, string id)
        {
            objetoCD.Editar(loginname, password, firstname, lastname, position, email, Convert.ToInt32(id));
        }

        public void eliminarUsuario(string id)
            
        {
            objetoCD.EliminarUsuario(Convert.ToInt32(id));
        }

        public DataTable MostrarProfessional()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProfessional();
            return tabla;

        }
    }
}
