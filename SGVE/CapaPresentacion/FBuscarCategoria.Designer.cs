namespace CapaPresentacion
{
    partial class FBuscarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBuscarCategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PInformacion = new System.Windows.Forms.Panel();
            this.BBuscarDato = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.PBotones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.lblTitulo.Text = "Búsqueda de Categorías";
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
            this.BBuscarDato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscarDato.FlatAppearance.BorderSize = 0;
            this.BBuscarDato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarDato.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BBuscarDato.ForeColor = System.Drawing.Color.White;
            this.BBuscarDato.Location = new System.Drawing.Point(618, 11);
            this.BBuscarDato.Name = "BBuscarDato";
            this.BBuscarDato.Size = new System.Drawing.Size(120, 30);
            this.BBuscarDato.TabIndex = 2;
            this.BBuscarDato.Text = "&Buscar Dato";
            this.BBuscarDato.UseVisualStyleBackColor = false;
            this.BBuscarDato.Click += new System.EventHandler(this.BBuscarDato_Click);
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
            this.tbBuscar.Location = new System.Drawing.Point(226, 11);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(370, 26);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // PBotones
            // 
            this.PBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.PBotones.Controls.Add(this.button1);
            this.PBotones.Controls.Add(this.button2);
            this.PBotones.Controls.Add(this.button3);
            this.PBotones.Controls.Add(this.button4);
            this.PBotones.Controls.Add(this.button5);
            this.PBotones.Controls.Add(this.button6);
            this.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBotones.Location = new System.Drawing.Point(0, 570);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(900, 60);
            this.PBotones.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(532, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Aceptar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.baceptar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(675, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "&Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(176, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 35);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(124, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(74, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(23, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 36);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.bPrimero_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDatos.ColumnHeadersHeight = 40;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
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
            this.DGVDatos.TabIndex = 3;
            this.DGVDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellContentClick);
            this.DGVDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellDoubleClick);
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
            // 
            // FBuscarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.PInformacion);
            this.Controls.Add(this.PTitulo);
            this.Controls.Add(this.PBotones);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBuscarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Categoría";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBuscarCategoria_FormClosing);
            this.Load += new System.EventHandler(this.FBuscarCategoria_Load);
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
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}