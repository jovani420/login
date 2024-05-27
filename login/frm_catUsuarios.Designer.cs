namespace login

{
    partial class frm_catUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_catUsuarios));
            System.DirectoryServices.SortOption sortOption1 = new System.DirectoryServices.SortOption();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtPosicion = new TextBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            txtCorreo = new TextBox();
            txtApellidos = new TextBox();
            label11 = new Label();
            txtNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            cerrarbtn = new Button();
            actualizarbtn = new Button();
            guardarbtn = new Button();
            directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 115);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 25);
            label1.TabIndex = 1;
            label1.Text = "Configuracion de Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 34);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 38);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(txtPosicion);
            panel2.Controls.Add(txtContraseña);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(txtApellidos);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(14, 150);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 285);
            panel2.TabIndex = 1;
            // 
            // txtPosicion
            // 
            txtPosicion.BackColor = Color.White;
            txtPosicion.BorderStyle = BorderStyle.None;
            txtPosicion.ForeColor = SystemColors.MenuText;
            txtPosicion.Location = new Point(92, 179);
            txtPosicion.Margin = new Padding(4, 3, 4, 3);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(371, 16);
            txtPosicion.TabIndex = 14;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.ForeColor = SystemColors.MenuText;
            txtContraseña.Location = new Point(92, 58);
            txtContraseña.Margin = new Padding(4, 3, 4, 3);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(371, 16);
            txtContraseña.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.ForeColor = SystemColors.MenuText;
            txtUsuario.Location = new Point(92, 23);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.MaximumSize = new Size(371, 16);
            txtUsuario.MinimumSize = new Size(371, 16);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(371, 16);
            txtUsuario.TabIndex = 12;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.ForeColor = SystemColors.MenuText;
            txtCorreo.Location = new Point(92, 228);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(371, 16);
            txtCorreo.TabIndex = 11;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.White;
            txtApellidos.BorderStyle = BorderStyle.None;
            txtApellidos.ForeColor = SystemColors.MenuText;
            txtApellidos.Location = new Point(92, 137);
            txtApellidos.Margin = new Padding(4, 3, 4, 3);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(371, 16);
            txtApellidos.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 180);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 9;
            label11.Text = "Posicion";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = SystemColors.MenuText;
            txtNombre.Location = new Point(92, 100);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(371, 16);
            txtNombre.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 58);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 5;
            label7.Text = "Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 24);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 4;
            label6.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 229);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 3;
            label5.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 137);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 2;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Controls.Add(cerrarbtn);
            panel4.Controls.Add(actualizarbtn);
            panel4.Controls.Add(guardarbtn);
            panel4.Location = new Point(14, 442);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(591, 60);
            panel4.TabIndex = 3;
            // 
            // cerrarbtn
            // 
            cerrarbtn.Image = Properties.Resources.iconClosed;
            cerrarbtn.Location = new Point(481, 9);
            cerrarbtn.Margin = new Padding(4, 3, 4, 3);
            cerrarbtn.Name = "cerrarbtn";
            cerrarbtn.Size = new Size(98, 41);
            cerrarbtn.TabIndex = 3;
            cerrarbtn.Text = "Cerrar";
            cerrarbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            cerrarbtn.UseVisualStyleBackColor = true;
            cerrarbtn.Click += cerrarbtn_Click;
            // 
            // actualizarbtn
            // 
            actualizarbtn.Image = Properties.Resources.flavio_refesh;
            actualizarbtn.Location = new Point(375, 9);
            actualizarbtn.Margin = new Padding(4, 3, 4, 3);
            actualizarbtn.Name = "actualizarbtn";
            actualizarbtn.Size = new Size(98, 41);
            actualizarbtn.TabIndex = 2;
            actualizarbtn.Text = " Actualizar";
            actualizarbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            actualizarbtn.UseVisualStyleBackColor = true;
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.flavio_save;
            guardarbtn.Location = new Point(269, 9);
            guardarbtn.Margin = new Padding(4, 3, 4, 3);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(98, 41);
            guardarbtn.TabIndex = 1;
            guardarbtn.Text = " Guardar";
            guardarbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // directorySearcher2
            // 
            directorySearcher2.ClientTimeout = TimeSpan.Parse("-00:00:01");
            directorySearcher2.ServerPageTimeLimit = TimeSpan.Parse("-00:00:01");
            directorySearcher2.ServerTimeLimit = TimeSpan.Parse("-00:00:01");
            directorySearcher2.Sort = sortOption1;
            // 
            // frm_catUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 516);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_catUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalogo de Usuario - POS";
            Load += frm_catUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button guardarbtn;
        private System.Windows.Forms.Button cerrarbtn;
        private System.Windows.Forms.Button actualizarbtn;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtPosicion;
        private TextBox txtContraseña;
        private TextBox txtCorreo;
        public TextBox txtUsuario;
    }
}