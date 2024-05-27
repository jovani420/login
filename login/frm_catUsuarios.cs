using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login;


namespace login
{


    public partial class frm_catUsuarios : Form
    {
        public frm_catUsuarios()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void frm_catUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro en guardad?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Text = "";
                txtPosicion.Text = "";
                txtCorreo.Text = "";
            }
        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
