namespace CapaPresentacion
{
    partial class FLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panelLineaUsuario = new System.Windows.Forms.Panel();
            this.picIconUsuario = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panelLineaPass = new System.Windows.Forms.Panel();
            this.picIconPass = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPass)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Controls.Add(this.panelRight);
            this.panelContainer.Controls.Add(this.panelLeft);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(820, 460);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContainer_MouseDown);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panelRight.Controls.Add(this.btnCerrar);
            this.panelRight.Controls.Add(this.btnMinimizar);
            this.panelRight.Controls.Add(this.lblTitulo);
            this.panelRight.Controls.Add(this.lblSubtitulo);
            this.panelRight.Controls.Add(this.panelLineaUsuario);
            this.panelRight.Controls.Add(this.picIconUsuario);
            this.panelRight.Controls.Add(this.txtUsuario);
            this.panelRight.Controls.Add(this.panelLineaPass);
            this.panelRight.Controls.Add(this.picIconPass);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.lblError);
            this.panelRight.Controls.Add(this.btnIngresar);
            this.panelRight.Controls.Add(this.lblVersion);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(280, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(540, 460);
            this.panelRight.TabIndex = 1;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            this.panelRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRight_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Marlett", 9F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(510, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 22);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "r";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Marlett", 9F);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(480, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(26, 22);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.Text = "0";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(77, 69);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 59);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(155)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(83, 128);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(267, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Ingrese sus credenciales para continuar";
            // 
            // panelLineaUsuario
            // 
            this.panelLineaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panelLineaUsuario.Location = new System.Drawing.Point(82, 208);
            this.panelLineaUsuario.Name = "panelLineaUsuario";
            this.panelLineaUsuario.Size = new System.Drawing.Size(378, 2);
            this.panelLineaUsuario.TabIndex = 12;
            // 
            // picIconUsuario
            // 
            this.picIconUsuario.BackColor = System.Drawing.Color.Transparent;
            this.picIconUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIconUsuario.BackgroundImage")));
            this.picIconUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconUsuario.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picIconUsuario.ErrorImage")));
            this.picIconUsuario.Location = new System.Drawing.Point(82, 171);
            this.picIconUsuario.Name = "picIconUsuario";
            this.picIconUsuario.Size = new System.Drawing.Size(22, 40);
            this.picIconUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconUsuario.TabIndex = 11;
            this.picIconUsuario.TabStop = false;
            this.picIconUsuario.Click += new System.EventHandler(this.picIconUsuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtUsuario.Location = new System.Drawing.Point(110, 183);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(350, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // panelLineaPass
            // 
            this.panelLineaPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panelLineaPass.Location = new System.Drawing.Point(82, 288);
            this.panelLineaPass.Name = "panelLineaPass";
            this.panelLineaPass.Size = new System.Drawing.Size(378, 2);
            this.panelLineaPass.TabIndex = 14;
            // 
            // picIconPass
            // 
            this.picIconPass.BackColor = System.Drawing.Color.Transparent;
            this.picIconPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIconPass.BackgroundImage")));
            this.picIconPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconPass.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picIconPass.ErrorImage")));
            this.picIconPass.InitialImage = ((System.Drawing.Image)(resources.GetObject("picIconPass.InitialImage")));
            this.picIconPass.Location = new System.Drawing.Point(82, 263);
            this.picIconPass.Name = "picIconPass";
            this.picIconPass.Size = new System.Drawing.Size(20, 20);
            this.picIconPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconPass.TabIndex = 13;
            this.picIconPass.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPassword.Location = new System.Drawing.Point(110, 263);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(350, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.lblError.Location = new System.Drawing.Point(82, 300);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(378, 20);
            this.lblError.TabIndex = 7;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(82, 335);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(378, 46);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this.lblVersion.Location = new System.Drawing.Point(200, 420);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(131, 15);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "SGVE  •  Engage © 2026";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panelLeft.Controls.Add(this.picLogo);
            this.panelLeft.Controls.Add(this.lblSlogan);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 460);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(45, 101);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(194, 189);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // lblSlogan
            // 
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(20, 300);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(240, 40);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "Sistema de Gestión de Ventas";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSlogan.Click += new System.EventHandler(this.lblSlogan_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(820, 460);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLogin";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGEMP - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FLogin_FormClosed);
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContainer_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPass)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.PictureBox picIconUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panelLineaUsuario;
        private System.Windows.Forms.PictureBox picIconPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panelLineaPass;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblVersion;
    }
}