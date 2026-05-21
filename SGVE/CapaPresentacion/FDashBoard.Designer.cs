namespace CapaPresentacion
{
    partial class FDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDashBoard));
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tlpCharts = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlpTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tlpCharts.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 3;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTop.Controls.Add(this.panel2, 0, 0);
            this.tlpTop.Controls.Add(this.panel3, 1, 0);
            this.tlpTop.Controls.Add(this.panel7, 2, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.Padding = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(950, 140);
            this.tlpTop.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.lblTotalProductos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(25, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 100);
            this.panel2.TabIndex = 0;
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductos.ForeColor = System.Drawing.Color.White;
            this.lblTotalProductos.Location = new System.Drawing.Point(15, 45);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(35, 37);
            this.lblTotalProductos.TabIndex = 1;
            this.lblTotalProductos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL PRODUCTOS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.lblTotalVentas);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(331, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 100);
            this.panel3.TabIndex = 1;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.ForeColor = System.Drawing.Color.White;
            this.lblTotalVentas.Location = new System.Drawing.Point(15, 45);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(107, 37);
            this.lblTotalVentas.TabIndex = 1;
            this.lblTotalVentas.Text = "$ 0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "INGRESOS VENTAS";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panel7.Controls.Add(this.lblClientes);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(637, 25);
            this.panel7.Margin = new System.Windows.Forms.Padding(10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 100);
            this.panel7.TabIndex = 2;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(15, 45);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(35, 37);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "TOTAL CLIENTES";
            // 
            // tlpCharts
            // 
            this.tlpCharts.ColumnCount = 1;
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCharts.Controls.Add(this.panel5, 0, 0);
            this.tlpCharts.Controls.Add(this.chartVentas, 0, 1);
            this.tlpCharts.Controls.Add(this.panel6, 0, 2);
            this.tlpCharts.Controls.Add(this.chart1, 0, 3);
            this.tlpCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCharts.Location = new System.Drawing.Point(0, 140);
            this.tlpCharts.Name = "tlpCharts";
            this.tlpCharts.Padding = new System.Windows.Forms.Padding(25, 0, 25, 20);
            this.tlpCharts.RowCount = 4;
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.Size = new System.Drawing.Size(950, 460);
            this.tlpCharts.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(25, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 35);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ventas por Día";
            // 
            // chartVentas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea2);
            this.chartVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartVentas.Legends.Add(legend2);
            this.chartVentas.Location = new System.Drawing.Point(25, 45);
            this.chartVentas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.chartVentas.Name = "chartVentas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVentas.Series.Add(series2);
            this.chartVentas.Size = new System.Drawing.Size(900, 160);
            this.chartVentas.TabIndex = 3;
            this.chartVentas.Text = "chartVentas";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(25, 230);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(900, 35);
            this.panel6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Top Productos Más Vendidos";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 265);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(900, 175);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // FDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.tlpCharts);
            this.Controls.Add(this.tlpTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FDashBoard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FDashBoard_Load);
            this.tlpTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tlpCharts.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.TableLayoutPanel tlpCharts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}