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
            try
            {
                txtResultadodiv.Text = "El indice de accidentabilidad es: " + Int32.Parse(txtNtrabajadores.Text) / Int32.Parse(txtNaccidentes.Text) + "%";
                limpiarForm();
            }

            catch (FormatException)
            {
                MessageBox.Show("No es un número válido");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir entre cero");
            }
            

        }

        
        //Metodo para limpiar campos
        private void limpiarForm()
        {
            txtNaccidentes.Clear();
            txtNtrabajadores.Clear();
            
        }
    }
}
