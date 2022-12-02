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
        private string idAsesoria = null;
        private bool Editar=false;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Editar==false) { 
            try
            {
                objetoCN.InsertarAses(txtEmpresa.Text, txtRut.Text, txtDescripcion.Text, txtFecha.Text, txtEstadosolicitud.Text);
                MessageBox.Show("se solicito correctamente");
                MostrarAsesori();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo ingresar la solicitud por: " + ex);
            }
            }
            if(Editar == true)
            {

                try
                {
                    objetoCN.EditarAses(txtEmpresa.Text, txtRut.Text, txtDescripcion.Text, txtFecha.Text, txtEstadosolicitud.Text, idAsesoria);
                    MessageBox.Show("se edito correctamente");
                    MostrarAsesori();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtEmpresa.Text = dataGridView1.CurrentRow.Cells["Empresa"].Value.ToString();
                txtRut.Text = dataGridView1.CurrentRow.Cells["Rut"].Value.ToString();
                txtFecha.Text = dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString();
                txtEstadosolicitud.Text = dataGridView1.CurrentRow.Cells["EstadoSolicitud"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                idAsesoria = dataGridView1.CurrentRow.Cells["UserID"].Value.ToString();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
