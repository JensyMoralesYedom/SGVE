namespace CapaPresentacion
{
    partial class FMaestroDetalleFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMaestroDetalleFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBoton = new System.Windows.Forms.Panel();
            this.BPrimero = new System.Windows.Forms.Button();
            this.BAnterior = new System.Windows.Forms.Button();
            this.BSiguiente = new System.Windows.Forms.Button();
            this.BUltimo = new System.Windows.Forms.Button();
            this.lblCantLabel = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
            this.pInformacion = new System.Windows.Forms.Panel();
            this.BConsultar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTitulo.SuspendLayout();
            this.panelBoton.SuspendLayout();
            this.pInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(900, 56);
            this.panelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta General de Ventas (Facturas)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelBoton
            // 
            this.panelBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panelBoton.Controls.Add(this.BPrimero);
            this.panelBoton.Controls.Add(this.BAnterior);
            this.panelBoton.Controls.Add(this.BSiguiente);
            this.panelBoton.Controls.Add(this.BUltimo);
            this.panelBoton.Controls.Add(this.lblCantLabel);
            this.panelBoton.Controls.Add(this.BSalir);
            this.panelBoton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBoton.Location = new System.Drawing.Point(0, 570);
            this.panelBoton.Name = "panelBoton";
            this.panelBoton.Size = new System.Drawing.Size(900, 60);
            this.panelBoton.TabIndex = 1;
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
            this.BPrimero.TabIndex = 17;
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
            this.BAnterior.TabIndex = 18;
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
            this.BSiguiente.TabIndex = 19;
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
            this.BUltimo.TabIndex = 20;
            this.BUltimo.UseVisualStyleBackColor = true;
            this.BUltimo.Click += new System.EventHandler(this.BUltimo_Click);
            // 
            // lblCantLabel
            // 
            this.lblCantLabel.AutoSize = true;
            this.lblCantLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCantLabel.ForeColor = System.Drawing.Color.White;
            this.lblCantLabel.Location = new System.Drawing.Point(380, 22);
            this.lblCantLabel.Name = "lblCantLabel";
            this.lblCantLabel.Size = new System.Drawing.Size(151, 21);
            this.lblCantLabel.TabIndex = 16;
            this.lblCantLabel.Text = "Total Facturado:";
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
            this.BSalir.Location = new System.Drawing.Point(760, 14);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(125, 34);
            this.BSalir.TabIndex = 22;
            this.BSalir.Text = "&Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // pInformacion
            // 
            this.pInformacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pInformacion.Controls.Add(this.BConsultar);
            this.pInformacion.Controls.Add(this.lblBuscar);
            this.pInformacion.Controls.Add(this.tbBuscar);
            this.pInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInformacion.Location = new System.Drawing.Point(0, 56);
            this.pInformacion.Name = "pInformacion";
            this.pInformacion.Size = new System.Drawing.Size(900, 50);
            this.pInformacion.TabIndex = 2;
            // 
            // BConsultar
            // 
            this.BConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.BConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BConsultar.FlatAppearance.BorderSize = 0;
            this.BConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BConsultar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BConsultar.ForeColor = System.Drawing.Color.White;
            this.BConsultar.Location = new System.Drawing.Point(613, 9);
            this.BConsultar.Name = "BConsultar";
            this.BConsultar.Size = new System.Drawing.Size(120, 30);
            this.BConsultar.TabIndex = 20;
            this.BConsultar.Text = "&Consultar";
            this.BConsultar.UseVisualStyleBackColor = false;
            this.BConsultar.Click += new System.EventHandler(this.BConsultar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(16, 14);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(204, 19);
            this.lblBuscar.TabIndex = 15;
            this.lblBuscar.Text = "Ingrese el dato a buscar:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Arial", 10.5F);
            this.tbBuscar.Location = new System.Drawing.Point(226, 11);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(370, 26);
            this.tbBuscar.TabIndex = 16;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 106);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvFacturas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetalleFactura);
            this.splitContainer1.Size = new System.Drawing.Size(900, 464);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AllowUserToResizeRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturas.ColumnHeadersHeight = 40;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.EnableHeadersVisualStyles = false;
            this.dgvFacturas.GridColor = System.Drawing.Color.LightGray;
            this.dgvFacturas.Location = new System.Drawing.Point(0, 0);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.RowHeadersWidth = 47;
            this.dgvFacturas.RowTemplate.Height = 35;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(900, 230);
            this.dgvFacturas.TabIndex = 0;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            this.dgvFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellDoubleClick);
            this.dgvFacturas.CurrentCellChanged += new System.EventHandler(this.dgvFacturas_CurrentCellChanged);
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.AllowUserToDeleteRows = false;
            this.dgvDetalleFactura.AllowUserToResizeRows = false;
            this.dgvDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleFactura.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleFactura.ColumnHeadersHeight = 35;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleFactura.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleFactura.EnableHeadersVisualStyles = false;
            this.dgvDetalleFactura.GridColor = System.Drawing.Color.LightGray;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleFactura.MultiSelect = false;
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            this.dgvDetalleFactura.RowHeadersVisible = false;
            this.dgvDetalleFactura.RowHeadersWidth = 47;
            this.dgvDetalleFactura.RowTemplate.Height = 30;
            this.dgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(900, 229);
            this.dgvDetalleFactura.TabIndex = 0;
            // 
            // FMaestroDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pInformacion);
            this.Controls.Add(this.panelBoton);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMaestroDetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Facturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMaestroDetalleFactura_FormClosing);
            this.panelTitulo.ResumeLayout(false);
            this.panelBoton.ResumeLayout(false);
            this.panelBoton.PerformLayout();
            this.pInformacion.ResumeLayout(false);
            this.pInformacion.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pInformacion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button BConsultar;
        private System.Windows.Forms.Label lblCantLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BSiguiente;
        private System.Windows.Forms.Button BAnterior;
        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.Button BUltimo;
    }
}