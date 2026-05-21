using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FConsultaProducto : Form
    {
        public int vtieneparametro = 0, indice = 0;
        public string valorparametro = "", mensaje = "";

        CNProducto objProducto = new CNProducto();

        public FConsultaProducto()
        {
            InitializeComponent();
        }

        private void FConsultaProducto_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void FConsultaProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¡Esto le hará salir del formulario! \n ¿Seguro que desea hacerlo?",
                                "Mensaje del Sistema",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            DataTable dt = objProducto.ObtenerProducto(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;

                DataGridViewCellStyle styleCabeceraCentro = new DataGridViewCellStyle(DGVDatos.ColumnHeadersDefaultCellStyle);
                styleCabeceraCentro.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (DGVDatos.Columns.Contains("Codigo"))
                {
                    DGVDatos.Columns["Codigo"].HeaderText = "Código";
                    DGVDatos.Columns["Codigo"].FillWeight = 65;
                }
                if (DGVDatos.Columns.Contains("Nombre"))
                {
                    DGVDatos.Columns["Nombre"].HeaderText = "Nombre";
                    DGVDatos.Columns["Nombre"].FillWeight = 120;
                }
                if (DGVDatos.Columns.Contains("Marca"))
                {
                    DGVDatos.Columns["Marca"].HeaderText = "Marca";
                    DGVDatos.Columns["Marca"].FillWeight = 70;
                }
                if (DGVDatos.Columns.Contains("Descripcion"))
                {
                    DGVDatos.Columns["Descripcion"].HeaderText = "Descripción";
                    DGVDatos.Columns["Descripcion"].FillWeight = 140;
                }
                if (DGVDatos.Columns.Contains("NombreCategoria"))
                {
                    DGVDatos.Columns["NombreCategoria"].HeaderText = "Categoría";
                    DGVDatos.Columns["NombreCategoria"].FillWeight = 80;
                }
                if (DGVDatos.Columns.Contains("Estado"))
                {
                    DGVDatos.Columns["Estado"].HeaderText = "Estado";
                    DGVDatos.Columns["Estado"].FillWeight = 55;
                }
                if (DGVDatos.Columns.Contains("UsuarioRegistro"))
                {
                    DGVDatos.Columns["UsuarioRegistro"].HeaderText = "Usuario";
                    DGVDatos.Columns["UsuarioRegistro"].FillWeight = 70;
                }
                if (DGVDatos.Columns.Contains("FechaRegistro"))
                {
                    DGVDatos.Columns["FechaRegistro"].HeaderText = "Fecha";
                    DGVDatos.Columns["FechaRegistro"].FillWeight = 80;
                }

                // --- 🟢 COLUMNAS DE NÚMEROS E IDs (TODO CENTRADO) ---

                if (DGVDatos.Columns.Contains("IdProducto"))
                {
                    DGVDatos.Columns["IdProducto"].HeaderText = "ID";
                    DGVDatos.Columns["IdProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["IdProducto"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["IdProducto"].FillWeight = 35;
                }

                if (DGVDatos.Columns.Contains("IdCategoria"))
                {
                    DGVDatos.Columns["IdCategoria"].HeaderText = "ID Cat.";
                    DGVDatos.Columns["IdCategoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["IdCategoria"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["IdCategoria"].FillWeight = 45;
                }

                if (DGVDatos.Columns.Contains("IdUsuarioRegistro"))
                {
                    DGVDatos.Columns["IdUsuarioRegistro"].HeaderText = "ID Usu.";
                    DGVDatos.Columns["IdUsuarioRegistro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["IdUsuarioRegistro"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["IdUsuarioRegistro"].FillWeight = 45;
                }

                if (DGVDatos.Columns.Contains("CostoPorUnidad"))
                {
                    DGVDatos.Columns["CostoPorUnidad"].HeaderText = "Costo U.";
                    DGVDatos.Columns["CostoPorUnidad"].DefaultCellStyle.Format = "N2";
                    DGVDatos.Columns["CostoPorUnidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["CostoPorUnidad"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["CostoPorUnidad"].FillWeight = 65;
                }

                if (DGVDatos.Columns.Contains("PrecioVenta"))
                {
                    DGVDatos.Columns["PrecioVenta"].HeaderText = "Precio RD$";
                    DGVDatos.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
                    DGVDatos.Columns["PrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["PrecioVenta"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["PrecioVenta"].FillWeight = 75; 
                }

                if (DGVDatos.Columns.Contains("CostoPorMl"))
                {
                    DGVDatos.Columns["CostoPorMl"].HeaderText = "Costo ML";
                    DGVDatos.Columns["CostoPorMl"].DefaultCellStyle.Format = "N2";
                    DGVDatos.Columns["CostoPorMl"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["CostoPorMl"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["CostoPorMl"].FillWeight = 60;
                }

                if (DGVDatos.Columns.Contains("MililitrosPorUnidad"))
                {
                    DGVDatos.Columns["MililitrosPorUnidad"].HeaderText = "ML x U.";
                    DGVDatos.Columns["MililitrosPorUnidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["MililitrosPorUnidad"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["MililitrosPorUnidad"].FillWeight = 55;
                }

                if (DGVDatos.Columns.Contains("StockUnidades"))
                {
                    DGVDatos.Columns["StockUnidades"].HeaderText = "Stock U.";
                    DGVDatos.Columns["StockUnidades"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["StockUnidades"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["StockUnidades"].FillWeight = 55;
                }

                if (DGVDatos.Columns.Contains("StockEnMl"))
                {
                    DGVDatos.Columns["StockEnMl"].HeaderText = "Stock ML";
                    DGVDatos.Columns["StockEnMl"].DefaultCellStyle.Format = "N2";
                    DGVDatos.Columns["StockEnMl"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["StockEnMl"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["StockEnMl"].FillWeight = 65;
                }

                LCantProducto.Text = "Cantidad de Productos: " + dt.Rows.Count.ToString();
            }
            else
            {
                DGVDatos.DataSource = null;
                LCantProducto.Text = "Cantidad de Productos: 0";

                if (valorparametro != "")
                {
                    MessageBox.Show("No se encontraron productos con ese criterio.", "Mensaje de SIGEMP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            DGVDatos.Refresh();
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
            {
                indice = DGVDatos.CurrentRow.Index;
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BConsultar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text.Trim() != String.Empty)
            {
                vtieneparametro = 1;
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else
            {
                vtieneparametro = 0;
                valorparametro = "";
            }

            MostrarDatos();
            tbBuscar.Focus();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 0)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 0)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            BConsultar_Click(sender, e);
        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
            ReporteProducto reporte = new ReporteProducto();
            reporte.ShowDialog();
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void LCantProducto_Click(object sender, EventArgs e) { }
    }
}