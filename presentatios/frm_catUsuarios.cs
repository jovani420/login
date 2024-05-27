using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesRules;
using POS.repositorio;

namespace POS
{


    public partial class frm_catUsuarios : Form
    {
        public frm_catUsuarios()
        {
            InitializeComponent();
        }
        private void frm_catUsuarios_Load(object sender, EventArgs e)
        {
            chli_estatus.Checked = false;
            chli_estatus.Text = "Inactivo";
            actualizarbtn.Enabled = false;

            actualizarbtn.Enabled = false;
            dtp_fecha.Enabled = false;
            dtp_fecha.Value = DateTime.Now;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chli_estatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chli_estatus.Checked)
            {
                chli_estatus.Text = "Activo";

            }
            else
            {
                chli_estatus.Text = "Inactivo";
            }

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    Nombre = nombretxt.Text,
                    Apellido = apellidotxt.Text,
                    Telefono = telefonotxt.Text,
                    Correo = correotxt.Text,
                    Usuario = usuariotxt.Text,
                    Contraseña = contraseñatxt.Text,
            


                };

                ClienteRepositorio.Instance.save(cliente);
                MessageBox.Show("Cliente agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizarbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
