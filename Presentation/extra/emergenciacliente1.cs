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

namespace Presentation.extra
{
    public partial class emergenciacliente1 : Form
    {
        CN_EmergenciaClient objetoemecn = new CN_EmergenciaClient();
        public emergenciacliente1()
        {
            InitializeComponent();
        }

        private void btnemergencia_Click(object sender, EventArgs e)
        {
            try { 
            objetoemecn.InsertarEme(txtTelefono.Text, txtDesEme.Text);
            MessageBox.Show("Emergencia ingresada correctamente, la respuesta será lo antes posible");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo ingresar la emergencia por: " + ex);
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



