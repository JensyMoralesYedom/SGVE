namespace CapaPresentacion
{
    partial class FMantUsuario
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMantUsuario));
            this.PTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PBotones = new System.Windows.Forms.Panel();
            this.BNuevo = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PTitulo.SuspendLayout();
            this.PBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PTitulo
            // 
            this.PTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.PTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PTitulo.Controls.Add(this.lblTitulo);
            this.PTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTitulo.Location = new System.Drawing.Point(0, 0);
            this.PTitulo.Name = "PTitulo";
            this.PTitulo.Size = new System.Drawing.Size(950, 56);
            this.PTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(946, 52);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mantenimiento de Usuario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBotones
            // 
            this.PBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.PBotones.Controls.Add(this.BNuevo);
            this.PBotones.Controls.Add(this.BGuardar);
            this.PBotones.Controls.Add(this.BEditar);
            this.PBotones.Controls.Add(this.BCancelar);
            this.PBotones.Controls.Add(this.BSalir);
            this.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBotones.Font = new System.Drawing.Font("Arial", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBotones.Location = new System.Drawing.Point(0, 540);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(950, 60);
            this.PBotones.TabIndex = 1;
            // 
            // BNuevo
            // 
            this.BNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BNuevo.BackgroundImage")));
            this.BNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNuevo.FlatAppearance.BorderSize = 0;
            this.BNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BNuevo.ForeColor = System.Drawing.Color.White;
            this.BNuevo.Location = new System.Drawing.Point(-43, 10);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(175, 35);
            this.BNuevo.TabIndex = 0;
            this.BNuevo.Text = "&Nuevo";
            this.BNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BNuevo.UseVisualStyleBackColor = false;
            this.BNuevo.Click += new System.EventHandler(this.BNuevo_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BGuardar.BackgroundImage")));
            this.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.Location = new System.Drawing.Point(42, 10);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(231, 35);
            this.BGuardar.TabIndex = 1;
            this.BGuardar.Text = "&Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEditar
            // 
            this.BEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BEditar.BackgroundImage")));
            this.BEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderSize = 0;
            this.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BEditar.ForeColor = System.Drawing.Color.White;
            this.BEditar.Location = new System.Drawing.Point(201, 10);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(197, 35);
            this.BEditar.TabIndex = 2;
            this.BEditar.Text = "&Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BCancelar.BackgroundImage")));
            this.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BCancelar.ForeColor = System.Drawing.Color.White;
            this.BCancelar.Location = new System.Drawing.Point(311, 10);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(226, 35);
            this.BCancelar.TabIndex = 3;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BSalir
            // 
            this.BSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSalir.BackgroundImage")));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSalir.FlatAppearance.BorderSize = 0;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.Location = new System.Drawing.Point(800, -3);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(138, 60);
            this.BSalir.TabIndex = 5;
            this.BSalir.Text = "&Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BBuscar
            // 
            this.BBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BBuscar.BackgroundImage")));
            this.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscar.FlatAppearance.BorderSize = 0;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.BBuscar.Location = new System.Drawing.Point(197, 87);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(207, 27);
            this.BBuscar.TabIndex = 4;
            this.BBuscar.Text = "&Buscar";
            this.BBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblIdUsuario.Location = new System.Drawing.Point(30, 90);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(95, 19);
            this.lblIdUsuario.TabIndex = 2;
            this.lblIdUsuario.Text = "Id Usuario:";
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Font = new System.Drawing.Font("Arial", 11F);
            this.tbIdUsuario.Location = new System.Drawing.Point(150, 87);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(120, 27);
            this.tbIdUsuario.TabIndex = 3;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblRol.Location = new System.Drawing.Point(470, 90);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(41, 19);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "Rol:";
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Arial", 11F);
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Cajero",
            "Gerente"});
            this.cbRol.Location = new System.Drawing.Point(620, 87);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(280, 27);
            this.cbRol.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(30, 160);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial", 11F);
            this.tbNombre.Location = new System.Drawing.Point(150, 157);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(280, 27);
            this.tbNombre.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(470, 160);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(77, 19);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido:";
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Arial", 11F);
            this.tbApellido.Location = new System.Drawing.Point(620, 157);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(280, 27);
            this.tbApellido.TabIndex = 9;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(30, 230);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 19);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Arial", 11F);
            this.tbUsuario.Location = new System.Drawing.Point(150, 227);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(280, 27);
            this.tbUsuario.TabIndex = 11;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.Location = new System.Drawing.Point(470, 230);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(106, 19);
            this.lblContraseña.TabIndex = 12;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Font = new System.Drawing.Font("Arial", 11F);
            this.tbContraseña.Location = new System.Drawing.Point(620, 227);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(280, 27);
            this.tbContraseña.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(30, 300);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 19);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Font = new System.Drawing.Font("Arial", 11F);
            this.tbEmail.Location = new System.Drawing.Point(150, 297);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(750, 27);
            this.tbEmail.TabIndex = 15;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(30, 370);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 19);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 11F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(150, 367);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(280, 27);
            this.cbEstado.TabIndex = 17;
            // 
            // FMantUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.tbIdUsuario);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.PBotones);
            this.Controls.Add(this.PTitulo);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FMantUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMantUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FMantUsuario_Load);
            this.PTitulo.ResumeLayout(false);
            this.PBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel PBotones;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BNuevo;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox tbIdUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}