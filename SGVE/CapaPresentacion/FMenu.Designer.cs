namespace CapaPresentacion
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.P_Titulo_Logo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bHamburguesa = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.bAcercaDe = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.pConsultasReportes = new System.Windows.Forms.Panel();
            this.bMaestroDetalle = new System.Windows.Forms.Button();
            this.bConsultaCategoria = new System.Windows.Forms.Button();
            this.bConsultaProducto = new System.Windows.Forms.Button();
            this.bConsultaUsuario = new System.Windows.Forms.Button();
            this.bConsultaProveedor = new System.Windows.Forms.Button();
            this.bConsultaCliente = new System.Windows.Forms.Button();
            this.bConsultasReportes = new System.Windows.Forms.Button();
            this.pProcesos = new System.Windows.Forms.Panel();
            this.bAjusteInventario = new System.Windows.Forms.Button();
            this.bVenta = new System.Windows.Forms.Button();
            this.bProcesos = new System.Windows.Forms.Button();
            this.pMantenimiento = new System.Windows.Forms.Panel();
            this.bCategoria = new System.Windows.Forms.Button();
            this.bMantProducto = new System.Windows.Forms.Button();
            this.bMantUsuario = new System.Windows.Forms.Button();
            this.bMantProveedor = new System.Windows.Forms.Button();
            this.bMantCLiente = new System.Windows.Forms.Button();
            this.bMantenimiento = new System.Windows.Forms.Button();
            this.ImagenBienvenida = new System.Windows.Forms.PictureBox();
            this.timerAnimacion = new System.Windows.Forms.Timer(this.components);
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.P_Titulo_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pConsultasReportes.SuspendLayout();
            this.pProcesos.SuspendLayout();
            this.pMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenBienvenida)).BeginInit();
            this.SuspendLayout();
            // 
            // P_Titulo_Logo
            // 
            this.P_Titulo_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.P_Titulo_Logo.Controls.Add(this.pictureBox2);
            this.P_Titulo_Logo.Controls.Add(this.bHamburguesa);
            this.P_Titulo_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Titulo_Logo.Location = new System.Drawing.Point(0, 0);
            this.P_Titulo_Logo.Name = "P_Titulo_Logo";
            this.P_Titulo_Logo.Size = new System.Drawing.Size(876, 53);
            this.P_Titulo_Logo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(58, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Size = new System.Drawing.Size(86, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bHamburguesa
            // 
            this.bHamburguesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bHamburguesa.BackgroundImage")));
            this.bHamburguesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bHamburguesa.FlatAppearance.BorderSize = 0;
            this.bHamburguesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHamburguesa.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bHamburguesa.Location = new System.Drawing.Point(3, 9);
            this.bHamburguesa.Name = "bHamburguesa";
            this.bHamburguesa.Size = new System.Drawing.Size(38, 38);
            this.bHamburguesa.TabIndex = 0;
            this.bHamburguesa.UseVisualStyleBackColor = true;
            this.bHamburguesa.Click += new System.EventHandler(this.bHamburguesa_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.bAcercaDe);
            this.splitContainer1.Panel1.Controls.Add(this.bDashboard);
            this.splitContainer1.Panel1.Controls.Add(this.pConsultasReportes);
            this.splitContainer1.Panel1.Controls.Add(this.bConsultasReportes);
            this.splitContainer1.Panel1.Controls.Add(this.pProcesos);
            this.splitContainer1.Panel1.Controls.Add(this.bProcesos);
            this.splitContainer1.Panel1.Controls.Add(this.pMantenimiento);
            this.splitContainer1.Panel1.Controls.Add(this.bMantenimiento);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Panel2.Controls.Add(this.ImagenBienvenida);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(876, 677);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel1.Location = new System.Drawing.Point(0, 596);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 81);
            this.panel1.TabIndex = 6;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Arial", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(54, 24);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(79, 16);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Yedom_31";
            // 
            // bAcercaDe
            // 
            this.bAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.bAcercaDe.FlatAppearance.BorderSize = 0;
            this.bAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAcercaDe.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAcercaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.bAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("bAcercaDe.Image")));
            this.bAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAcercaDe.Location = new System.Drawing.Point(0, 570);
            this.bAcercaDe.Name = "bAcercaDe";
            this.bAcercaDe.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bAcercaDe.Size = new System.Drawing.Size(235, 45);
            this.bAcercaDe.TabIndex = 7;
            this.bAcercaDe.Text = "  Acerca de...";
            this.bAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAcercaDe.UseVisualStyleBackColor = false;
            this.bAcercaDe.Click += new System.EventHandler(this.bAcercaDe_Click);
            this.bAcercaDe.MouseEnter += new System.EventHandler(this.bAcercaDe_MouseEnter);
            this.bAcercaDe.MouseLeave += new System.EventHandler(this.bAcercaDe_MouseLeave);
            // 
            // bDashboard
            // 
            this.bDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDashboard.FlatAppearance.BorderSize = 0;
            this.bDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDashboard.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.bDashboard.Image = ((System.Drawing.Image)(resources.GetObject("bDashboard.Image")));
            this.bDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDashboard.Location = new System.Drawing.Point(0, 525);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bDashboard.Size = new System.Drawing.Size(235, 45);
            this.bDashboard.TabIndex = 8;
            this.bDashboard.Text = "  Dashboard";
            this.bDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDashboard.UseVisualStyleBackColor = false;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            this.bDashboard.MouseEnter += new System.EventHandler(this.bDashboard_MouseEnter);
            this.bDashboard.MouseLeave += new System.EventHandler(this.bDashboard_MouseLeave);
            // 
            // pConsultasReportes
            // 
            this.pConsultasReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.pConsultasReportes.Controls.Add(this.bMaestroDetalle);
            this.pConsultasReportes.Controls.Add(this.bConsultaCategoria);
            this.pConsultasReportes.Controls.Add(this.bConsultaProducto);
            this.pConsultasReportes.Controls.Add(this.bConsultaUsuario);
            this.pConsultasReportes.Controls.Add(this.bConsultaProveedor);
            this.pConsultasReportes.Controls.Add(this.bConsultaCliente);
            this.pConsultasReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pConsultasReportes.Location = new System.Drawing.Point(0, 345);
            this.pConsultasReportes.Name = "pConsultasReportes";
            this.pConsultasReportes.Size = new System.Drawing.Size(235, 180);
            this.pConsultasReportes.TabIndex = 5;
            // 
            // bMaestroDetalle
            // 
            this.bMaestroDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bMaestroDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.bMaestroDetalle.FlatAppearance.BorderSize = 0;
            this.bMaestroDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMaestroDetalle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMaestroDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bMaestroDetalle.Image = ((System.Drawing.Image)(resources.GetObject("bMaestroDetalle.Image")));
            this.bMaestroDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMaestroDetalle.Location = new System.Drawing.Point(0, 150);
            this.bMaestroDetalle.Name = "bMaestroDetalle";
            this.bMaestroDetalle.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bMaestroDetalle.Size = new System.Drawing.Size(235, 30);
            this.bMaestroDetalle.TabIndex = 9;
            this.bMaestroDetalle.Text = " Maestro Detalle";
            this.bMaestroDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMaestroDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMaestroDetalle.UseVisualStyleBackColor = false;
            this.bMaestroDetalle.Click += new System.EventHandler(this.bMaestroDetalle_Click);
            this.bMaestroDetalle.MouseEnter += new System.EventHandler(this.bMaestroDetalle_MouseEnter);
            this.bMaestroDetalle.MouseLeave += new System.EventHandler(this.bMaestroDetalle_MouseLeave);
            // 
            // bConsultaCategoria
            // 
            this.bConsultaCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bConsultaCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.bConsultaCategoria.FlatAppearance.BorderSize = 0;
            this.bConsultaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsultaCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultaCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bConsultaCategoria.Image = ((System.Drawing.Image)(resources.GetObject("bConsultaCategoria.Image")));
            this.bConsultaCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultaCategoria.Location = new System.Drawing.Point(0, 120);
            this.bConsultaCategoria.Name = "bConsultaCategoria";
            this.bConsultaCategoria.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bConsultaCategoria.Size = new System.Drawing.Size(235, 30);
            this.bConsultaCategoria.TabIndex = 8;
            this.bConsultaCategoria.Text = " Categorias";
            this.bConsultaCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultaCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bConsultaCategoria.UseVisualStyleBackColor = false;
            this.bConsultaCategoria.Click += new System.EventHandler(this.bConsultaCategoria_Click);
            this.bConsultaCategoria.MouseEnter += new System.EventHandler(this.bConsultaCategoria_MouseEnter);
            this.bConsultaCategoria.MouseLeave += new System.EventHandler(this.bConsultaCategoria_MouseLeave);
            // 
            // bConsultaProducto
            // 
            this.bConsultaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bConsultaProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.bConsultaProducto.FlatAppearance.BorderSize = 0;
            this.bConsultaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsultaProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bConsultaProducto.Image = ((System.Drawing.Image)(resources.GetObject("bConsultaProducto.Image")));
            this.bConsultaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultaProducto.Location = new System.Drawing.Point(0, 90);
            this.bConsultaProducto.Name = "bConsultaProducto";
            this.bConsultaProducto.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bConsultaProducto.Size = new System.Drawing.Size(235, 30);
            this.bConsultaProducto.TabIndex = 7;
            this.bConsultaProducto.Text = " Productos";
            this.bConsultaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultaProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bConsultaProducto.UseVisualStyleBackColor = false;
            this.bConsultaProducto.Click += new System.EventHandler(this.bConsultaProducto_Click);
            this.bConsultaProducto.MouseEnter += new System.EventHandler(this.bConsultaProducto_MouseEnter);
            this.bConsultaProducto.MouseLeave += new System.EventHandler(this.bConsultaProducto_MouseLeave);
            // 
            // bConsultaUsuario
            // 
            this.bConsultaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bConsultaUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.bConsultaUsuario.FlatAppearance.BorderSize = 0;
            this.bConsultaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsultaUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bConsultaUsuario.Image = ((System.Drawing.Image)(resources.GetObject("bConsultaUsuario.Image")));
            this.bConsultaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultaUsuario.Location = new System.Drawing.Point(0, 60);
            this.bConsultaUsuario.Name = "bConsultaUsuario";
            this.bConsultaUsuario.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bConsultaUsuario.Size = new System.Drawing.Size(235, 30);
            this.bConsultaUsuario.TabIndex = 6;
            this.bConsultaUsuario.Text = " Usuarios";
            this.bConsultaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultaUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bConsultaUsuario.UseVisualStyleBackColor = false;
            this.bConsultaUsuario.Click += new System.EventHandler(this.bConsultaUsuario_Click);
            this.bConsultaUsuario.MouseEnter += new System.EventHandler(this.bConsultaUsuario_MouseEnter);
            this.bConsultaUsuario.MouseLeave += new System.EventHandler(this.bConsultaUsuario_MouseLeave);
            // 
            // bConsultaProveedor
            // 
            this.bConsultaProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bConsultaProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.bConsultaProveedor.FlatAppearance.BorderSize = 0;
            this.bConsultaProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsultaProveedor.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultaProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bConsultaProveedor.Image = ((System.Drawing.Image)(resources.GetObject("bConsultaProveedor.Image")));
            this.bConsultaProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultaProveedor.Location = new System.Drawing.Point(0, 30);
            this.bConsultaProveedor.Name = "bConsultaProveedor";
            this.bConsultaProveedor.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bConsultaProveedor.Size = new System.Drawing.Size(235, 30);
            this.bConsultaProveedor.TabIndex = 5;
            this.bConsultaProveedor.Text = " Proveedores";
            this.bConsultaProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultaProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bConsultaProveedor.UseVisualStyleBackColor = false;
            this.bConsultaProveedor.Click += new System.EventHandler(this.bConsultaProveedor_Click);
            this.bConsultaProveedor.MouseEnter += new System.EventHandler(this.bConsultaProveedor_MouseEnter);
            this.bConsultaProveedor.MouseLeave += new System.EventHandler(this.bConsultaProveedor_MouseLeave);
            // 
            // bConsultaCliente
            // 
            this.bConsultaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bConsultaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.bConsultaCliente.FlatAppearance.BorderSize = 0;
            this.bConsultaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsultaCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bConsultaCliente.Image = ((System.Drawing.Image)(resources.GetObject("bConsultaCliente.Image")));
            this.bConsultaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultaCliente.Location = new System.Drawing.Point(0, 0);
            this.bConsultaCliente.Name = "bConsultaCliente";
            this.bConsultaCliente.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bConsultaCliente.Size = new System.Drawing.Size(235, 30);
            this.bConsultaCliente.TabIndex = 4;
            this.bConsultaCliente.Text = " Clientes";
            this.bConsultaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bConsultaCliente.UseVisualStyleBackColor = false;
            this.bConsultaCliente.Click += new System.EventHandler(this.bConsultaCliente_Click);
            this.bConsultaCliente.MouseEnter += new System.EventHandler(this.bConsultaCliente_MouseEnter);
            this.bConsultaCliente.MouseLeave += new System.EventHandler(this.bConsultaCliente_MouseLeave);
            // 
            // bConsultasReportes
            // 
            this.bConsultasReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bConsultasReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.bConsultasReportes.FlatAppearance.BorderSize = 0;
            this.bConsultasReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsultasReportes.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultasReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.bConsultasReportes.Image = ((System.Drawing.Image)(resources.GetObject("bConsultasReportes.Image")));
            this.bConsultasReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultasReportes.Location = new System.Drawing.Point(0, 300);
            this.bConsultasReportes.Name = "bConsultasReportes";
            this.bConsultasReportes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bConsultasReportes.Size = new System.Drawing.Size(235, 45);
            this.bConsultasReportes.TabIndex = 4;
            this.bConsultasReportes.Text = "  Consultas y Reportes";
            this.bConsultasReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultasReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bConsultasReportes.UseVisualStyleBackColor = false;
            this.bConsultasReportes.Click += new System.EventHandler(this.bConsultasReportes_Click);
            this.bConsultasReportes.MouseEnter += new System.EventHandler(this.bConsultasReportes_MouseEnter);
            this.bConsultasReportes.MouseLeave += new System.EventHandler(this.bConsultasReportes_MouseLeave);
            // 
            // pProcesos
            // 
            this.pProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.pProcesos.Controls.Add(this.bAjusteInventario);
            this.pProcesos.Controls.Add(this.bVenta);
            this.pProcesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pProcesos.Location = new System.Drawing.Point(0, 240);
            this.pProcesos.Name = "pProcesos";
            this.pProcesos.Size = new System.Drawing.Size(235, 60);
            this.pProcesos.TabIndex = 3;
            // 
            // bAjusteInventario
            // 
            this.bAjusteInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bAjusteInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.bAjusteInventario.FlatAppearance.BorderSize = 0;
            this.bAjusteInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAjusteInventario.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAjusteInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bAjusteInventario.Image = ((System.Drawing.Image)(resources.GetObject("bAjusteInventario.Image")));
            this.bAjusteInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAjusteInventario.Location = new System.Drawing.Point(0, 30);
            this.bAjusteInventario.Name = "bAjusteInventario";
            this.bAjusteInventario.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bAjusteInventario.Size = new System.Drawing.Size(235, 30);
            this.bAjusteInventario.TabIndex = 2;
            this.bAjusteInventario.Text = " Ajustar Inventario";
            this.bAjusteInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAjusteInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAjusteInventario.UseVisualStyleBackColor = false;
            this.bAjusteInventario.Click += new System.EventHandler(this.bAjusteInventario_Click);
            this.bAjusteInventario.MouseEnter += new System.EventHandler(this.bAjusteInventario_MouseEnter);
            this.bAjusteInventario.MouseLeave += new System.EventHandler(this.bAjusteInventario_MouseLeave);
            // 
            // bVenta
            // 
            this.bVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.bVenta.FlatAppearance.BorderSize = 0;
            this.bVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVenta.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bVenta.Image = ((System.Drawing.Image)(resources.GetObject("bVenta.Image")));
            this.bVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVenta.Location = new System.Drawing.Point(0, 0);
            this.bVenta.Name = "bVenta";
            this.bVenta.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bVenta.Size = new System.Drawing.Size(235, 30);
            this.bVenta.TabIndex = 1;
            this.bVenta.Text = " Registrar Venta";
            this.bVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bVenta.UseVisualStyleBackColor = false;
            this.bVenta.Click += new System.EventHandler(this.bVenta_Click);
            this.bVenta.MouseEnter += new System.EventHandler(this.bVenta_MouseEnter);
            this.bVenta.MouseLeave += new System.EventHandler(this.bVenta_MouseLeave);
            // 
            // bProcesos
            // 
            this.bProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bProcesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bProcesos.FlatAppearance.BorderSize = 0;
            this.bProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProcesos.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProcesos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.bProcesos.Image = ((System.Drawing.Image)(resources.GetObject("bProcesos.Image")));
            this.bProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bProcesos.Location = new System.Drawing.Point(0, 195);
            this.bProcesos.Name = "bProcesos";
            this.bProcesos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bProcesos.Size = new System.Drawing.Size(235, 45);
            this.bProcesos.TabIndex = 2;
            this.bProcesos.Text = "  Procesos";
            this.bProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bProcesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bProcesos.UseVisualStyleBackColor = false;
            this.bProcesos.Click += new System.EventHandler(this.bProcesos_Click);
            this.bProcesos.MouseEnter += new System.EventHandler(this.bProcesos_MouseEnter);
            this.bProcesos.MouseLeave += new System.EventHandler(this.bProcesos_MouseLeave);
            // 
            // pMantenimiento
            // 
            this.pMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.pMantenimiento.Controls.Add(this.bCategoria);
            this.pMantenimiento.Controls.Add(this.bMantProducto);
            this.pMantenimiento.Controls.Add(this.bMantUsuario);
            this.pMantenimiento.Controls.Add(this.bMantProveedor);
            this.pMantenimiento.Controls.Add(this.bMantCLiente);
            this.pMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMantenimiento.Location = new System.Drawing.Point(0, 45);
            this.pMantenimiento.Name = "pMantenimiento";
            this.pMantenimiento.Size = new System.Drawing.Size(235, 150);
            this.pMantenimiento.TabIndex = 1;
            // 
            // bCategoria
            // 
            this.bCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.bCategoria.FlatAppearance.BorderSize = 0;
            this.bCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bCategoria.Image = ((System.Drawing.Image)(resources.GetObject("bCategoria.Image")));
            this.bCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCategoria.Location = new System.Drawing.Point(0, 120);
            this.bCategoria.Name = "bCategoria";
            this.bCategoria.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bCategoria.Size = new System.Drawing.Size(235, 30);
            this.bCategoria.TabIndex = 4;
            this.bCategoria.Text = " Categorias";
            this.bCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCategoria.UseVisualStyleBackColor = false;
            this.bCategoria.Click += new System.EventHandler(this.bCategoria_Click);
            this.bCategoria.MouseEnter += new System.EventHandler(this.bCategoria_MouseEnter);
            this.bCategoria.MouseLeave += new System.EventHandler(this.bCategoria_MouseLeave);
            // 
            // bMantProducto
            // 
            this.bMantProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bMantProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.bMantProducto.FlatAppearance.BorderSize = 0;
            this.bMantProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMantProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMantProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bMantProducto.Image = ((System.Drawing.Image)(resources.GetObject("bMantProducto.Image")));
            this.bMantProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMantProducto.Location = new System.Drawing.Point(0, 90);
            this.bMantProducto.Name = "bMantProducto";
            this.bMantProducto.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bMantProducto.Size = new System.Drawing.Size(235, 30);
            this.bMantProducto.TabIndex = 3;
            this.bMantProducto.Text = " Productos";
            this.bMantProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMantProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMantProducto.UseVisualStyleBackColor = false;
            this.bMantProducto.Click += new System.EventHandler(this.bMantProducto_Click);
            this.bMantProducto.MouseEnter += new System.EventHandler(this.bMantProducto_MouseEnter);
            this.bMantProducto.MouseLeave += new System.EventHandler(this.bMantProducto_MouseLeave);
            // 
            // bMantUsuario
            // 
            this.bMantUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bMantUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.bMantUsuario.FlatAppearance.BorderSize = 0;
            this.bMantUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMantUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMantUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bMantUsuario.Image = ((System.Drawing.Image)(resources.GetObject("bMantUsuario.Image")));
            this.bMantUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMantUsuario.Location = new System.Drawing.Point(0, 60);
            this.bMantUsuario.Name = "bMantUsuario";
            this.bMantUsuario.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bMantUsuario.Size = new System.Drawing.Size(235, 30);
            this.bMantUsuario.TabIndex = 2;
            this.bMantUsuario.Text = " Usuarios";
            this.bMantUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMantUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMantUsuario.UseVisualStyleBackColor = false;
            this.bMantUsuario.Click += new System.EventHandler(this.bMantUsuario_Click);
            this.bMantUsuario.MouseEnter += new System.EventHandler(this.bMantUsuario_MouseEnter);
            this.bMantUsuario.MouseLeave += new System.EventHandler(this.bMantUsuario_MouseLeave);
            // 
            // bMantProveedor
            // 
            this.bMantProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bMantProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.bMantProveedor.FlatAppearance.BorderSize = 0;
            this.bMantProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMantProveedor.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMantProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bMantProveedor.Image = ((System.Drawing.Image)(resources.GetObject("bMantProveedor.Image")));
            this.bMantProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMantProveedor.Location = new System.Drawing.Point(0, 30);
            this.bMantProveedor.Name = "bMantProveedor";
            this.bMantProveedor.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bMantProveedor.Size = new System.Drawing.Size(235, 30);
            this.bMantProveedor.TabIndex = 1;
            this.bMantProveedor.Text = " Proveedores";
            this.bMantProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMantProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMantProveedor.UseVisualStyleBackColor = false;
            this.bMantProveedor.Click += new System.EventHandler(this.bMantProveedor_Click);
            this.bMantProveedor.MouseEnter += new System.EventHandler(this.bMantProveedor_MouseEnter);
            this.bMantProveedor.MouseLeave += new System.EventHandler(this.bMantProveedor_MouseLeave);
            // 
            // bMantCLiente
            // 
            this.bMantCLiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bMantCLiente.Dock = System.Windows.Forms.DockStyle.Top;
            this.bMantCLiente.FlatAppearance.BorderSize = 0;
            this.bMantCLiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMantCLiente.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMantCLiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(176)))));
            this.bMantCLiente.Image = ((System.Drawing.Image)(resources.GetObject("bMantCLiente.Image")));
            this.bMantCLiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMantCLiente.Location = new System.Drawing.Point(0, 0);
            this.bMantCLiente.Name = "bMantCLiente";
            this.bMantCLiente.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bMantCLiente.Size = new System.Drawing.Size(235, 30);
            this.bMantCLiente.TabIndex = 0;
            this.bMantCLiente.Text = " Clientes";
            this.bMantCLiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMantCLiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMantCLiente.UseVisualStyleBackColor = false;
            this.bMantCLiente.Click += new System.EventHandler(this.bMantCLiente_Click);
            this.bMantCLiente.MouseEnter += new System.EventHandler(this.bMantCLiente_MouseEnter);
            this.bMantCLiente.MouseLeave += new System.EventHandler(this.bMantCLiente_MouseLeave);
            // 
            // bMantenimiento
            // 
            this.bMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.bMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.bMantenimiento.FlatAppearance.BorderSize = 0;
            this.bMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMantenimiento.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.bMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("bMantenimiento.Image")));
            this.bMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.bMantenimiento.Name = "bMantenimiento";
            this.bMantenimiento.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bMantenimiento.Size = new System.Drawing.Size(235, 45);
            this.bMantenimiento.TabIndex = 0;
            this.bMantenimiento.Text = "  Mantenimientos";
            this.bMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMantenimiento.UseVisualStyleBackColor = false;
            this.bMantenimiento.Click += new System.EventHandler(this.bMantenimiento_Click);
            this.bMantenimiento.MouseEnter += new System.EventHandler(this.bMantenimiento_MouseEnter);
            this.bMantenimiento.MouseLeave += new System.EventHandler(this.bMantenimiento_MouseLeave);
            // 
            // ImagenBienvenida
            // 
            this.ImagenBienvenida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagenBienvenida.BackgroundImage")));
            this.ImagenBienvenida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagenBienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagenBienvenida.Location = new System.Drawing.Point(0, 0);
            this.ImagenBienvenida.Name = "ImagenBienvenida";
            this.ImagenBienvenida.Size = new System.Drawing.Size(637, 677);
            this.ImagenBienvenida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenBienvenida.TabIndex = 0;
            this.ImagenBienvenida.TabStop = false;
            this.ImagenBienvenida.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerAnimacion
            // 
            this.timerAnimacion.Interval = 10;
            this.timerAnimacion.Tick += new System.EventHandler(this.timerAnimacion_Tick);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 10;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 730);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.P_Titulo_Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMenu";
            this.Text = "FMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMenu_FormClosing);
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.P_Titulo_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pConsultasReportes.ResumeLayout(false);
            this.pProcesos.ResumeLayout(false);
            this.pMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenBienvenida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_Titulo_Logo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pMantenimiento;
        private System.Windows.Forms.Button bMantenimiento;
        private System.Windows.Forms.Button bMantProducto;
        private System.Windows.Forms.Button bMantUsuario;
        private System.Windows.Forms.Button bMantProveedor;
        private System.Windows.Forms.Button bMantCLiente;
        private System.Windows.Forms.Button bProcesos;
        private System.Windows.Forms.Panel pProcesos;
        private System.Windows.Forms.Button bAjusteInventario;
        private System.Windows.Forms.Button bVenta;
        private System.Windows.Forms.Timer timerAnimacion;
        private System.Windows.Forms.Button bConsultasReportes;
        private System.Windows.Forms.Panel pConsultasReportes;
        private System.Windows.Forms.Button bConsultaProducto;
        private System.Windows.Forms.Button bConsultaUsuario;
        private System.Windows.Forms.Button bConsultaProveedor;
        private System.Windows.Forms.Button bConsultaCliente;
        private System.Windows.Forms.Button bCategoria;
        private System.Windows.Forms.Button bConsultaCategoria;
        private System.Windows.Forms.Button bMaestroDetalle;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.Button bAcercaDe;
        private System.Windows.Forms.PictureBox ImagenBienvenida;
        private System.Windows.Forms.Button bHamburguesa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Timer timerMenu;
    }
}