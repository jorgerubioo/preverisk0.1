﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using domains;
using domains.DataAccess.SqlServer;

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
            objetoCN.insertarUsuario(txtUsuario.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, Encrypt.GetSHA256(txtContraseña.Text), cmbRol.Text, txtactivo.Text, txtFechaRegistro.Text);

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
                    objetoCN.editarUsuario(txtUsuario.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, Encrypt.GetSHA256(txtContraseña.Text), cmbRol.Text, txtactivo.Text, txtFechaRegistro.Text, idUsuario);
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
                txtNombre.Text = dataGridView1.CurrentRow.Cells["firstName"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["lastName"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                txtContraseña.Text = dataGridView1.CurrentRow.Cells["password"].Value.ToString();
                txtContraseña.Visible = false;
                label2.Visible = false;
                cmbRol.SelectedItem = dataGridView1.CurrentRow.Cells["position"].Value.ToString(); 
               
                txtactivo.Text = dataGridView1.CurrentRow.Cells["Activo"].Value.ToString();
                txtactivo.Visible = false;
                txtFechaRegistro.Text = dataGridView1.CurrentRow.Cells["FechaRegistro"].Value.ToString();
                txtFechaRegistro.Visible = false;



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
            txtactivo.Clear();
            txtFechaRegistro.Clear();
            
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

        
    }
    }

