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
            imgBanner = new PictureBox();
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
            imgPassword = new PictureBox();
            btnNotSee = new PictureBox();
            lblError = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNotSee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(imgBanner);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 330);
            panel1.TabIndex = 0;
            // 
            // imgBanner
            // 
            imgBanner.Image = Properties.Resources.vid_login;
            imgBanner.Location = new Point(0, 0);
            imgBanner.Name = "imgBanner";
            imgBanner.Size = new Size(236, 330);
            imgBanner.TabIndex = 11;
            imgBanner.TabStop = false;
            imgBanner.MouseDown += pictureBox2_MouseDown;
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
            lblOpening.Location = new Point(425, 20);
            lblOpening.Name = "lblOpening";
            lblOpening.Size = new Size(139, 27);
            lblOpening.TabIndex = 5;
            lblOpening.Text = "Iniciar seción";
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
            btnAcceder.Location = new Point(316, 238);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.RightToLeft = RightToLeft.No;
            btnAcceder.Size = new Size(384, 40);
            btnAcceder.TabIndex = 6;
            btnAcceder.Text = "Acceder";
            btnAcceder.TextAlign = ContentAlignment.MiddleRight;
            btnAcceder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            btnAcceder.Enter += btnAcceder_Enter;
            btnAcceder.Leave += btnAcceder_Leave;
            // 
            // linkPassword
            // 
            linkPassword.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkPassword.AutoSize = true;
            linkPassword.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkPassword.LinkColor = Color.DimGray;
            linkPassword.Location = new Point(425, 295);
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
            btnClosed.Click += btnClosed_Click_1;
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
            btnMinimize.Click += btnMinimize_Click_1;
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
            // imgPassword
            // 
            imgPassword.Image = (Image)resources.GetObject("imgPassword.Image");
            imgPassword.Location = new Point(278, 143);
            imgPassword.Name = "imgPassword";
            imgPassword.Size = new Size(32, 32);
            imgPassword.TabIndex = 11;
            imgPassword.TabStop = false;
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
            btnNotSee.MouseEnter += btnNotSee_MouseEnter;
            btnNotSee.MouseLeave += btnNotSee_MouseLeave;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Microsoft JhengHei Light", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.IndianRed;
            lblError.Image = (Image)resources.GetObject("lblError.Image");
            lblError.ImageAlign = ContentAlignment.MiddleLeft;
            lblError.Location = new Point(316, 187);
            lblError.Name = "lblError";
            lblError.Size = new Size(124, 19);
            lblError.TabIndex = 13;
            lblError.Text = "     Error Message";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            lblError.Click += lblError_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(lblError);
            Controls.Add(btnNotSee);
            Controls.Add(imgPassword);
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
            Text = "pnlLogin";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPassword).EndInit();
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
        private PictureBox imgBanner;
        private PictureBox imgPassword;
        private PictureBox pictureBox1;
        private PictureBox imgNotSee;
        private PictureBox btnNotSee;
        private Label lblError;
    }
}
