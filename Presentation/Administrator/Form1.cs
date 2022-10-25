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
        private string idUsuario=null;
        private bool Editar = false;
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
            //INSERTAR
        {
            if (Editar == false ) { 
            try { 
            objetoCN.insertarUsuario(txtUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, cmbRol.Text, txtEmail.Text);

            MessageBox.Show("Usuario ingresado correctamente");
            MostrarUsuarios();
            limpiarForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo ingresar correctamente por: " + ex);
            }
        }
            //EDITAR
            if (Editar == true)
            {
                try{
                    objetoCN.editarUsuario(txtUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, cmbRol.Text, txtEmail.Text, idUsuario);
                    MessageBox.Show("Usuario editado correctamente");
                    MostrarUsuarios();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtUsuario.Text = dataGridView1.CurrentRow.Cells["LoginName"].Value.ToString();
                txtContraseña.Text = dataGridView1.CurrentRow.Cells["password"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["firstName"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["lastName"].Value.ToString();
                cmbRol.SelectedItem = dataGridView1.CurrentRow.Cells["position"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                idUsuario = dataGridView1.CurrentRow.Cells["UserID"].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila por favor.");

        }
        //funcion para limpiar textbox luego de editar o agregar un usuario
        private void limpiarForm()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
           txtEmail.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idUsuario = dataGridView1.CurrentRow.Cells["UserID"].Value.ToString();
                objetoCN.eliminarUsuario(idUsuario);
                MessageBox.Show("Usuario eliminado correctamente");
                MostrarUsuarios();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }

