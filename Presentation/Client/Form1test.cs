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

namespace Presentation.Client
{
    public partial class Form1test : Form
    {
        CN_Asesorias objetoCN = new CN_Asesorias();
        public Form1test()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarAsesori();
        }

        private void MostrarAsesori ()
        {
            CN_Asesorias objeto = new CN_Asesorias ();
            dataGridView1.DataSource = objeto.MostrarAses();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try { 
            objetoCN.InsertarAses(txtEmpresa.Text, txtRut.Text, txtDescripcion.Text, txtFecha.Text, txtEstadosolicitud.Text);
            MessageBox.Show("se solicito correctamente");
            MostrarAsesori();
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se pudo ingresar la solicitud por: "+ex);
            }
        }

       

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        
    }
}
