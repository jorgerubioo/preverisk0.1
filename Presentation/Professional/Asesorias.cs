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

namespace Presentation.Professional
{
    public partial class Asesorias : Form
    {
        CN_ProfAseso objetoCN = new CN_ProfAseso();
        public Asesorias()
        {
            InitializeComponent();
        }

        private void Asesorias_Load(object sender, EventArgs e)
        {
            MostrarAsesori();
        }

        private void MostrarAsesori()
        {
            CN_ProfAseso objeto = new CN_ProfAseso();
            dataGridView1.DataSource = objeto.MostrarAses();
        }
    }
}
