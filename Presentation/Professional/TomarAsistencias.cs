using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Domain;
using domains;
using Common1.Cache;

namespace Presentation.Professional
{ 
    public partial class TomarAsistencias : Form
    {

        DateTime fechaReg;
        public TomarAsistencias()
        {
            InitializeComponent();
            lbluser1.Text = UserLoginCache.firstName + ' ' + UserLoginCache.lastName;
        }

        

        private void TomarAsistencias_Load(object sender, EventArgs e)
        {

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToShortDateString ();
        }

      

            
        
        private void ConfirmarSalida()
        {
            
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
           
            parametros.UserID = UserLoginCache.UserID;
            parametros.Fecha_salida = DateTime.Now;
            lbluser1.Text = UserLoginCache.firstName + UserLoginCache.lastName;

            parametros.Horas = Bases.DateDiff(Bases.DateInterval.Hour, fechaReg, DateTime.Now);

          
         
            if (funcion.ConfirmarSalida(parametros)==true)
            {
                txtaviso.Text = "SALIDA REGISTRADA";
              
            }

        }
        private void InsertarAsistencias()
        {
            if(string.IsNullOrEmpty(txtObservacion.Text))
            {
                txtObservacion.Text = "-";
            }
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            lbluser1.Text = UserLoginCache.firstName + UserLoginCache.firstName;
            parametros.UserID = UserLoginCache.UserID;
            parametros.Fecha_entrada = DateTime.Now;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Estado = "ENTRADA";
            parametros.Horas = 0;
            parametros.Observacion = txtObservacion.Text;
               lbluser1.Text = UserLoginCache.firstName + ' ' + UserLoginCache.lastName;
          if(funcion.InsertarAsistencias(parametros)==true)
            {
                txtaviso.Text = "ENTRADA REGISTRADA";
               
                
            }

        }
       
       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            InsertarAsistencias();
        }

        

       

      
     

        private void btnVolver_Click(object sender, EventArgs e)
        {
            InsertarAsistencias();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {

            ConfirmarSalida();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
  



