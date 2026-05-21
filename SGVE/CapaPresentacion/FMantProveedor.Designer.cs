namespace CapaPresentacion
{
    partial class FMantProveedor
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMantProveedor));
            this.PTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PBotones = new System.Windows.Forms.Panel();
            this.BNuevo = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.tbIdProveedor = new System.Windows.Forms.TextBox();
            this.lblRNC = new System.Windows.Forms.Label();
            this.tbRNC = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.tbNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblPersonaContacto = new System.Windows.Forms.Label();
            this.tbPersonaContacto = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
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
            this.lblTitulo.Text = "Mantenimiento de Proveedor";
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
            this.BNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BNuevo.Location = new System.Drawing.Point(-34, 10);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(182, 35);
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
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.Location = new System.Drawing.Point(60, 10);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(224, 35);
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
            this.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.Location = new System.Drawing.Point(216, 10);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(190, 35);
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
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.Location = new System.Drawing.Point(774, 0);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(142, 60);
            this.BSalir.TabIndex = 5;
            this.BSalir.Text = "&Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
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
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.Location = new System.Drawing.Point(314, 10);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(226, 35);
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
            this.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBuscar.Location = new System.Drawing.Point(213, 87);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(197, 27);
            this.BBuscar.TabIndex = 4;
            this.BBuscar.Text = "&Buscar";
            this.BBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblIdProveedor.Location = new System.Drawing.Point(30, 90);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(116, 19);
            this.lblIdProveedor.TabIndex = 2;
            this.lblIdProveedor.Text = "Id Proveedor:";
            // 
            // tbIdProveedor
            // 
            this.tbIdProveedor.Font = new System.Drawing.Font("Arial", 11F);
            this.tbIdProveedor.Location = new System.Drawing.Point(170, 87);
            this.tbIdProveedor.Name = "tbIdProveedor";
            this.tbIdProveedor.Size = new System.Drawing.Size(120, 27);
            this.tbIdProveedor.TabIndex = 3;
            // 
            // lblRNC
            // 
            this.lblRNC.AutoSize = true;
            this.lblRNC.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblRNC.Location = new System.Drawing.Point(470, 90);
            this.lblRNC.Name = "lblRNC";
            this.lblRNC.Size = new System.Drawing.Size(51, 19);
            this.lblRNC.TabIndex = 4;
            this.lblRNC.Text = "RNC:";
            // 
            // tbRNC
            // 
            this.tbRNC.Font = new System.Drawing.Font("Arial", 11F);
            this.tbRNC.Location = new System.Drawing.Point(625, 87);
            this.tbRNC.Name = "tbRNC";
            this.tbRNC.Size = new System.Drawing.Size(280, 27);
            this.tbRNC.TabIndex = 5;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombreProveedor.Location = new System.Drawing.Point(30, 160);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(77, 19);
            this.lblNombreProveedor.TabIndex = 6;
            this.lblNombreProveedor.Text = "Nombre:";
            // 
            // tbNombreProveedor
            // 
            this.tbNombreProveedor.Font = new System.Drawing.Font("Arial", 11F);
            this.tbNombreProveedor.Location = new System.Drawing.Point(170, 157);
            this.tbNombreProveedor.Name = "tbNombreProveedor";
            this.tbNombreProveedor.Size = new System.Drawing.Size(260, 27);
            this.tbNombreProveedor.TabIndex = 7;
            // 
            // lblPersonaContacto
            // 
            this.lblPersonaContacto.AutoSize = true;
            this.lblPersonaContacto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPersonaContacto.Location = new System.Drawing.Point(470, 160);
            this.lblPersonaContacto.Name = "lblPersonaContacto";
            this.lblPersonaContacto.Size = new System.Drawing.Size(157, 19);
            this.lblPersonaContacto.TabIndex = 8;
            this.lblPersonaContacto.Text = "Persona Contacto:";
            // 
            // tbPersonaContacto
            // 
            this.tbPersonaContacto.Font = new System.Drawing.Font("Arial", 11F);
            this.tbPersonaContacto.Location = new System.Drawing.Point(625, 157);
            this.tbPersonaContacto.Name = "tbPersonaContacto";
            this.tbPersonaContacto.Size = new System.Drawing.Size(280, 27);
            this.tbPersonaContacto.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(30, 230);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(81, 19);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Arial", 11F);
            this.tbTelefono.Location = new System.Drawing.Point(170, 227);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(260, 27);
            this.tbTelefono.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(470, 230);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 19);
            this.lblEstado.TabIndex = 12;
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
            this.cbEstado.Location = new System.Drawing.Point(625, 227);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(280, 27);
            this.cbEstado.TabIndex = 13;
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
            this.tbEmail.Location = new System.Drawing.Point(170, 297);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(730, 27);
            this.tbEmail.TabIndex = 15;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.Location = new System.Drawing.Point(30, 370);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(89, 19);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Dirección:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccion.Font = new System.Drawing.Font("Arial", 11F);
            this.tbDireccion.Location = new System.Drawing.Point(170, 367);
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(730, 60);
            this.tbDireccion.TabIndex = 17;
            // 
            // FMantProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.tbIdProveedor);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.tbPersonaContacto);
            this.Controls.Add(this.lblPersonaContacto);
            this.Controls.Add(this.tbNombreProveedor);
            this.Controls.Add(this.lblNombreProveedor);
            this.Controls.Add(this.tbRNC);
            this.Controls.Add(this.lblRNC);
            this.Controls.Add(this.lblIdProveedor);
            this.Controls.Add(this.PBotones);
            this.Controls.Add(this.PTitulo);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FMantProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Proveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMantProveedor_FormClosing);
            this.Load += new System.EventHandler(this.FMantProveedor_Load);
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
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.TextBox tbIdProveedor;
        private System.Windows.Forms.Label lblRNC;
        private System.Windows.Forms.TextBox tbRNC;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TextBox tbNombreProveedor;
        private System.Windows.Forms.Label lblPersonaContacto;
        private System.Windows.Forms.TextBox tbPersonaContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}