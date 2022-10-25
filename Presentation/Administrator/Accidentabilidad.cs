using domains;
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
using System.Security.Cryptography.X509Certificates;

namespace Presentation.Administrator
{
    public partial class Accidentabilidad : Form
    {

       
        
       

        CN_Accidentabilidad objetoCN = new CN_Accidentabilidad();
        public Accidentabilidad()
        {
            InitializeComponent();

            
        }

       

        private void Accidentabilidad_Load(object sender, EventArgs e)
        {
            MostrarAccident();


        }

        private void MostrarAccident()
        {
          CN_Accidentabilidad objeto = new CN_Accidentabilidad();
            dataGridView1.DataSource = objeto.MostrarAccident();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            txtResultadodiv.Text = "El indice de accidentabilidad es: "+Int32.Parse(txtNtrabajadores.Text) / Int32.Parse(txtNaccidentes.Text) + "%";

        }
    }
}
