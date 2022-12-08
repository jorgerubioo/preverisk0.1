using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using domains;
using domains.DataAccess.SqlServer;
using Presentation.Professional;

namespace Presentation.Administrator
{


    public partial class Asistencia : Form
    {

        


        CN_AsistenciaAdmin objetoCN = new CN_AsistenciaAdmin();
        private string idUsuario = null;
        
        public Asistencia()
        {
            InitializeComponent();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            MostrarAsistencia();
        }

        private void MostrarAsistencia()
        {
            CN_AsistenciaAdmin objeto = new CN_AsistenciaAdmin();
            dataGridView1.DataSource = objeto.MostrarAsistencia();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           





        }
    }
}
