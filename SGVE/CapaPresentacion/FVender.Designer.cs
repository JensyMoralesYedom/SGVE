namespace CapaPresentacion
{
    partial class FVender
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVender));
            this.PTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbDatosVenta = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.tbTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lbClienteTelefono = new System.Windows.Forms.Label();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.lbClienteApellido = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.lbClienteNombre = new System.Windows.Forms.Label();
            this.lbClienteId = new System.Windows.Forms.Label();
            this.gbMercancia = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblMercancia = new System.Windows.Forms.Label();
            this.tbMercancia = new System.Windows.Forms.TextBox();
            this.lblCantidadProd = new System.Windows.Forms.Label();
            this.tbCantidadProd = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.tbPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblImporteProd = new System.Windows.Forms.Label();
            this.tbImporteProd = new System.Windows.Forms.TextBox();
            this.btnAgregarMercancia = new System.Windows.Forms.Button();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTextoSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTextoItbis = new System.Windows.Forms.Label();
            this.lblItbis = new System.Windows.Forms.Label();
            this.lblTextoTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PTitulo.SuspendLayout();
            this.gbDatosVenta.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbMercancia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // PTitulo
            // 
            this.PTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.PTitulo.Controls.Add(this.lblTitulo);
            this.PTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTitulo.Location = new System.Drawing.Point(0, 0);
            this.PTitulo.Name = "PTitulo";
            this.PTitulo.Size = new System.Drawing.Size(934, 45);
            this.PTitulo.TabIndex = 100;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(934, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Ventas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbDatosVenta
            // 
            this.gbDatosVenta.Controls.Add(this.dtpFecha);
            this.gbDatosVenta.Controls.Add(this.lblFecha);
            this.gbDatosVenta.Controls.Add(this.label4);
            this.gbDatosVenta.Controls.Add(this.radioButton2);
            this.gbDatosVenta.Controls.Add(this.radioButton1);
            this.gbDatosVenta.Controls.Add(this.textBox2);
            this.gbDatosVenta.Controls.Add(this.textBox1);
            this.gbDatosVenta.Controls.Add(this.label3);
            this.gbDatosVenta.Controls.Add(this.label2);
            this.gbDatosVenta.Font = new System.Drawing.Font("Arial", 10F);
            this.gbDatosVenta.Location = new System.Drawing.Point(14, 55);
            this.gbDatosVenta.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbDatosVenta.Name = "gbDatosVenta";
            this.gbDatosVenta.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbDatosVenta.Size = new System.Drawing.Size(461, 145);
            this.gbDatosVenta.TabIndex = 0;
            this.gbDatosVenta.TabStop = false;
            this.gbDatosVenta.Text = "Datos de la Venta";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(290, 26);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 25);
            this.dtpFecha.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(236, 30);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 18);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F);
            this.label4.Location = new System.Drawing.Point(14, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de Venta:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 11F);
            this.radioButton2.Location = new System.Drawing.Point(215, 98);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 23);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Contado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 11F);
            this.radioButton1.Location = new System.Drawing.Point(136, 98);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 23);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "Crédito";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 62);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(344, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(119, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F);
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F);
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Venta #:";
            // 
            // gbCliente
            // 
            this.gbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCliente.Controls.Add(this.tbTelefonoCliente);
            this.gbCliente.Controls.Add(this.lbClienteTelefono);
            this.gbCliente.Controls.Add(this.tbApellidoCliente);
            this.gbCliente.Controls.Add(this.lbClienteApellido);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.tbNombreCliente);
            this.gbCliente.Controls.Add(this.tbIdCliente);
            this.gbCliente.Controls.Add(this.lbClienteNombre);
            this.gbCliente.Controls.Add(this.lbClienteId);
            this.gbCliente.Font = new System.Drawing.Font("Arial", 10F);
            this.gbCliente.Location = new System.Drawing.Point(490, 55);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbCliente.Size = new System.Drawing.Size(430, 145);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // tbTelefonoCliente
            // 
            this.tbTelefonoCliente.Location = new System.Drawing.Point(97, 115);
            this.tbTelefonoCliente.Name = "tbTelefonoCliente";
            this.tbTelefonoCliente.ReadOnly = true;
            this.tbTelefonoCliente.Size = new System.Drawing.Size(150, 25);
            this.tbTelefonoCliente.TabIndex = 9;
            this.tbTelefonoCliente.TabStop = false;
            // 
            // lbClienteTelefono
            // 
            this.lbClienteTelefono.AutoSize = true;
            this.lbClienteTelefono.Font = new System.Drawing.Font("Arial", 11F);
            this.lbClienteTelefono.Location = new System.Drawing.Point(14, 118);
            this.lbClienteTelefono.Name = "lbClienteTelefono";
            this.lbClienteTelefono.Size = new System.Drawing.Size(74, 19);
            this.lbClienteTelefono.TabIndex = 8;
            this.lbClienteTelefono.Text = "Teléfono:";
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Location = new System.Drawing.Point(97, 85);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.ReadOnly = true;
            this.tbApellidoCliente.Size = new System.Drawing.Size(315, 25);
            this.tbApellidoCliente.TabIndex = 7;
            this.tbApellidoCliente.TabStop = false;
            // 
            // lbClienteApellido
            // 
            this.lbClienteApellido.AutoSize = true;
            this.lbClienteApellido.Font = new System.Drawing.Font("Arial", 11F);
            this.lbClienteApellido.Location = new System.Drawing.Point(14, 88);
            this.lbClienteApellido.Name = "lbClienteApellido";
            this.lbClienteApellido.Size = new System.Drawing.Size(79, 19);
            this.lbClienteApellido.TabIndex = 6;
            this.lbClienteApellido.Text = "Apellidos:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(185, 24);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(40, 25);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Location = new System.Drawing.Point(97, 55);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.ReadOnly = true;
            this.tbNombreCliente.Size = new System.Drawing.Size(315, 25);
            this.tbNombreCliente.TabIndex = 4;
            this.tbNombreCliente.TabStop = false;
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Location = new System.Drawing.Point(97, 25);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(80, 25);
            this.tbIdCliente.TabIndex = 3;
            this.tbIdCliente.TextChanged += new System.EventHandler(this.tbIdCliente_TextChanged);
            this.tbIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIdCliente_KeyDown);
            // 
            // lbClienteNombre
            // 
            this.lbClienteNombre.AutoSize = true;
            this.lbClienteNombre.Font = new System.Drawing.Font("Arial", 11F);
            this.lbClienteNombre.Location = new System.Drawing.Point(14, 58);
            this.lbClienteNombre.Name = "lbClienteNombre";
            this.lbClienteNombre.Size = new System.Drawing.Size(79, 19);
            this.lbClienteNombre.TabIndex = 2;
            this.lbClienteNombre.Text = "Nombres:";
            // 
            // lbClienteId
            // 
            this.lbClienteId.AutoSize = true;
            this.lbClienteId.Font = new System.Drawing.Font("Arial", 11F);
            this.lbClienteId.Location = new System.Drawing.Point(14, 28);
            this.lbClienteId.Name = "lbClienteId";
            this.lbClienteId.Size = new System.Drawing.Size(86, 19);
            this.lbClienteId.TabIndex = 1;
            this.lbClienteId.Text = "ID Cliente:";
            // 
            // gbMercancia
            // 
            this.gbMercancia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMercancia.Controls.Add(this.label1);
            this.gbMercancia.Controls.Add(this.tbProducto);
            this.gbMercancia.Controls.Add(this.btnBuscarProducto);
            this.gbMercancia.Controls.Add(this.lblMercancia);
            this.gbMercancia.Controls.Add(this.tbMercancia);
            this.gbMercancia.Controls.Add(this.lblCantidadProd);
            this.gbMercancia.Controls.Add(this.tbCantidadProd);
            this.gbMercancia.Controls.Add(this.lblPrecioVenta);
            this.gbMercancia.Controls.Add(this.tbPrecioVenta);
            this.gbMercancia.Controls.Add(this.lblImporteProd);
            this.gbMercancia.Controls.Add(this.tbImporteProd);
            this.gbMercancia.Controls.Add(this.btnAgregarMercancia);
            this.gbMercancia.Location = new System.Drawing.Point(14, 210);
            this.gbMercancia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbMercancia.Name = "gbMercancia";
            this.gbMercancia.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbMercancia.Size = new System.Drawing.Size(905, 90);
            this.gbMercancia.TabIndex = 2;
            this.gbMercancia.TabStop = false;
            this.gbMercancia.Text = "Mercancía";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código";
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(14, 47);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(114, 25);
            this.tbProducto.TabIndex = 7;
            this.tbProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProducto_KeyDown_1);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBuscarProducto.Location = new System.Drawing.Point(132, 49);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(30, 25);
            this.btnBuscarProducto.TabIndex = 9;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblMercancia
            // 
            this.lblMercancia.AutoSize = true;
            this.lblMercancia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMercancia.Location = new System.Drawing.Point(164, 27);
            this.lblMercancia.Name = "lblMercancia";
            this.lblMercancia.Size = new System.Drawing.Size(87, 19);
            this.lblMercancia.TabIndex = 10;
            this.lblMercancia.Text = "Mercancía";
            // 
            // tbMercancia
            // 
            this.tbMercancia.Location = new System.Drawing.Point(168, 49);
            this.tbMercancia.Name = "tbMercancia";
            this.tbMercancia.ReadOnly = true;
            this.tbMercancia.Size = new System.Drawing.Size(198, 25);
            this.tbMercancia.TabIndex = 11;
            // 
            // lblCantidadProd
            // 
            this.lblCantidadProd.AutoSize = true;
            this.lblCantidadProd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblCantidadProd.Location = new System.Drawing.Point(383, 27);
            this.lblCantidadProd.Name = "lblCantidadProd";
            this.lblCantidadProd.Size = new System.Drawing.Size(78, 19);
            this.lblCantidadProd.TabIndex = 12;
            this.lblCantidadProd.Text = "Cantidad";
            // 
            // tbCantidadProd
            // 
            this.tbCantidadProd.Location = new System.Drawing.Point(382, 49);
            this.tbCantidadProd.Name = "tbCantidadProd";
            this.tbCantidadProd.Size = new System.Drawing.Size(79, 25);
            this.tbCantidadProd.TabIndex = 13;
            this.tbCantidadProd.TextChanged += new System.EventHandler(this.tbCantidadProd_TextChanged);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecioVenta.Location = new System.Drawing.Point(474, 27);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(105, 19);
            this.lblPrecioVenta.TabIndex = 14;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.Location = new System.Drawing.Point(476, 49);
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.ReadOnly = true;
            this.tbPrecioVenta.Size = new System.Drawing.Size(126, 25);
            this.tbPrecioVenta.TabIndex = 15;
            // 
            // lblImporteProd
            // 
            this.lblImporteProd.AutoSize = true;
            this.lblImporteProd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblImporteProd.Location = new System.Drawing.Point(630, 27);
            this.lblImporteProd.Name = "lblImporteProd";
            this.lblImporteProd.Size = new System.Drawing.Size(67, 19);
            this.lblImporteProd.TabIndex = 16;
            this.lblImporteProd.Text = "Importe";
            // 
            // tbImporteProd
            // 
            this.tbImporteProd.Location = new System.Drawing.Point(629, 49);
            this.tbImporteProd.Name = "tbImporteProd";
            this.tbImporteProd.ReadOnly = true;
            this.tbImporteProd.Size = new System.Drawing.Size(133, 25);
            this.tbImporteProd.TabIndex = 17;
            // 
            // btnAgregarMercancia
            // 
            this.btnAgregarMercancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMercancia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarMercancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnAgregarMercancia.Location = new System.Drawing.Point(785, 47);
            this.btnAgregarMercancia.Name = "btnAgregarMercancia";
            this.btnAgregarMercancia.Size = new System.Drawing.Size(100, 27);
            this.btnAgregarMercancia.TabIndex = 18;
            this.btnAgregarMercancia.Text = "Agregar";
            this.btnAgregarMercancia.UseVisualStyleBackColor = true;
            this.btnAgregarMercancia.Click += new System.EventHandler(this.btnAgregarMercancia_Click);
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.AllowUserToDeleteRows = false;
            this.dgDetalle.AllowUserToResizeRows = false;
            this.dgDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetalle.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetalle.ColumnHeadersHeight = 40;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetalle.EnableHeadersVisualStyles = false;
            this.dgDetalle.GridColor = System.Drawing.Color.LightGray;
            this.dgDetalle.Location = new System.Drawing.Point(14, 342);
            this.dgDetalle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.ReadOnly = true;
            this.dgDetalle.RowHeadersVisible = false;
            this.dgDetalle.RowHeadersWidth = 47;
            this.dgDetalle.RowTemplate.Height = 35;
            this.dgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalle.Size = new System.Drawing.Size(905, 158);
            this.dgDetalle.TabIndex = 3;
            this.dgDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnFacturar);
            this.panelBottom.Controls.Add(this.btnCancelar);
            this.panelBottom.Controls.Add(this.btnSalir);
            this.panelBottom.Controls.Add(this.lblTextoSubtotal);
            this.panelBottom.Controls.Add(this.lblSubtotal);
            this.panelBottom.Controls.Add(this.lblTextoItbis);
            this.panelBottom.Controls.Add(this.lblItbis);
            this.panelBottom.Controls.Add(this.lblTextoTotal);
            this.panelBottom.Controls.Add(this.lblTotal);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 516);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(934, 130);
            this.panelBottom.TabIndex = 4;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFacturar.BackgroundImage")));
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnFacturar.ForeColor = System.Drawing.Color.Black;
            this.btnFacturar.Location = new System.Drawing.Point(-71, 35);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(229, 46);
            this.btnFacturar.TabIndex = 9;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(74, 35);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(231, 45);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(242, 35);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(167, 45);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTextoSubtotal
            // 
            this.lblTextoSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoSubtotal.AutoSize = true;
            this.lblTextoSubtotal.Font = new System.Drawing.Font("Arial", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSubtotal.Location = new System.Drawing.Point(620, 15);
            this.lblTextoSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoSubtotal.Name = "lblTextoSubtotal";
            this.lblTextoSubtotal.Size = new System.Drawing.Size(94, 22);
            this.lblTextoSubtotal.TabIndex = 12;
            this.lblTextoSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSubtotal.Location = new System.Drawing.Point(730, 15);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 22);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "$ 0.00";
            // 
            // lblTextoItbis
            // 
            this.lblTextoItbis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoItbis.AutoSize = true;
            this.lblTextoItbis.Font = new System.Drawing.Font("Arial", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoItbis.Location = new System.Drawing.Point(620, 47);
            this.lblTextoItbis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoItbis.Name = "lblTextoItbis";
            this.lblTextoItbis.Size = new System.Drawing.Size(111, 22);
            this.lblTextoItbis.TabIndex = 14;
            this.lblTextoItbis.Text = "18% ITBIS:";
            // 
            // lblItbis
            // 
            this.lblItbis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItbis.AutoSize = true;
            this.lblItbis.Font = new System.Drawing.Font("Arial", 12F);
            this.lblItbis.Location = new System.Drawing.Point(730, 47);
            this.lblItbis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItbis.Name = "lblItbis";
            this.lblItbis.Size = new System.Drawing.Size(64, 22);
            this.lblItbis.TabIndex = 15;
            this.lblItbis.Text = "$ 0.00";
            // 
            // lblTextoTotal
            // 
            this.lblTextoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoTotal.AutoSize = true;
            this.lblTextoTotal.Font = new System.Drawing.Font("Arial", 18.32727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoTotal.Location = new System.Drawing.Point(620, 81);
            this.lblTextoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoTotal.Name = "lblTextoTotal";
            this.lblTextoTotal.Size = new System.Drawing.Size(115, 33);
            this.lblTextoTotal.TabIndex = 10;
            this.lblTextoTotal.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(730, 79);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 37);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "$ 0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.70909F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "DETALLE  DE LA  VENTA";
            // 
            // FVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 646);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgDetalle);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.gbMercancia);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbDatosVenta);
            this.Controls.Add(this.PTitulo);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FVender_FormClosing);
            this.Load += new System.EventHandler(this.FVender_Load);
            this.PTitulo.ResumeLayout(false);
            this.gbDatosVenta.ResumeLayout(false);
            this.gbDatosVenta.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbMercancia.ResumeLayout(false);
            this.gbMercancia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatosVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.Label lbClienteNombre;
        private System.Windows.Forms.Label lbClienteId;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lbClienteApellido;
        private System.Windows.Forms.TextBox tbApellidoCliente;
        private System.Windows.Forms.Label lbClienteTelefono;
        private System.Windows.Forms.TextBox tbTelefonoCliente;
        private System.Windows.Forms.GroupBox gbMercancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblMercancia;
        private System.Windows.Forms.TextBox tbMercancia;
        private System.Windows.Forms.Label lblCantidadProd;
        private System.Windows.Forms.TextBox tbCantidadProd;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox tbPrecioVenta;
        private System.Windows.Forms.Label lblImporteProd;
        private System.Windows.Forms.TextBox tbImporteProd;
        private System.Windows.Forms.Button btnAgregarMercancia;
        private System.Windows.Forms.DataGridView dgDetalle;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label lblTextoSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTextoItbis;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label lblTextoTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
    }
}