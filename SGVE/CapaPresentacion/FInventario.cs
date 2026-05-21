using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FInventario : Form
    {
        public static int vidproducto = 0, vstock = 0;
        public static decimal vcantidad = 0, vcosto = 0, vimporte = 0, vtotal = 0;
        public static string vnombre = "";
        public static bool selecciono = false;

        public FInventario()
        {
            InitializeComponent();
        }

        private void FProcAjusteInventario_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarGrid();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la pantalla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            DGVDetalle.Columns.Clear();
            DGVDetalle.Columns.Add("IdProducto", "ID");
            DGVDetalle.Columns.Add("Producto", "Descripción del Producto");
            DGVDetalle.Columns.Add("Cantidad", "Cantidad Ajustada");
            DGVDetalle.Columns.Add("Costo", "Costo Actual");
            DGVDetalle.Columns.Add("Importe", "Importe Total");

            DGVDetalle.AllowUserToAddRows = false;
            DGVDetalle.ReadOnly = true;
        }

        private void Limpiar()
        {
            if (cbTipoMovimiento.Items.Count > 0)
            {
                cbTipoMovimiento.SelectedIndex = 0;
            }

            tbObservacion.Text = string.Empty;
            dtpFechaMovimiento.Value = DateTime.Now;

            // Producto
            tbIdProducto.Text = string.Empty;
            tbNombreProducto.Text = string.Empty;
            tbStockActual.Text = string.Empty;
            tbCantidad.Text = string.Empty;
            tbCostoUnitario.Text = string.Empty;
            tbImporte.Text = string.Empty;

            // Variables y Totales
            vidproducto = 0; vstock = 0; vcantidad = 0; vcosto = 0; vimporte = 0; vtotal = 0;
            selecciono = false;
            lblTotal.Text = "0.00";
            DGVDetalle.Rows.Clear();
        }

        private void MostrarProducto()
        {
            CNProducto objProducto = new CNProducto();
            DataTable dt = objProducto.ObtenerProducto(vidproducto.ToString());

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];

                vnombre = fila["Nombre"].ToString();
                vstock = Convert.ToInt32(fila["StockUnidades"]);
                vcosto = Convert.ToDecimal(fila["CostoPorUnidad"]);

                tbIdProducto.Text = vidproducto.ToString();
                tbNombreProducto.Text = vnombre;
                tbStockActual.Text = vstock.ToString();
                tbCostoUnitario.Text = vcosto.ToString("0.00");
            }
            else
            {
                MessageBox.Show("No se encontró la información del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            vidproducto = 0;
            selecciono = false;

            FBuscarProducto fbproducto = new FBuscarProducto();
            fbproducto.ShowDialog();

            if (selecciono)
            {
                vidproducto = Program.vidProducto;
                MostrarProducto();
                tbCantidad.Focus();
            }
            else
            {
                MessageBox.Show("¡No eligió ningún producto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbCantidad_Leave(object sender, EventArgs e)
        {
            if (tbCantidad.Text != string.Empty)
            {
                if (decimal.TryParse(tbCantidad.Text, out vcantidad))
                {
                    if (cbTipoMovimiento.Text == "Ajuste de Salida" && vcantidad > vstock)
                    {
                        MessageBox.Show("¡No hay suficiente existencia para este ajuste de salida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbCantidad.Focus();
                        return;
                    }

                    vimporte = vcantidad * vcosto;
                    tbImporte.Text = vimporte.ToString("0.00");

                    BAgregar.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido en la cantidad.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCantidad.Clear();
                    tbCantidad.Focus();
                }
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (tbIdProducto.Text == string.Empty || tbCantidad.Text == string.Empty)
            {
                MessageBox.Show("Faltan datos del producto por completar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DGVDetalle.Rows.Add(tbIdProducto.Text, tbNombreProducto.Text, tbCantidad.Text, tbCostoUnitario.Text, tbImporte.Text);

            vtotal += Convert.ToDecimal(tbImporte.Text);
            lblTotal.Text = vtotal.ToString("0.00");

            tbIdProducto.Clear();
            tbNombreProducto.Clear();
            tbStockActual.Clear();
            tbCantidad.Clear();
            tbCostoUnitario.Clear();
            tbImporte.Clear();
            vidproducto = 0;

            BBuscarProducto.Focus();
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FInventario_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (cbTipoMovimiento.SelectedIndex == -1 || DGVDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el tipo de ajuste y tener al menos un producto en el detalle.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbObservacion.Text))
            {
                MessageBox.Show("Es obligatorio indicar un motivo/observación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbObservacion.Focus();
                return;
            }

            try
            {
                int idUsuarioActual = Program.idUsuarioActual > 0 ? Program.idUsuarioActual : 1;

                string rpta = CNAlmacenCabecera.Insertar(0, cbTipoMovimiento.Text, dtpFechaMovimiento.Value,
                                                         idUsuarioActual, tbObservacion.Text, "Activo", DateTime.Now);

                if (int.TryParse(rpta, out int idCabeceraGenerado))
                {
                    foreach (DataGridViewRow row in DGVDetalle.Rows)
                    {
                        int idProd = Convert.ToInt32(row.Cells["IdProducto"].Value);
                        int cant = Convert.ToInt32(Convert.ToDecimal(row.Cells["Cantidad"].Value));
                        decimal costo = Convert.ToDecimal(row.Cells["Costo"].Value);

                        CNAlmacenDetalle.Insertar(0, idCabeceraGenerado, idProd, cant, costo, "DOP");

                        CNProducto.ActualizarStock(idProd, cant, cbTipoMovimiento.Text);
                    }

                    MessageBox.Show("El ajuste de inventario se guardó correctamente y el stock fue actualizado.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la cabecera: \n" + rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al procesar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DGVDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}