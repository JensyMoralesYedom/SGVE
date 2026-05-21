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
    public partial class ReporteCategoria : Form
    {
        public ReporteCategoria()
        {
            InitializeComponent();
        }

        private void ReporteCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBSGVEDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.dBSGVEDataSet.Categoria);

            this.reportViewer1.RefreshReport();
        }
    }
}
