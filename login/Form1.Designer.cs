namespace login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            txtGuideUser = new Label();
            txtGuidePassword = new Label();
            lblOpening = new Label();
            btnAcceder = new Button();
            linkPassword = new LinkLabel();
            btnClosed = new PictureBox();
            btnMinimize = new PictureBox();
            imgUser = new PictureBox();
            pictureBox3 = new PictureBox();
            btnNotSee = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNotSee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.vid_login;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(236, 330);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(316, 78);
            txtUser.MaximumSize = new Size(384, 25);
            txtUser.MinimumSize = new Size(384, 25);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(384, 25);
            txtUser.TabIndex = 1;
            txtUser.TextChanged += txtUser_TextChanged;
            txtUser.MouseEnter += txtUser_MouseEnter;
            txtUser.MouseLeave += txtUser_MouseLeave;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(316, 150);
            txtPassword.MaximumSize = new Size(384, 25);
            txtPassword.MinimumSize = new Size(384, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(384, 25);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.MouseEnter += txtPassword_MouseEnter;
            txtPassword.MouseLeave += txtPassword_MouseLeave;
            // 
            // txtGuideUser
            // 
            txtGuideUser.AutoSize = true;
            txtGuideUser.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGuideUser.ForeColor = SystemColors.GrayText;
            txtGuideUser.Location = new Point(316, 56);
            txtGuideUser.Name = "txtGuideUser";
            txtGuideUser.Size = new Size(72, 19);
            txtGuideUser.TabIndex = 3;
            txtGuideUser.Text = "Usuario: ";
            // 
            // txtGuidePassword
            // 
            txtGuidePassword.AutoSize = true;
            txtGuidePassword.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuidePassword.ForeColor = SystemColors.GrayText;
            txtGuidePassword.Location = new Point(316, 128);
            txtGuidePassword.Name = "txtGuidePassword";
            txtGuidePassword.Size = new Size(95, 19);
            txtGuidePassword.TabIndex = 4;
            txtGuidePassword.Text = "Contraseña: ";
            // 
            // lblOpening
            // 
            lblOpening.AutoSize = true;
            lblOpening.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOpening.ForeColor = SystemColors.HighlightText;
            lblOpening.Location = new Point(441, 22);
            lblOpening.Name = "lblOpening";
            lblOpening.Size = new Size(139, 27);
            lblOpening.TabIndex = 5;
            lblOpening.Text = "Iniciar seción";
            lblOpening.Click += lblOpening_Click;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(40, 40, 40);
            btnAcceder.Cursor = Cursors.Hand;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.LightGray;
            btnAcceder.Image = (Image)resources.GetObject("btnAcceder.Image");
            btnAcceder.Location = new Point(316, 261);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.RightToLeft = RightToLeft.No;
            btnAcceder.Size = new Size(384, 40);
            btnAcceder.TabIndex = 6;
            btnAcceder.Text = "Acceder";
            btnAcceder.TextAlign = ContentAlignment.MiddleRight;
            btnAcceder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // linkPassword
            // 
            linkPassword.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkPassword.AutoSize = true;
            linkPassword.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkPassword.LinkColor = Color.DimGray;
            linkPassword.Location = new Point(316, 194);
            linkPassword.Name = "linkPassword";
            linkPassword.Size = new Size(168, 17);
            linkPassword.TabIndex = 7;
            linkPassword.TabStop = true;
            linkPassword.Text = "¿Haz olvidado contraseña?";
            // 
            // btnClosed
            // 
            btnClosed.Cursor = Cursors.Hand;
            btnClosed.Image = (Image)resources.GetObject("btnClosed.Image");
            btnClosed.Location = new Point(740, 0);
            btnClosed.Name = "btnClosed";
            btnClosed.Size = new Size(40, 24);
            btnClosed.TabIndex = 8;
            btnClosed.TabStop = false;
            btnClosed.Click += btnClosed_Click;
            btnClosed.MouseEnter += btnClosed_MouseEnter;
            btnClosed.MouseLeave += btnClosed_MouseLeave;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(698, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 24);
            btnMinimize.TabIndex = 9;
            btnMinimize.TabStop = false;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // imgUser
            // 
            imgUser.Image = (Image)resources.GetObject("imgUser.Image");
            imgUser.Location = new Point(278, 71);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(32, 32);
            imgUser.TabIndex = 10;
            imgUser.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.flavio_padlock;
            pictureBox3.Location = new Point(278, 143);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // btnNotSee
            // 
            btnNotSee.BackColor = Color.White;
            btnNotSee.Image = (Image)resources.GetObject("btnNotSee.Image");
            btnNotSee.Location = new Point(676, 152);
            btnNotSee.Name = "btnNotSee";
            btnNotSee.Size = new Size(20, 20);
            btnNotSee.SizeMode = PictureBoxSizeMode.CenterImage;
            btnNotSee.TabIndex = 12;
            btnNotSee.TabStop = false;
            btnNotSee.Click += btnNotSee_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btnNotSee);
            Controls.Add(pictureBox3);
            Controls.Add(imgUser);
            Controls.Add(btnMinimize);
            Controls.Add(btnClosed);
            Controls.Add(linkPassword);
            Controls.Add(btnAcceder);
            Controls.Add(lblOpening);
            Controls.Add(txtGuidePassword);
            Controls.Add(txtGuideUser);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNotSee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label txtGuideUser;
        private Label txtGuidePassword;
        private Label lblOpening;
        private Button btnAcceder;
        private LinkLabel linkPassword;
        private PictureBox btnClosed;
        private PictureBox btnMinimize;
        private PictureBox imgUser;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox imgNotSee;
        private PictureBox btnNotSee;
    }
}
