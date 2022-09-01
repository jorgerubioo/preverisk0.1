using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using Common1.Cache;

namespace Presentation
{//test
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        //funcionalidad arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
       



        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text=="")
            {
                txtuser.Text = "USUARIO";
            }
           
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("¿Estas segur@ que desea cerrar la apliación?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)


            Application.Exit();



        }

    private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "USUARIO")
            {
                if (txtuser.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text,txtpass.Text);
                    if (validLogin == true)
                    {
                        if (UserLoginCache.position==Positions.Administrator)
                        {

                        
                        Administrator.MenuAdministrator mainMenu = new Administrator.MenuAdministrator();
                        MessageBox.Show("Bienvenid@ "+UserLoginCache.firstName+ " "+ UserLoginCache.lastName);
                        mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                        if (UserLoginCache.position == Positions.Professional)
                        {


                            Professional.MenuProfessional mainMenu = new Professional.MenuProfessional();
                            MessageBox.Show("Bienvenid@ " + UserLoginCache.firstName + " " + UserLoginCache.lastName);
                            mainMenu.Show();
                            this.Hide();
                        }

                        if (UserLoginCache.position == Positions.client)
                        {


                            Client.MenuClient mainMenu = new Client.MenuClient();
                            MessageBox.Show("Bienvenid@ " + UserLoginCache.firstName + " " + UserLoginCache.lastName);
                            mainMenu.Show();
                            this.Hide();
                             }     
                    else
                    {
                        msgError("Usuario o contraseña incorrectos.");
                        txtpass.Clear();
                        txtuser.Focus();
                    }
                }
                else msgError("Por favor ingresar contraseña");
            }
            else msgError("Por favor ingresar usuario");
        }
        }

        //metodo error login
        private void msgError(string msg) 
            {
                lblErrorMessage.Text = "    "+ msg;
                lblErrorMessage.Visible = true;
            }

        //metodo cerrar sesion

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Clear();
            txtuser.Clear();
            lblErrorMessage.Visible = false;
            this.Show();
            txtuser.Focus();
        }

    }


    }













