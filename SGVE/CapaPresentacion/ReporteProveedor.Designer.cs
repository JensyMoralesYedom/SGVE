namespace CapaPresentacion
{
    partial class ReporteProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dBSGVEDataSet = new CapaPresentacion.DBSGVEDataSet();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new CapaPresentacion.DBSGVEDataSetTableAdapters.ProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dBSGVEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Proveedor";
            reportDataSource1.Value = this.proveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(859, 479);
            this.reportViewer1.TabIndex = 0;
            // 
            // dBSGVEDataSet
            // 
            this.dBSGVEDataSet.DataSetName = "DBSGVEDataSet";
            this.dBSGVEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dBSGVEDataSet;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 479);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProveedor";
            this.Text = "ReporteProveedor";
            this.Load += new System.EventHandler(this.ReporteProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBSGVEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DBSGVEDataSet dBSGVEDataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DBSGVEDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
    }
}