namespace CapaPresentacion
{
    partial class FBuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBuscarCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PInformacion = new System.Windows.Forms.Panel();
            this.BBuscarDato = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.PBotones = new System.Windows.Forms.Panel();
            this.baceptar = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.bUltimo = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.PTitulo.SuspendLayout();
            this.PInformacion.SuspendLayout();
            this.PBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
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
            this.PTitulo.Size = new System.Drawing.Size(900, 56);
            this.PTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(896, 52);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Búsqueda de Cliente";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PInformacion
            // 
            this.PInformacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PInformacion.Controls.Add(this.BBuscarDato);
            this.PInformacion.Controls.Add(this.lblBuscar);
            this.PInformacion.Controls.Add(this.tbBuscar);
            this.PInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PInformacion.Location = new System.Drawing.Point(0, 56);
            this.PInformacion.Name = "PInformacion";
            this.PInformacion.Size = new System.Drawing.Size(900, 50);
            this.PInformacion.TabIndex = 1;
            // 
            // BBuscarDato
            // 
            this.BBuscarDato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.BBuscarDato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarDato.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarDato.ForeColor = System.Drawing.Color.White;
            this.BBuscarDato.Location = new System.Drawing.Point(645, 10);
            this.BBuscarDato.Name = "BBuscarDato";
            this.BBuscarDato.Size = new System.Drawing.Size(130, 30);
            this.BBuscarDato.TabIndex = 2;
            this.BBuscarDato.Text = "&Buscar Dato";
            this.BBuscarDato.UseVisualStyleBackColor = false;
            this.BBuscarDato.Click += new System.EventHandler(this.BBuscarDato_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(20, 15);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(189, 21);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Ingrese el dato a buscar:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbBuscar.Location = new System.Drawing.Point(215, 12);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(400, 28);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // PBotones
            // 
            this.PBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.PBotones.Controls.Add(this.baceptar);
            this.PBotones.Controls.Add(this.bcancelar);
            this.PBotones.Controls.Add(this.bUltimo);
            this.PBotones.Controls.Add(this.bSiguiente);
            this.PBotones.Controls.Add(this.bAnterior);
            this.PBotones.Controls.Add(this.bPrimero);
            this.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBotones.Location = new System.Drawing.Point(0, 570);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(900, 60);
            this.PBotones.TabIndex = 3;
            // 
            // baceptar
            // 
            this.baceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("baceptar.BackgroundImage")));
            this.baceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.baceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baceptar.FlatAppearance.BorderSize = 0;
            this.baceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptar.ForeColor = System.Drawing.Color.White;
            this.baceptar.Location = new System.Drawing.Point(505, 14);
            this.baceptar.Name = "baceptar";
            this.baceptar.Size = new System.Drawing.Size(211, 36);
            this.baceptar.TabIndex = 4;
            this.baceptar.Text = "&Aceptar";
            this.baceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.baceptar.UseVisualStyleBackColor = true;
            this.baceptar.Click += new System.EventHandler(this.baceptar_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bcancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bcancelar.BackgroundImage")));
            this.bcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcancelar.FlatAppearance.BorderSize = 0;
            this.bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelar.ForeColor = System.Drawing.Color.White;
            this.bcancelar.Location = new System.Drawing.Point(645, 14);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(243, 35);
            this.bcancelar.TabIndex = 5;
            this.bcancelar.Text = "&Cancelar";
            this.bcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // bUltimo
            // 
            this.bUltimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bUltimo.BackgroundImage")));
            this.bUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bUltimo.FlatAppearance.BorderSize = 0;
            this.bUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUltimo.Location = new System.Drawing.Point(170, 14);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(36, 35);
            this.bUltimo.TabIndex = 3;
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSiguiente.BackgroundImage")));
            this.bSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSiguiente.FlatAppearance.BorderSize = 0;
            this.bSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSiguiente.Location = new System.Drawing.Point(118, 14);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(35, 35);
            this.bSiguiente.TabIndex = 2;
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAnterior.BackgroundImage")));
            this.bAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAnterior.FlatAppearance.BorderSize = 0;
            this.bAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAnterior.Location = new System.Drawing.Point(68, 14);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(35, 35);
            this.bAnterior.TabIndex = 1;
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPrimero.BackgroundImage")));
            this.bPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPrimero.FlatAppearance.BorderSize = 0;
            this.bPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrimero.Location = new System.Drawing.Point(17, 14);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(38, 36);
            this.bPrimero.TabIndex = 0;
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            this.DGVDatos.AllowUserToResizeRows = false;
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDatos.BackgroundColor = System.Drawing.Color.White;
            this.DGVDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDatos.ColumnHeadersHeight = 40;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDatos.EnableHeadersVisualStyles = false;
            this.DGVDatos.GridColor = System.Drawing.Color.LightGray;
            this.DGVDatos.Location = new System.Drawing.Point(0, 106);
            this.DGVDatos.MultiSelect = false;
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.RowHeadersVisible = false;
            this.DGVDatos.RowHeadersWidth = 47;
            this.DGVDatos.RowTemplate.Height = 35;
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(900, 464);
            this.DGVDatos.TabIndex = 2;
            this.DGVDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellContentClick);
            this.DGVDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellDoubleClick);
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
            // 
            // FBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.PInformacion);
            this.Controls.Add(this.PTitulo);
            this.Controls.Add(this.PBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBuscarCliente_FormClosing);
            this.Load += new System.EventHandler(this.FBuscarCliente_Load);
            this.PTitulo.ResumeLayout(false);
            this.PInformacion.ResumeLayout(false);
            this.PInformacion.PerformLayout();
            this.PBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel PInformacion;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button BBuscarDato;
        private System.Windows.Forms.Panel PBotones;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Button baceptar;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.DataGridView DGVDatos;
    }
}