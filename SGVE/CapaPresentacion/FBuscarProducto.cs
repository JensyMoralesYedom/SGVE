using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FBuscarProducto : Form
    {
        public int indice = 0;
        public int vtieneparametro = 0;
        public string valorparametro = "";

        private bool cierreControlado = false;

        CNProducto cNProducto = new CNProducto();

        public FBuscarProducto()
        {
            InitializeComponent();
        }

        private void FBuscarProducto_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidProducto = 0;
            Program.modificar = false;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void FBuscarProducto_FormClosing(object sender, FormClosingEventArgs e)
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
            DataTable dt = cNProducto.ObtenerProducto(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;
                indice = 0;


                string[] columnasOcultas = {
            "CostoPorUnidad",
            "MililitrosPorUnidad",
            "IdCategoria",
            "Estado",
            "FechaRegistro",
            "IdUsuarioRegistro",
            "UsuarioRegistro",
            "UsuarioRegist",
            "CostoPorML",
            "StockEnML"
        };

                foreach (string col in columnasOcultas)
                {
                    if (DGVDatos.Columns.Contains(col))
                        DGVDatos.Columns[col].Visible = false;
                }

                if (DGVDatos.Columns.Contains("IdProducto"))
                    DGVDatos.Columns["IdProducto"].HeaderText = "ID";

                if (DGVDatos.Columns.Contains("Codigo"))
                    DGVDatos.Columns["Codigo"].HeaderText = "Código";

                if (DGVDatos.Columns.Contains("Descripcion"))
                    DGVDatos.Columns["Descripcion"].HeaderText = "Descripción";

                if (DGVDatos.Columns.Contains("NombreCategoria"))
                    DGVDatos.Columns["NombreCategoria"].HeaderText = "Categoría";

                if (DGVDatos.Columns.Contains("PrecioVenta"))
                {
                    DGVDatos.Columns["PrecioVenta"].HeaderText = "Precio RD$";
                    DGVDatos.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
                }

                if (DGVDatos.Columns.Contains("StockUnidades"))
                {
                    DGVDatos.Columns["StockUnidades"].HeaderText = "Stock";
                }

                string[] ordenVisual = {
            "IdProducto", "Codigo", "Nombre", "Marca", "Descripcion",
            "NombreCategoria", "PrecioVenta", "StockUnidades"
        };

                int displayIndex = 0;
                foreach (string col in ordenVisual)
                {
                    if (DGVDatos.Columns.Contains(col))
                    {
                        DGVDatos.Columns[col].DisplayIndex = displayIndex++;
                    }
                }

                if (DGVDatos.Rows.Count > 0)
                {
                    DGVDatos.CurrentCell = DGVDatos.Rows[0].Cells[DGVDatos.FirstDisplayedCell?.ColumnIndex ?? 0];
                }
            }
            else if (dt != null && dt.Rows.Count == 0)
            {
                DGVDatos.DataSource = dt;
                MessageBox.Show("No se encontraron productos con ese criterio.",
                                "Mensaje de SIGEMP",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al consultar los productos.",
                                "Mensaje de SIGEMP",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            DGVDatos.Refresh();
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
                indice = DGVDatos.CurrentRow.Index;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false;
            cierreControlado = true;
            Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 0 && DGVDatos.CurrentRow != null)
            {
                Program.vidProducto = Convert.ToInt32(DGVDatos.CurrentRow.Cells["IdProducto"].Value);
                FInventario.selecciono = true;
                cierreControlado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (indice < DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (DGVDatos.RowCount > 0)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            BAceptar_Click(sender, e);
        }

        private void BBuscarDato_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text.Trim() != string.Empty)
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
        }

        private void tbBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                BBuscarDato_Click(sender, e);
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            BBuscarDato_Click(sender, e);
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}