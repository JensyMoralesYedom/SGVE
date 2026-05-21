namespace CapaPresentacion
{
    partial class FMantProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMantProducto));
            this.PTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PBotones = new System.Windows.Forms.Panel();
            this.BNuevo = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblCostoPorMl = new System.Windows.Forms.Label();
            this.tbCostoPorUnidad = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.tbPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblMililitrosPorUnidad = new System.Windows.Forms.Label();
            this.tbMililitrosPorUnidad = new System.Windows.Forms.TextBox();
            this.lblStockUnidades = new System.Windows.Forms.Label();
            this.tbStockUnidades = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
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
            this.PTitulo.Size = new System.Drawing.Size(980, 56);
            this.PTitulo.TabIndex = 0;
            this.PTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(976, 52);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mantenimiento de Producto";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
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
            this.PBotones.Size = new System.Drawing.Size(980, 60);
            this.PBotones.TabIndex = 1;
            this.PBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.PBotones_Paint);
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
            this.BNuevo.Location = new System.Drawing.Point(-32, 10);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(182, 35);
            this.BNuevo.TabIndex = 0;
            this.BNuevo.Text = "&Nuevo";
            this.BNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BNuevo, "Nuevo Producto");
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
            this.BGuardar.Location = new System.Drawing.Point(69, 11);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(227, 32);
            this.BGuardar.TabIndex = 1;
            this.BGuardar.Text = "&Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BGuardar, "Guardar Cambios");
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
            this.BEditar.Location = new System.Drawing.Point(229, 10);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(181, 35);
            this.BEditar.TabIndex = 2;
            this.BEditar.Text = "&Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BEditar, "Editar Cambios");
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
            this.BSalir.Location = new System.Drawing.Point(820, 0);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(148, 60);
            this.BSalir.TabIndex = 5;
            this.BSalir.Text = "&Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BSalir, "Salir del Formulario");
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
            this.BCancelar.Location = new System.Drawing.Point(313, 10);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(239, 35);
            this.BCancelar.TabIndex = 3;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BCancelar, "Cancelar Cambios");
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
            this.BBuscar.Location = new System.Drawing.Point(240, 87);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(207, 27);
            this.BBuscar.TabIndex = 4;
            this.BBuscar.Text = "&Buscar";
            this.BBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BBuscar, "Buscar Producto");
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblIdProducto.Location = new System.Drawing.Point(30, 90);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(107, 19);
            this.lblIdProducto.TabIndex = 2;
            this.lblIdProducto.Text = "Id Producto:";
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbIdProducto.Font = new System.Drawing.Font("Arial", 11F);
            this.tbIdProducto.Location = new System.Drawing.Point(200, 87);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.ReadOnly = true;
            this.tbIdProducto.Size = new System.Drawing.Size(120, 27);
            this.tbIdProducto.TabIndex = 13;
            this.tbIdProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(500, 90);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 19);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Arial", 11F);
            this.tbCodigo.Location = new System.Drawing.Point(650, 87);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(280, 27);
            this.tbCodigo.TabIndex = 21;
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(30, 160);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial", 11F);
            this.tbNombre.Location = new System.Drawing.Point(200, 157);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(280, 27);
            this.tbNombre.TabIndex = 23;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(500, 160);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(62, 19);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca:";
            // 
            // tbMarca
            // 
            this.tbMarca.Font = new System.Drawing.Font("Arial", 11F);
            this.tbMarca.Location = new System.Drawing.Point(650, 157);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(280, 27);
            this.tbMarca.TabIndex = 22;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(30, 230);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(91, 19);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoría:";
            this.lblCategoria.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Arial", 11F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(200, 227);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(280, 27);
            this.cbCategoria.TabIndex = 24;
            this.toolTip1.SetToolTip(this.cbCategoria, "Selecciona la categoría del producto");
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(500, 230);
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
            this.cbEstado.Location = new System.Drawing.Point(650, 227);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(280, 27);
            this.cbEstado.TabIndex = 25;
            this.toolTip1.SetToolTip(this.cbEstado, "Selecciona el estado del producto");
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // lblCostoPorMl
            // 
            this.lblCostoPorMl.AutoSize = true;
            this.lblCostoPorMl.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblCostoPorMl.Location = new System.Drawing.Point(30, 300);
            this.lblCostoPorMl.Name = "lblCostoPorMl";
            this.lblCostoPorMl.Size = new System.Drawing.Size(154, 19);
            this.lblCostoPorMl.TabIndex = 6;
            this.lblCostoPorMl.Text = "Costo por Unidad:";
            this.lblCostoPorMl.Click += new System.EventHandler(this.lblCostoPorMl_Click);
            // 
            // tbCostoPorUnidad
            // 
            this.tbCostoPorUnidad.Font = new System.Drawing.Font("Arial", 11F);
            this.tbCostoPorUnidad.Location = new System.Drawing.Point(200, 297);
            this.tbCostoPorUnidad.Name = "tbCostoPorUnidad";
            this.tbCostoPorUnidad.Size = new System.Drawing.Size(280, 27);
            this.tbCostoPorUnidad.TabIndex = 15;
            this.tbCostoPorUnidad.TextChanged += new System.EventHandler(this.tbCostoPorUnidad_TextChanged);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrecioVenta.Location = new System.Drawing.Point(500, 300);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(138, 19);
            this.lblPrecioVenta.TabIndex = 8;
            this.lblPrecioVenta.Text = "Precio de Venta:";
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.Font = new System.Drawing.Font("Arial", 11F);
            this.tbPrecioVenta.Location = new System.Drawing.Point(650, 297);
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.Size = new System.Drawing.Size(280, 27);
            this.tbPrecioVenta.TabIndex = 16;
            // 
            // lblMililitrosPorUnidad
            // 
            this.lblMililitrosPorUnidad.AutoSize = true;
            this.lblMililitrosPorUnidad.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblMililitrosPorUnidad.Location = new System.Drawing.Point(30, 370);
            this.lblMililitrosPorUnidad.Name = "lblMililitrosPorUnidad";
            this.lblMililitrosPorUnidad.Size = new System.Drawing.Size(172, 19);
            this.lblMililitrosPorUnidad.TabIndex = 5;
            this.lblMililitrosPorUnidad.Text = "Mililitros por Unidad:";
            this.lblMililitrosPorUnidad.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbMililitrosPorUnidad
            // 
            this.tbMililitrosPorUnidad.Font = new System.Drawing.Font("Arial", 11F);
            this.tbMililitrosPorUnidad.Location = new System.Drawing.Point(200, 367);
            this.tbMililitrosPorUnidad.Name = "tbMililitrosPorUnidad";
            this.tbMililitrosPorUnidad.Size = new System.Drawing.Size(280, 27);
            this.tbMililitrosPorUnidad.TabIndex = 14;
            this.tbMililitrosPorUnidad.TextChanged += new System.EventHandler(this.tbMililitrosPorUnidad_TextChanged);
            // 
            // lblStockUnidades
            // 
            this.lblStockUnidades.AutoSize = true;
            this.lblStockUnidades.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblStockUnidades.Location = new System.Drawing.Point(500, 370);
            this.lblStockUnidades.Name = "lblStockUnidades";
            this.lblStockUnidades.Size = new System.Drawing.Size(150, 19);
            this.lblStockUnidades.TabIndex = 7;
            this.lblStockUnidades.Text = "Stock (Unidades):";
            // 
            // tbStockUnidades
            // 
            this.tbStockUnidades.Font = new System.Drawing.Font("Arial", 11F);
            this.tbStockUnidades.Location = new System.Drawing.Point(650, 367);
            this.tbStockUnidades.Name = "tbStockUnidades";
            this.tbStockUnidades.Size = new System.Drawing.Size(280, 27);
            this.tbStockUnidades.TabIndex = 19;
            this.tbStockUnidades.TextChanged += new System.EventHandler(this.tbStockUnidades_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(30, 440);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 19);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcion.Font = new System.Drawing.Font("Arial", 11F);
            this.tbDescripcion.Location = new System.Drawing.Point(200, 437);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(790, 73);
            this.tbDescripcion.TabIndex = 20;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup_1);
            // 
            // FMantProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.tbIdProducto);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.tbStockUnidades);
            this.Controls.Add(this.lblStockUnidades);
            this.Controls.Add(this.tbMililitrosPorUnidad);
            this.Controls.Add(this.lblMililitrosPorUnidad);
            this.Controls.Add(this.tbPrecioVenta);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.tbCostoPorUnidad);
            this.Controls.Add(this.lblCostoPorMl);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.PBotones);
            this.Controls.Add(this.PTitulo);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMantProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantProducto_FormClosing);
            this.Load += new System.EventHandler(this.MantProducto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MantProducto_KeyDown_1);
            this.PTitulo.ResumeLayout(false);
            this.PBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PBotones;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMililitrosPorUnidad;
        private System.Windows.Forms.Label lblCostoPorMl;
        private System.Windows.Forms.Label lblStockUnidades;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.TextBox tbMililitrosPorUnidad;
        private System.Windows.Forms.TextBox tbCostoPorUnidad;
        private System.Windows.Forms.TextBox tbPrecioVenta;
        private System.Windows.Forms.TextBox tbStockUnidades;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BNuevo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel PTitulo;
    }
}