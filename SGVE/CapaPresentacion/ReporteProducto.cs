using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ReporteProducto : Form
    {
        public ReporteProducto()
        {
            InitializeComponent();
        }

        private void ReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBSGVEDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dBSGVEDataSet.Producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
