namespace CapaPresentacion
{
    partial class FMantCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMantCategoria));
            this.pTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pBotones = new System.Windows.Forms.Panel();
            this.BNuevo = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BBuscar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.tbIdCategoría = new System.Windows.Forms.TextBox();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.tbNombreCategoria = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.tbDescripción = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pTitulo.SuspendLayout();
            this.pBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pTitulo.Controls.Add(this.lblTitulo);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(900, 45);
            this.pTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(896, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mantenimiento de Categoría";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBotones.Controls.Add(this.BNuevo);
            this.pBotones.Controls.Add(this.BGuardar);
            this.pBotones.Controls.Add(this.BEditar);
            this.pBotones.Controls.Add(this.BCancelar);
            this.pBotones.Controls.Add(this.BSalir);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBotones.Location = new System.Drawing.Point(0, 580);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(900, 50);
            this.pBotones.TabIndex = 1;
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
            this.BNuevo.Location = new System.Drawing.Point(-50, 8);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(176, 34);
            this.BNuevo.TabIndex = 6;
            this.BNuevo.Text = "&Nuevo";
            this.BNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BNuevo.UseVisualStyleBackColor = true;
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
            this.BGuardar.Location = new System.Drawing.Point(34, 9);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(226, 29);
            this.BGuardar.TabIndex = 7;
            this.BGuardar.Text = "&Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = true;
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
            this.BEditar.Location = new System.Drawing.Point(185, 6);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(195, 34);
            this.BEditar.TabIndex = 8;
            this.BEditar.Text = "&Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.UseVisualStyleBackColor = true;
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
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.Location = new System.Drawing.Point(291, 6);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(222, 34);
            this.BCancelar.TabIndex = 9;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSalir.BackgroundImage")));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSalir.FlatAppearance.BorderSize = 0;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.Location = new System.Drawing.Point(745, -9);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(147, 65);
            this.BSalir.TabIndex = 10;
            this.BSalir.Text = "&Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
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
            this.BBuscar.Location = new System.Drawing.Point(194, 68);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(222, 27);
            this.BBuscar.TabIndex = 11;
            this.BBuscar.Text = "&Buscar";
            this.BBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 11F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(194, 373);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(188, 27);
            this.cbEstado.TabIndex = 26;
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblIdCategoria.Location = new System.Drawing.Point(30, 72);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(110, 19);
            this.lblIdCategoria.TabIndex = 12;
            this.lblIdCategoria.Text = "Id Categoría:";
            // 
            // tbIdCategoría
            // 
            this.tbIdCategoría.Font = new System.Drawing.Font("Arial", 11F);
            this.tbIdCategoría.Location = new System.Drawing.Point(194, 68);
            this.tbIdCategoría.Name = "tbIdCategoría";
            this.tbIdCategoría.Size = new System.Drawing.Size(81, 27);
            this.tbIdCategoría.TabIndex = 13;
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombreCategoria.Location = new System.Drawing.Point(30, 153);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(158, 19);
            this.lblNombreCategoria.TabIndex = 14;
            this.lblNombreCategoria.Text = "Nombre Categoría:";
            this.lblNombreCategoria.Click += new System.EventHandler(this.lblNombreCategoria_Click);
            // 
            // tbNombreCategoria
            // 
            this.tbNombreCategoria.Font = new System.Drawing.Font("Arial", 11F);
            this.tbNombreCategoria.Location = new System.Drawing.Point(194, 145);
            this.tbNombreCategoria.Name = "tbNombreCategoria";
            this.tbNombreCategoria.Size = new System.Drawing.Size(350, 27);
            this.tbNombreCategoria.TabIndex = 15;
            this.tbNombreCategoria.TextChanged += new System.EventHandler(this.tbNombreCategoria_TextChanged);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelDescripcion.Location = new System.Drawing.Point(32, 236);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(108, 19);
            this.labelDescripcion.TabIndex = 16;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // tbDescripción
            // 
            this.tbDescripción.Font = new System.Drawing.Font("Arial", 11F);
            this.tbDescripción.Location = new System.Drawing.Point(194, 236);
            this.tbDescripción.Multiline = true;
            this.tbDescripción.Name = "tbDescripción";
            this.tbDescripción.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripción.Size = new System.Drawing.Size(530, 90);
            this.tbDescripción.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estado:";
            // 
            // FMantCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescripción);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.tbNombreCategoria);
            this.Controls.Add(this.lblNombreCategoria);
            this.Controls.Add(this.tbIdCategoría);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.pTitulo);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FMantCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Categoría";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMantCategoria_FormClosing);
            this.Load += new System.EventHandler(this.FMantCategoria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FMantCategoria_KeyDown);
            this.pTitulo.ResumeLayout(false);
            this.pBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BNuevo;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.TextBox tbIdCategoría;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox tbNombreCategoria;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox tbDescripción;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}