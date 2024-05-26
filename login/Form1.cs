using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
          
        }

        //Realiza la funcion de cambiar a color blanco a label txtGuideUser si agregan un caracter a txtUser.txt


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
          
            if (txtPassword.Text.Length >= 1)
            {
               
                txtGuidePassword.ForeColor = Color.White;
            }
            else
            {
                txtGuidePassword.ForeColor = SystemColors.GrayText; ;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Length >= 1)
            {

                txtGuideUser.ForeColor = Color.White;
            }
            else
            {
                txtGuideUser.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtUser_MouseEnter(object sender, EventArgs e)
        {
            // imgUser.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-user-Hover.png");
        }

        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            //  imgUser.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-user.png");
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {

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

        private void btnClosed_Click(object sender, EventArgs e)
        {

        }

        private void lblOpening_Click(object sender, EventArgs e)
        {

        }

        private void btnNotSee_Click(object sender, EventArgs e)
        {
        
            txtPassword.UseSystemPasswordChar = false;
            btnNotSee.Image = Image.FromFile("C:/Users/jovan/Documents/login/login/login/icons/flavio-See.png");
        
        }
    }
}
