using POS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Principal2 : Form
    {
        public Principal2()
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
            Close();
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
    }
}
