using login;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //variables
            try
            {
                this.Text = "Sistema de punto de venta";

                //Form1 login = new Form1();
                //login.ShowDialog();

            }
            catch (Exception ex)
            {
                Console.WriteLine("[Form2_Load]" + ex.Message);
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro en cerrar sección?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                frm_catUsuarios principal = new frm_catUsuarios();
                principal.Show();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
