namespace CapaPresentacion
{
    partial class FMantCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMantCliente));
            this.PTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PBotones = new System.Windows.Forms.Panel();
            this.BNuevo = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblDocumentoId = new System.Windows.Forms.Label();
            this.tbIDDocumento = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tbDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
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
            this.lblTitulo.Text = "Mantenimiento de Cliente";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBotones
            // 
            this.PBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.PBotones.Controls.Add(this.BNuevo);
            this.PBotones.Controls.Add(this.BGuardar);
            this.PBotones.Controls.Add(this.BEditar);
            this.PBotones.Controls.Add(this.BSalir);
            this.PBotones.Controls.Add(this.BCancelar);
            this.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBotones.Location = new System.Drawing.Point(0, 470);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(950, 60);
            this.PBotones.TabIndex = 1;
            // 
            // BNuevo
            // 
            this.BNuevo.BackColor = System.Drawing.Color.Transparent;
            this.BNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BNuevo.BackgroundImage")));
            this.BNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNuevo.FlatAppearance.BorderSize = 0;
            this.BNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BNuevo.ForeColor = System.Drawing.Color.White;
            this.BNuevo.Location = new System.Drawing.Point(-35, 10);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(191, 35);
            this.BNuevo.TabIndex = 0;
            this.BNuevo.Text = "&Nuevo";
            this.BNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BNuevo.UseVisualStyleBackColor = false;
            this.BNuevo.Click += new System.EventHandler(this.BNuevo_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BGuardar.BackgroundImage")));
            this.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.Location = new System.Drawing.Point(67, 11);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(224, 32);
            this.BGuardar.TabIndex = 1;
            this.BGuardar.Text = "&Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.Transparent;
            this.BEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BEditar.BackgroundImage")));
            this.BEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderSize = 0;
            this.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BEditar.ForeColor = System.Drawing.Color.White;
            this.BEditar.Location = new System.Drawing.Point(230, 10);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(175, 35);
            this.BEditar.TabIndex = 2;
            this.BEditar.Text = "&Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
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
            this.BSalir.Location = new System.Drawing.Point(789, -6);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(151, 64);
            this.BSalir.TabIndex = 5;
            this.BSalir.Text = "&Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BCancelar.BackgroundImage")));
            this.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BCancelar.ForeColor = System.Drawing.Color.White;
            this.BCancelar.Location = new System.Drawing.Point(319, 10);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(231, 35);
            this.BCancelar.TabIndex = 3;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
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
            this.BBuscar.Location = new System.Drawing.Point(196, 87);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(209, 27);
            this.BBuscar.TabIndex = 4;
            this.BBuscar.Text = "&Buscar";
            this.BBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblIdCliente.Location = new System.Drawing.Point(30, 90);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(88, 19);
            this.lblIdCliente.TabIndex = 2;
            this.lblIdCliente.Text = "Id Cliente:";
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Font = new System.Drawing.Font("Arial", 11F);
            this.tbIdCliente.Location = new System.Drawing.Point(150, 87);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(120, 27);
            this.tbIdCliente.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(30, 140);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Font = new System.Drawing.Font("Arial", 11F);
            this.tbNombreCliente.Location = new System.Drawing.Point(150, 137);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(280, 27);
            this.tbNombreCliente.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(30, 190);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(77, 19);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Font = new System.Drawing.Font("Arial", 11F);
            this.tbApellidoCliente.Location = new System.Drawing.Point(150, 187);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(280, 27);
            this.tbApellidoCliente.TabIndex = 7;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTipoDocumento.Location = new System.Drawing.Point(470, 190);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(144, 19);
            this.lblTipoDocumento.TabIndex = 8;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.Font = new System.Drawing.Font("Arial", 11F);
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "Cedula",
            "Pasaporte",
            "RNC"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(620, 187);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(280, 27);
            this.cbTipoDocumento.TabIndex = 9;
            // 
            // lblDocumentoId
            // 
            this.lblDocumentoId.AutoSize = true;
            this.lblDocumentoId.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblDocumentoId.Location = new System.Drawing.Point(470, 240);
            this.lblDocumentoId.Name = "lblDocumentoId";
            this.lblDocumentoId.Size = new System.Drawing.Size(137, 19);
            this.lblDocumentoId.TabIndex = 10;
            this.lblDocumentoId.Text = "No. Documento:";
            // 
            // tbIDDocumento
            // 
            this.tbIDDocumento.Font = new System.Drawing.Font("Arial", 11F);
            this.tbIDDocumento.Location = new System.Drawing.Point(620, 237);
            this.tbIDDocumento.Name = "tbIDDocumento";
            this.tbIDDocumento.Size = new System.Drawing.Size(280, 27);
            this.tbIDDocumento.TabIndex = 11;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(30, 240);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(81, 19);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // tbTelefonoCliente
            // 
            this.tbTelefonoCliente.Font = new System.Drawing.Font("Arial", 11F);
            this.tbTelefonoCliente.Location = new System.Drawing.Point(150, 237);
            this.tbTelefonoCliente.Name = "tbTelefonoCliente";
            this.tbTelefonoCliente.Size = new System.Drawing.Size(280, 27);
            this.tbTelefonoCliente.TabIndex = 13;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblSexo.Location = new System.Drawing.Point(470, 140);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 19);
            this.lblSexo.TabIndex = 14;
            this.lblSexo.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Arial", 11F);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(620, 137);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(280, 27);
            this.cbSexo.TabIndex = 15;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.Location = new System.Drawing.Point(30, 290);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(89, 19);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Dirección:";
            // 
            // tbDireccionCliente
            // 
            this.tbDireccionCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccionCliente.Font = new System.Drawing.Font("Arial", 11F);
            this.tbDireccionCliente.Location = new System.Drawing.Point(150, 290);
            this.tbDireccionCliente.Multiline = true;
            this.tbDireccionCliente.Name = "tbDireccionCliente";
            this.tbDireccionCliente.Size = new System.Drawing.Size(750, 60);
            this.tbDireccionCliente.TabIndex = 17;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(30, 380);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 19);
            this.lblEstado.TabIndex = 18;
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
            this.cbEstado.Location = new System.Drawing.Point(150, 377);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(280, 27);
            this.cbEstado.TabIndex = 19;
            // 
            // FMantCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(950, 530);
            this.Controls.Add(this.tbIdCliente);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tbDireccionCliente);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.tbIDDocumento);
            this.Controls.Add(this.lblDocumentoId);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.tbTelefonoCliente);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.tbApellidoCliente);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbNombreCliente);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.PBotones);
            this.Controls.Add(this.PTitulo);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FMantCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMantCliente_FormClosing);
            this.Load += new System.EventHandler(this.FMantCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FMantCliente_KeyDown);
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
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbApellidoCliente;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.Label lblDocumentoId;
        private System.Windows.Forms.TextBox tbIDDocumento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbTelefonoCliente;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox tbDireccionCliente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}