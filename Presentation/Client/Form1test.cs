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
            dataGridView1.DataSource = objetoCN.MostrarAses();
        }
    }
}
