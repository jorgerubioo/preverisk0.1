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
    public partial class Actividades : Form
    {
        CN_Actividad objetoCN = new CN_Actividad();
        private string idActividad = null;
        private bool Editar = false;

        public Actividades()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarActividad();
        }

        private void MostrarActividad()
        {
            CN_Actividad objeto = new CN_Actividad();
            dataGridView1.DataSource = objeto.MostrarActividad();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            {
                if (Editar == false)
                {
                    try
                    {
                        objetoCN.InsertarActividad(txtEmpresa.Text, txtFecha.Text, cmb1.Text, cmb2.Text, cmb3.Text, cmb4.Text, cmb5.Text, txtComentarios.Text);
                       

                        MessageBox.Show("Actividad ingresada correctamente");
                        MostrarActividad();
                        limpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo ingresar correctamente por: " + ex);
                    }
                }
                //EDITAR
                if (Editar == true)
                {
                    try
                    {
                        objetoCN.editarActividad(txtEmpresa.Text, txtFecha.Text, cmb1.Text, cmb2.Text, cmb3.Text, cmb4.Text, cmb5.Text, txtComentarios.Text, idActividad);
                        MessageBox.Show("Actividad editada correctamente");
                        MostrarActividad();
                        
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar los datos por: " + ex);
                    }
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtEmpresa.Text = dataGridView1.CurrentRow.Cells["Empresa"].Value.ToString();
                txtFecha.Text = dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString();
                cmb1.SelectedItem = dataGridView1.CurrentRow.Cells["Checklist1"].Value.ToString();
                cmb2.SelectedItem = dataGridView1.CurrentRow.Cells["Checklist2"].Value.ToString();
                cmb3.SelectedItem = dataGridView1.CurrentRow.Cells["Checklist3"].Value.ToString();
                cmb4.SelectedItem = dataGridView1.CurrentRow.Cells["Checklist4"].Value.ToString();
                cmb5.SelectedItem = dataGridView1.CurrentRow.Cells["Checklist5"].Value.ToString();
                txtComentarios.Text= dataGridView1.CurrentRow.Cells["Comentarios"].Value.ToString();
                idActividad = dataGridView1.CurrentRow.Cells["ActivityID"].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila por favor.");

        }

        //funcion para limpiar textbox luego de editar o agregar un usuario
        private void limpiarForm()
        {
            txtEmpresa.Clear();
            txtFecha.Clear();
            cmb1.Items.Clear();
            cmb2.Items.Clear();
            cmb3.Items.Clear();
            cmb4.Items.Clear();
            cmb5.Items.Clear();
            txtComentarios.Clear();
            
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idActividad = dataGridView1.CurrentRow.Cells["ActivityID"].Value.ToString();
                objetoCN.eliminaractividad(idActividad);
                MessageBox.Show("actividad eliminada correctamente");
                MostrarActividad();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");

        }
    }
    }

