namespace CapaPresentacion
{
    partial class FConsultaCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsultaCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PInformacion = new System.Windows.Forms.Panel();
            this.BConsultar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.BImprimir = new System.Windows.Forms.Button();
            this.PBotones = new System.Windows.Forms.Panel();
            this.BPrimero = new System.Windows.Forms.Button();
            this.BAnterior = new System.Windows.Forms.Button();
            this.BSiguiente = new System.Windows.Forms.Button();
            this.BUltimo = new System.Windows.Forms.Button();
            this.LCantCliente = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
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
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(896, 52);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consulta General de Clientes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PInformacion
            // 
            this.PInformacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PInformacion.Controls.Add(this.BConsultar);
            this.PInformacion.Controls.Add(this.lblBuscar);
            this.PInformacion.Controls.Add(this.tbBuscar);
            this.PInformacion.Controls.Add(this.BImprimir);
            this.PInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PInformacion.Location = new System.Drawing.Point(0, 56);
            this.PInformacion.Name = "PInformacion";
            this.PInformacion.Size = new System.Drawing.Size(900, 50);
            this.PInformacion.TabIndex = 1;
            // 
            // BConsultar
            // 
            this.BConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.BConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BConsultar.FlatAppearance.BorderSize = 0;
            this.BConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BConsultar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BConsultar.ForeColor = System.Drawing.Color.White;
            this.BConsultar.Location = new System.Drawing.Point(595, 9);
            this.BConsultar.Name = "BConsultar";
            this.BConsultar.Size = new System.Drawing.Size(120, 30);
            this.BConsultar.TabIndex = 2;
            this.BConsultar.Text = "&Consultar";
            this.BConsultar.UseVisualStyleBackColor = false;
            this.BConsultar.Click += new System.EventHandler(this.BConsultar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(16, 14);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(204, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Ingrese el dato a buscar:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Arial", 10.5F);
            this.tbBuscar.Location = new System.Drawing.Point(219, 11);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(370, 26);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // BImprimir
            // 
            this.BImprimir.BackColor = System.Drawing.Color.Transparent;
            this.BImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BImprimir.BackgroundImage")));
            this.BImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BImprimir.FlatAppearance.BorderSize = 0;
            this.BImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BImprimir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BImprimir.ForeColor = System.Drawing.Color.Black;
            this.BImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BImprimir.Location = new System.Drawing.Point(664, 9);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(185, 30);
            this.BImprimir.TabIndex = 5;
            this.BImprimir.Text = "&Imprimir";
            this.BImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BImprimir.UseVisualStyleBackColor = false;
            this.BImprimir.Click += new System.EventHandler(this.BImprimir_Click);
            // 
            // PBotones
            // 
            this.PBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.PBotones.Controls.Add(this.BPrimero);
            this.PBotones.Controls.Add(this.BAnterior);
            this.PBotones.Controls.Add(this.BSiguiente);
            this.PBotones.Controls.Add(this.BUltimo);
            this.PBotones.Controls.Add(this.LCantCliente);
            this.PBotones.Controls.Add(this.BSalir);
            this.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBotones.Location = new System.Drawing.Point(0, 570);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(900, 60);
            this.PBotones.TabIndex = 3;
            // 
            // BPrimero
            // 
            this.BPrimero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BPrimero.BackgroundImage")));
            this.BPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BPrimero.FlatAppearance.BorderSize = 0;
            this.BPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPrimero.Location = new System.Drawing.Point(14, 14);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(39, 34);
            this.BPrimero.TabIndex = 10;
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // BAnterior
            // 
            this.BAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BAnterior.BackgroundImage")));
            this.BAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAnterior.FlatAppearance.BorderSize = 0;
            this.BAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnterior.Location = new System.Drawing.Point(68, 14);
            this.BAnterior.Name = "BAnterior";
            this.BAnterior.Size = new System.Drawing.Size(36, 34);
            this.BAnterior.TabIndex = 11;
            this.BAnterior.UseVisualStyleBackColor = true;
            this.BAnterior.Click += new System.EventHandler(this.BAnterior_Click);
            // 
            // BSiguiente
            // 
            this.BSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSiguiente.BackgroundImage")));
            this.BSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSiguiente.FlatAppearance.BorderSize = 0;
            this.BSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSiguiente.Location = new System.Drawing.Point(121, 14);
            this.BSiguiente.Name = "BSiguiente";
            this.BSiguiente.Size = new System.Drawing.Size(32, 34);
            this.BSiguiente.TabIndex = 12;
            this.BSiguiente.UseVisualStyleBackColor = true;
            this.BSiguiente.Click += new System.EventHandler(this.BSiguiente_Click);
            // 
            // BUltimo
            // 
            this.BUltimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BUltimo.BackgroundImage")));
            this.BUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUltimo.FlatAppearance.BorderSize = 0;
            this.BUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUltimo.Location = new System.Drawing.Point(165, 14);
            this.BUltimo.Name = "BUltimo";
            this.BUltimo.Size = new System.Drawing.Size(45, 34);
            this.BUltimo.TabIndex = 13;
            this.BUltimo.UseVisualStyleBackColor = true;
            this.BUltimo.Click += new System.EventHandler(this.BUltimo_Click);
            // 
            // LCantCliente
            // 
            this.LCantCliente.AutoSize = true;
            this.LCantCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.LCantCliente.ForeColor = System.Drawing.Color.White;
            this.LCantCliente.Location = new System.Drawing.Point(380, 22);
            this.LCantCliente.Name = "LCantCliente";
            this.LCantCliente.Size = new System.Drawing.Size(213, 21);
            this.LCantCliente.TabIndex = 15;
            this.LCantCliente.Text = "Cantidad de Clientes: 0";
            // 
            // BSalir
            // 
            this.BSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSalir.BackgroundImage")));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSalir.FlatAppearance.BorderSize = 0;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.Location = new System.Drawing.Point(763, 6);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(125, 48);
            this.BSalir.TabIndex = 15;
            this.BSalir.Text = "&Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDatos.ColumnHeadersHeight = 40;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
            // 
            // FConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.PInformacion);
            this.Controls.Add(this.PTitulo);
            this.Controls.Add(this.PBotones);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FConsultaCliente_FormClosing);
            this.Load += new System.EventHandler(this.FConsultaCliente_Load);
            this.PTitulo.ResumeLayout(false);
            this.PInformacion.ResumeLayout(false);
            this.PInformacion.PerformLayout();
            this.PBotones.ResumeLayout(false);
            this.PBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel PInformacion;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button BConsultar;
        private System.Windows.Forms.Panel PBotones;
        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.Button BAnterior;
        private System.Windows.Forms.Button BSiguiente;
        private System.Windows.Forms.Button BUltimo;
        private System.Windows.Forms.Button BImprimir;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Label LCantCliente;
        private System.Windows.Forms.DataGridView DGVDatos;
    }
}