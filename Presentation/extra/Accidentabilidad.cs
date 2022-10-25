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

namespace Presentation.extra
{
    public partial class Accidentabilidad : Form
    {
        CN_Accidentabilidad objetoCN = new CN_Accidentabilidad();
        public Accidentabilidad()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
              objetoCN.insertarAccident(txtEmpresa.Text, txtNtrabajadores.Text, txtNaccidentes.Text);

                    MessageBox.Show("datos ingresados correctamente");
                    
                    limpiarForm();
               
                //metodo para limpiar datos de formulario
                
            
        }
        private void limpiarForm()
            {
                txtNaccidentes.Clear();
                txtEmpresa.Clear();
                txtNtrabajadores.Clear();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
    }

 



