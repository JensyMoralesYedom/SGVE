namespace CapaPresentacion
{
    partial class FConsultaUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsultaUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PInformacion = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.BConsultar = new System.Windows.Forms.Button();
            this.BImprimir = new System.Windows.Forms.Button();
            this.PBotones = new System.Windows.Forms.Panel();
            this.lblCantLabel = new System.Windows.Forms.Label();
            this.BPrimero = new System.Windows.Forms.Button();
            this.BAnterior = new System.Windows.Forms.Button();
            this.BSiguiente = new System.Windows.Forms.Button();
            this.BUltimo = new System.Windows.Forms.Button();
            this.LCantUsuario = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.PTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PTitulo.Name = "PTitulo";
            this.PTitulo.Size = new System.Drawing.Size(900, 49);
            this.PTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(896, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consulta General de Usuarios";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // PInformacion
            // 
            this.PInformacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PInformacion.Controls.Add(this.lblBuscar);
            this.PInformacion.Controls.Add(this.tbBuscar);
            this.PInformacion.Controls.Add(this.BConsultar);
            this.PInformacion.Controls.Add(this.BImprimir);
            this.PInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PInformacion.Location = new System.Drawing.Point(0, 49);
            this.PInformacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PInformacion.Name = "PInformacion";
            this.PInformacion.Size = new System.Drawing.Size(900, 50);
            this.PInformacion.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 14);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(224, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Ingrese el dato a consultar:";
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Arial", 10.5F);
            this.tbBuscar.Location = new System.Drawing.Point(236, 11);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(350, 26);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // BConsultar
            // 
            this.BConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.BConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BConsultar.FlatAppearance.BorderSize = 0;
            this.BConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BConsultar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConsultar.ForeColor = System.Drawing.Color.White;
            this.BConsultar.Location = new System.Drawing.Point(595, 8);
            this.BConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BConsultar.Name = "BConsultar";
            this.BConsultar.Size = new System.Drawing.Size(120, 30);
            this.BConsultar.TabIndex = 1;
            this.BConsultar.Text = "&Consultar";
            this.toolTip1.SetToolTip(this.BConsultar, "Realizar la consulta de información");
            this.BConsultar.UseVisualStyleBackColor = false;
            this.BConsultar.Click += new System.EventHandler(this.BConsultar_Click);
            // 
            // BImprimir
            // 
            this.BImprimir.BackColor = System.Drawing.Color.Transparent;
            this.BImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BImprimir.BackgroundImage")));
            this.BImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BImprimir.FlatAppearance.BorderSize = 0;
            this.BImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BImprimir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BImprimir.ForeColor = System.Drawing.Color.Black;
            this.BImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BImprimir.Location = new System.Drawing.Point(660, 10);
            this.BImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(185, 26);
            this.BImprimir.TabIndex = 14;
            this.BImprimir.Text = "&Imprimir";
            this.BImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.BImprimir, "Generar el reporte correspondiente");
            this.BImprimir.UseVisualStyleBackColor = false;
            this.BImprimir.Click += new System.EventHandler(this.BImprimir_Click);
            // 
            // PBotones
            // 
            this.PBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.PBotones.Controls.Add(this.lblCantLabel);
            this.PBotones.Controls.Add(this.BPrimero);
            this.PBotones.Controls.Add(this.BAnterior);
            this.PBotones.Controls.Add(this.BSiguiente);
            this.PBotones.Controls.Add(this.BUltimo);
            this.PBotones.Controls.Add(this.LCantUsuario);
            this.PBotones.Controls.Add(this.BSalir);
            this.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBotones.Location = new System.Drawing.Point(0, 570);
            this.PBotones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(900, 60);
            this.PBotones.TabIndex = 2;
            this.PBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.PBotones_Paint);
            // 
            // lblCantLabel
            // 
            this.lblCantLabel.AutoSize = true;
            this.lblCantLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCantLabel.ForeColor = System.Drawing.Color.White;
            this.lblCantLabel.Location = new System.Drawing.Point(380, 22);
            this.lblCantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantLabel.Name = "lblCantLabel";
            this.lblCantLabel.Size = new System.Drawing.Size(218, 21);
            this.lblCantLabel.TabIndex = 14;
            this.lblCantLabel.Text = "Cantidad de Usuarios: 0";
            // 
            // BPrimero
            // 
            this.BPrimero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BPrimero.BackgroundImage")));
            this.BPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BPrimero.FlatAppearance.BorderSize = 0;
            this.BPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPrimero.Location = new System.Drawing.Point(14, 14);
            this.BPrimero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(39, 34);
            this.BPrimero.TabIndex = 10;
            this.toolTip1.SetToolTip(this.BPrimero, "Ir al primer registro");
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
            this.BAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BAnterior.Name = "BAnterior";
            this.BAnterior.Size = new System.Drawing.Size(36, 34);
            this.BAnterior.TabIndex = 11;
            this.toolTip1.SetToolTip(this.BAnterior, "Ir al registro anterior");
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
            this.BSiguiente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BSiguiente.Name = "BSiguiente";
            this.BSiguiente.Size = new System.Drawing.Size(32, 34);
            this.BSiguiente.TabIndex = 12;
            this.toolTip1.SetToolTip(this.BSiguiente, "Ir al registro siguiente");
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
            this.BUltimo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BUltimo.Name = "BUltimo";
            this.BUltimo.Size = new System.Drawing.Size(45, 34);
            this.BUltimo.TabIndex = 13;
            this.toolTip1.SetToolTip(this.BUltimo, "Ir al último registro");
            this.BUltimo.Click += new System.EventHandler(this.BUltimo_Click);
            // 
            // LCantUsuario
            // 
            this.LCantUsuario.AutoSize = true;
            this.LCantUsuario.ForeColor = System.Drawing.Color.White;
            this.LCantUsuario.Location = new System.Drawing.Point(590, 22);
            this.LCantUsuario.Name = "LCantUsuario";
            this.LCantUsuario.Size = new System.Drawing.Size(18, 19);
            this.LCantUsuario.TabIndex = 15;
            this.LCantUsuario.Text = "0";
            this.LCantUsuario.Visible = false;
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
            this.BSalir.Location = new System.Drawing.Point(751, 4);
            this.BSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(125, 55);
            this.BSalir.TabIndex = 15;
            this.BSalir.Text = "&Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BSalir, "Salir del Formulario");
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
            this.DGVDatos.Location = new System.Drawing.Point(0, 99);
            this.DGVDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGVDatos.MultiSelect = false;
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.RowHeadersVisible = false;
            this.DGVDatos.RowHeadersWidth = 47;
            this.DGVDatos.RowTemplate.Height = 35;
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(900, 471);
            this.DGVDatos.TabIndex = 3;
            this.DGVDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellContentClick);
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
            // 
            // FConsultaUsuario
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta General de Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultaUsuario_FormClosing);
            this.Load += new System.EventHandler(this.ConsultaUsuario_Load);
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
        private System.Windows.Forms.Label lblCantLabel;
        private System.Windows.Forms.Label LCantUsuario;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}