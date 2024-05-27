using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics.Metrics;
using Domian;




namespace login
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Realiza la funcion de cambiar a color blanco a label txtGuideUser si agregan un caracter a txtUser.txt


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            if (txtPassword.Text.Length >= 1)
            {
                msgError("");
                imgPassword.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-padlock-hover.png");

                txtGuidePassword.ForeColor = Color.White;
            }
            else
            {
                imgPassword.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-padlock.png");
                txtGuidePassword.ForeColor = SystemColors.GrayText; ;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Length >= 1)
            {
                msgError("");
                imgUser.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-user-Hover.png");
                txtGuideUser.ForeColor = Color.White;
            }
            else
            {
                imgUser.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-user.png");
                txtGuideUser.ForeColor = SystemColors.GrayText;
            }
        }




        private void btnClosed_MouseEnter(object sender, EventArgs e)
        {
            btnClosed.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-closed-enter.png");
        }

        private void btnClosed_MouseLeave(object sender, EventArgs e)
        {
            btnClosed.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-closed.png");
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-minimize-hover.png");
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-minimize.png");
        }



        private void btnNotSee_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnNotSee.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-Lock.png");
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                btnNotSee.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-See.png");
            }

        }

        private void btnNotSee_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnNotSee.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-Lock.png");
        }


        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClosed_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            msgError("");
            if (txtUser.Text != "")
            {
                if ((txtPassword.Text != ""))
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPassword.Text);
                    if (validLogin == true)
                    {
                        Form2 principal = new Form2();
                        principal.Show();
                        principal.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("      Usuario o contraseña incorrecta");
                        txtUser.Focus();
                        txtPassword.Clear();
                    }
                }
                else
                {
                    msgError("      Ingrese su contraseña");
                }
            }
            else
            {
                msgError("      Ingrese su usuario");
            }


        }

        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }
        private void btnAcceder_Enter(object sender, EventArgs e)
        {
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-enter-hover.png");
        }

        private void btnAcceder_Leave(object sender, EventArgs e)
        {
            btnAcceder.ForeColor = SystemColors.GrayText;
            btnAcceder.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-enter.png");
        }

        private void Logout(Object sender, FormClosedEventArgs e)
        {
            txtPassword.Clear();
            txtUser.Focus();
            lblError.Visible = false;
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
