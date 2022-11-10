using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using domains;

namespace Presentation.extra
{
    public partial class solicitarasesorias : Form
    {
        CN_Asesorias objetoCN = new CN_Asesorias();
        public solicitarasesorias()
        {
            InitializeComponent();
        }

        
       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {       
           objetoCN.InsertarAsese ( txtEmpresa.Text, txtRut.Text, txtDescripcion.Text, txtFecha.Text, txtEstadosolicitud.Text);
            MessageBox.Show("se solicito correctamente");
                limpiarForm();
            

            }
            catch(Exception ex)
            {
                MessageBox.Show("no se pudo ingresar la solicitud por: "+ex);
            }
        }
        
       

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarForm()
        {
            txtDescripcion.Clear();
            txtEmpresa.Clear();
            txtRut.Clear();
            txtFecha.Clear();
            txtEstadosolicitud.Clear();
            
        }
    }
}

