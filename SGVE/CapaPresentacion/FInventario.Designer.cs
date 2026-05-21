namespace CapaPresentacion
{
    partial class FInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PBotones = new System.Windows.Forms.Panel();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.gbCabecera = new System.Windows.Forms.GroupBox();
            this.tbObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.dtpFechaMovimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.BAgregar = new System.Windows.Forms.Button();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.tbCostoUnitario = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tbStockActual = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.DGVDetalle = new System.Windows.Forms.DataGridView();
            this.lblTextoTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.PTitulo.SuspendLayout();
            this.PBotones.SuspendLayout();
            this.gbCabecera.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).BeginInit();
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
            this.PTitulo.Size = new System.Drawing.Size(950, 45);
            this.PTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(946, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ajuste de Inventario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBotones
            // 
            this.PBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.PBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBotones.Controls.Add(this.BGuardar);
            this.PBotones.Controls.Add(this.BCancelar);
            this.PBotones.Controls.Add(this.BSalir);
            this.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBotones.Location = new System.Drawing.Point(0, 570);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(950, 50);
            this.PBotones.TabIndex = 1;
            // 
            // BGuardar
            // 
            this.BGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BGuardar.BackgroundImage")));
            this.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(-76, 5);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(233, 36);
            this.BGuardar.TabIndex = 0;
            this.BGuardar.Text = "  Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BCancelar.BackgroundImage")));
            this.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BCancelar.ForeColor = System.Drawing.Color.White;
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(69, 5);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(214, 36);
            this.BCancelar.TabIndex = 1;
            this.BCancelar.Text = "  Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.UseVisualStyleBackColor = true;
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
            this.BSalir.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BSalir.ForeColor = System.Drawing.SystemColors.Window;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(814, -12);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(122, 71);
            this.BSalir.TabIndex = 2;
            this.BSalir.Text = "  Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // gbCabecera
            // 
            this.gbCabecera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCabecera.Controls.Add(this.tbObservacion);
            this.gbCabecera.Controls.Add(this.lblObservacion);
            this.gbCabecera.Controls.Add(this.dtpFechaMovimiento);
            this.gbCabecera.Controls.Add(this.lblFecha);
            this.gbCabecera.Controls.Add(this.cbTipoMovimiento);
            this.gbCabecera.Controls.Add(this.lblTipoMovimiento);
            this.gbCabecera.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.gbCabecera.Location = new System.Drawing.Point(12, 55);
            this.gbCabecera.Name = "gbCabecera";
            this.gbCabecera.Size = new System.Drawing.Size(926, 100);
            this.gbCabecera.TabIndex = 2;
            this.gbCabecera.TabStop = false;
            this.gbCabecera.Text = "Datos del Ajuste";
            // 
            // tbObservacion
            // 
            this.tbObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbObservacion.Font = new System.Drawing.Font("Arial", 11F);
            this.tbObservacion.Location = new System.Drawing.Point(544, 32);
            this.tbObservacion.Multiline = true;
            this.tbObservacion.Name = "tbObservacion";
            this.tbObservacion.Size = new System.Drawing.Size(360, 52);
            this.tbObservacion.TabIndex = 5;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(424, 35);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(114, 38);
            this.lblObservacion.TabIndex = 4;
            this.lblObservacion.Text = "Motivo /\r\nObservación:";
            // 
            // dtpFechaMovimiento
            // 
            this.dtpFechaMovimiento.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMovimiento.Location = new System.Drawing.Point(173, 64);
            this.dtpFechaMovimiento.Name = "dtpFechaMovimiento";
            this.dtpFechaMovimiento.Size = new System.Drawing.Size(161, 27);
            this.dtpFechaMovimiento.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(21, 67);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 19);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // cbTipoMovimiento
            // 
            this.cbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMovimiento.Font = new System.Drawing.Font("Arial", 11F);
            this.cbTipoMovimiento.FormattingEnabled = true;
            this.cbTipoMovimiento.Items.AddRange(new object[] {
            "Ajuste de Entrada",
            "Ajuste de Salida"});
            this.cbTipoMovimiento.Location = new System.Drawing.Point(173, 32);
            this.cbTipoMovimiento.Name = "cbTipoMovimiento";
            this.cbTipoMovimiento.Size = new System.Drawing.Size(223, 27);
            this.cbTipoMovimiento.TabIndex = 1;
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Location = new System.Drawing.Point(21, 35);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(126, 19);
            this.lblTipoMovimiento.TabIndex = 0;
            this.lblTipoMovimiento.Text = "Tipo de Ajuste:";
            // 
            // gbDetalle
            // 
            this.gbDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalle.Controls.Add(this.BAgregar);
            this.gbDetalle.Controls.Add(this.tbImporte);
            this.gbDetalle.Controls.Add(this.lblImporte);
            this.gbDetalle.Controls.Add(this.tbCostoUnitario);
            this.gbDetalle.Controls.Add(this.lblCosto);
            this.gbDetalle.Controls.Add(this.tbCantidad);
            this.gbDetalle.Controls.Add(this.lblCantidad);
            this.gbDetalle.Controls.Add(this.tbStockActual);
            this.gbDetalle.Controls.Add(this.lblStock);
            this.gbDetalle.Controls.Add(this.BBuscarProducto);
            this.gbDetalle.Controls.Add(this.tbNombreProducto);
            this.gbDetalle.Controls.Add(this.lblNombreProducto);
            this.gbDetalle.Controls.Add(this.tbIdProducto);
            this.gbDetalle.Controls.Add(this.lblIdProducto);
            this.gbDetalle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.gbDetalle.Location = new System.Drawing.Point(12, 165);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(926, 126);
            this.gbDetalle.TabIndex = 3;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Datos del Producto a Ajustar";
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.BAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregar.ForeColor = System.Drawing.Color.White;
            this.BAgregar.Location = new System.Drawing.Point(804, 76);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(100, 30);
            this.BAgregar.TabIndex = 13;
            this.BAgregar.Text = "&Agregar";
            this.BAgregar.UseVisualStyleBackColor = false;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // tbImporte
            // 
            this.tbImporte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbImporte.Font = new System.Drawing.Font("Arial", 11F);
            this.tbImporte.Location = new System.Drawing.Point(623, 79);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.ReadOnly = true;
            this.tbImporte.Size = new System.Drawing.Size(126, 27);
            this.tbImporte.TabIndex = 12;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(546, 82);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(75, 19);
            this.lblImporte.TabIndex = 11;
            this.lblImporte.Text = "Importe:";
            // 
            // tbCostoUnitario
            // 
            this.tbCostoUnitario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbCostoUnitario.Font = new System.Drawing.Font("Arial", 11F);
            this.tbCostoUnitario.Location = new System.Drawing.Point(395, 79);
            this.tbCostoUnitario.Name = "tbCostoUnitario";
            this.tbCostoUnitario.ReadOnly = true;
            this.tbCostoUnitario.Size = new System.Drawing.Size(126, 27);
            this.tbCostoUnitario.TabIndex = 10;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(267, 82);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(129, 19);
            this.lblCosto.TabIndex = 9;
            this.lblCosto.Text = "Costo Unitario:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Arial", 11F);
            this.tbCantidad.Location = new System.Drawing.Point(103, 79);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(126, 27);
            this.tbCantidad.TabIndex = 8;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            this.tbCantidad.Leave += new System.EventHandler(this.tbCantidad_Leave);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(21, 82);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(85, 19);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // tbStockActual
            // 
            this.tbStockActual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbStockActual.Font = new System.Drawing.Font("Arial", 11F);
            this.tbStockActual.Location = new System.Drawing.Point(804, 30);
            this.tbStockActual.Name = "tbStockActual";
            this.tbStockActual.ReadOnly = true;
            this.tbStockActual.Size = new System.Drawing.Size(100, 27);
            this.tbStockActual.TabIndex = 6;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(694, 33);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(113, 19);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock Actual:";
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarProducto.Location = new System.Drawing.Point(616, 29);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(37, 26);
            this.BBuscarProducto.TabIndex = 4;
            this.BBuscarProducto.Text = "...";
            this.BBuscarProducto.UseVisualStyleBackColor = false;
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNombreProducto.Font = new System.Drawing.Font("Arial", 11F);
            this.tbNombreProducto.Location = new System.Drawing.Point(266, 30);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.ReadOnly = true;
            this.tbNombreProducto.Size = new System.Drawing.Size(345, 27);
            this.tbNombreProducto.TabIndex = 3;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(176, 33);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(88, 19);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Producto:";
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbIdProducto.Font = new System.Drawing.Font("Arial", 11F);
            this.tbIdProducto.Location = new System.Drawing.Point(103, 30);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.ReadOnly = true;
            this.tbIdProducto.Size = new System.Drawing.Size(65, 27);
            this.tbIdProducto.TabIndex = 1;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(21, 33);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(71, 19);
            this.lblIdProducto.TabIndex = 0;
            this.lblIdProducto.Text = "Código:";
            // 
            // DGVDetalle
            // 
            this.DGVDetalle.AllowUserToAddRows = false;
            this.DGVDetalle.AllowUserToDeleteRows = false;
            this.DGVDetalle.AllowUserToResizeRows = false;
            this.DGVDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDetalle.BackgroundColor = System.Drawing.Color.White;
            this.DGVDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDetalle.ColumnHeadersHeight = 40;
            this.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDetalle.EnableHeadersVisualStyles = false;
            this.DGVDetalle.GridColor = System.Drawing.Color.LightGray;
            this.DGVDetalle.Location = new System.Drawing.Point(12, 308);
            this.DGVDetalle.MultiSelect = false;
            this.DGVDetalle.Name = "DGVDetalle";
            this.DGVDetalle.ReadOnly = true;
            this.DGVDetalle.RowHeadersVisible = false;
            this.DGVDetalle.RowHeadersWidth = 47;
            this.DGVDetalle.RowTemplate.Height = 35;
            this.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDetalle.Size = new System.Drawing.Size(926, 215);
            this.DGVDetalle.TabIndex = 4;
            this.DGVDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDetalle_CellContentClick);
            // 
            // lblTextoTotal
            // 
            this.lblTextoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoTotal.AutoSize = true;
            this.lblTextoTotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTextoTotal.Location = new System.Drawing.Point(680, 535);
            this.lblTextoTotal.Name = "lblTextoTotal";
            this.lblTextoTotal.Size = new System.Drawing.Size(99, 30);
            this.lblTextoTotal.TabIndex = 5;
            this.lblTextoTotal.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotal.Location = new System.Drawing.Point(775, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 30);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "0.00";
            // 
            // FInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 620);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTextoTotal);
            this.Controls.Add(this.DGVDetalle);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbCabecera);
            this.Controls.Add(this.PBotones);
            this.Controls.Add(this.PTitulo);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste de Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FInventario_FormClosing);
            this.Load += new System.EventHandler(this.FProcAjusteInventario_Load);
            this.PTitulo.ResumeLayout(false);
            this.PBotones.ResumeLayout(false);
            this.gbCabecera.ResumeLayout(false);
            this.gbCabecera.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel PBotones;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.GroupBox gbCabecera;
        private System.Windows.Forms.ComboBox cbTipoMovimiento;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaMovimiento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox tbObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.TextBox tbNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.TextBox tbStockActual;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox tbCostoUnitario;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.DataGridView DGVDetalle;
        private System.Windows.Forms.Label lblTextoTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}