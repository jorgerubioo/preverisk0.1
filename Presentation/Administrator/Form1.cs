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
    public partial class Form1 : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try { 
            objetoCN.insertarUsuario(txtUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtPosicion.Text, txtEmail.Text);

            MessageBox.Show("Usuario ingresado correctamente");
            MostrarUsuarios();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo ingresar correctamente por: " + ex);
            }
        }

       
    }
    }

