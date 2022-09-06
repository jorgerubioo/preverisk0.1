using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common1.Cache;

namespace Presentation.Administrator
{
    public partial class MenuAdministrator : Form
    {
        public MenuAdministrator()
        {
            InitializeComponent();
            

            //Agregar metodo en el formulario para mostrar datos de usuarios
            LoadUserData();
        }

        

        //metodo mostrar datos de usuario

        private void LoadUserData()
        {
            lblname.Text = UserLoginCache.firstName+ " "+UserLoginCache.lastName;
            lblposition.Text = UserLoginCache.position;
            lblEmail.Text = UserLoginCache.email;
        }



        //arrastrar formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas segur@ de cerrar sesión?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            Presentation.FormLogin mainMenu = new Presentation.FormLogin();
            mainMenu.Show();
           


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas segur@ que desea cerrar la aplicación?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
             
            Application.Exit();
        }

        private void paneladmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2admin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
