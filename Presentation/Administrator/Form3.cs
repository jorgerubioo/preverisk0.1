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


namespace Presentation.Administrator
{
    public partial class Form2 : Form
    {
        CN_EmergenciaClient objetoemecn = new CN_EmergenciaClient();
        public Form2()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            MostrarEme();
        }

        private void MostrarEme()
        {
            CN_EmergenciaClient objeto = new CN_EmergenciaClient();
            dataGridView1.DataSource = objeto.MostrarEme();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
