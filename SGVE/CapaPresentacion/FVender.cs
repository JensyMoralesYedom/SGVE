using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FVender : Form
    {
        int indexPro = 1;
        CNProducto cNProducto = new CNProducto();

        int idProductoSeleccionado = 0;
        int stockProductoSeleccionado = 0;

        public FVender()
        {
            InitializeComponent();
        }

        private void FVender_Load(object sender, EventArgs e)
        {
            ConfigurarGrid(); 
            CargarClientePorDefecto();

            if (!string.IsNullOrEmpty(Program.nombreUsuarioActual))
            {
                textBox2.Text = Program.nombreUsuarioActual;
            }
            else
            {
                textBox2.Text = "Administrador";
            }

            textBox1.Text = "AUTO";

            CalcularTotal();
        }

        private void ConfigurarGrid()
        {
            dgDetalle.Columns.Clear();

            dgDetalle.Columns.Add("IdProducto", "IdProducto");
            dgDetalle.Columns["IdProducto"].Visible = false;

            dgDetalle.Columns.Add("Num", "N°");
            dgDetalle.Columns["Num"].FillWeight = 40f;

            dgDetalle.Columns.Add("Descripcion", "Descripción");
            dgDetalle.Columns["Descripcion"].FillWeight = 200f;

            dgDetalle.Columns.Add("Cantidad", "Cantidad");
            dgDetalle.Columns.Add("Precio", "Precio Venta");
            dgDetalle.Columns.Add("Importe", "Importe");

            dgDetalle.Columns.Add("StockProd", "StockProd");
            dgDetalle.Columns["StockProd"].Visible = false;

            dgDetalle.AllowUserToAddRows = false;
            dgDetalle.ReadOnly = true;
        }

        private void CargarClientePorDefecto()
        {
            Program.vidCliente = 1;
            DataTable dt = CNCliente.ObtenerCliente(Program.vidCliente.ToString());

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbIdCliente.Text = Program.vidCliente.ToString();
                tbNombreCliente.Text = row["Nombre"].ToString();
                tbApellidoCliente.Text = row["Apellido"].ToString();
                tbTelefonoCliente.Text = row["Telefono"].ToString();
            }
        }

        private void CalcularTotal()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgDetalle.Rows)
            {
                if (!row.IsNewRow && row.Cells["Importe"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["Importe"].Value);
                }
            }

            decimal itbis = subtotal * 0.18m;
            decimal totalFactura = subtotal + itbis;

            lblSubtotal.Text = "$ " + subtotal.ToString("0.00");
            lblItbis.Text = "$ " + itbis.ToString("0.00");
            lblTotal.Text = "$ " + totalFactura.ToString("0.00");
        }

        private void CargarProducto(int idProducto)
        {
            string valorparametro = idProducto.ToString();
            DataTable dt = cNProducto.ObtenerProducto(valorparametro);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt.Rows[0];

            idProductoSeleccionado = idProducto;
            stockProductoSeleccionado = Convert.ToInt32(row["StockUnidades"]);

            if (stockProductoSeleccionado <= 0)
            {
                MessageBox.Show("No hay existencia de esta fragancia.", "Sin Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarMercancia();
                return;
            }

            tbProducto.Text = row["Codigo"].ToString();
            tbMercancia.Text = row["Nombre"].ToString();
            tbPrecioVenta.Text = Convert.ToDecimal(row["PrecioVenta"]).ToString("0.00");

            tbCantidadProd.Text = "1";
            CalcularImporteMercancia();
            tbCantidadProd.Focus();
        }

        private void CalcularImporteMercancia()
        {
            if (int.TryParse(tbCantidadProd.Text, out int cant) && decimal.TryParse(tbPrecioVenta.Text, out decimal precio))
            {
                tbImporteProd.Text = (cant * precio).ToString("0.00");
            }
            else
            {
                tbImporteProd.Text = "0.00";
            }
        }

        private void tbCantidadProd_TextChanged(object sender, EventArgs e)
        {
            CalcularImporteMercancia();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FBuscarProducto buscarProductoForm = new FBuscarProducto();
            buscarProductoForm.ShowDialog();

            if (Program.vidProducto > 0)
            {
                CargarProducto(Program.vidProducto);
                Program.vidProducto = 0;
            }
        }

        private void btnAgregarMercancia_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Busque un producto primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbCantidadProd.Text, out int cantidadAgregar) || cantidadAgregar <= 0)
            {
                MessageBox.Show("Cantidad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cantidadAgregar > stockProductoSeleccionado)
            {
                MessageBox.Show("Stock insuficiente.", "Sin Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool encontrado = false;

            foreach (DataGridViewRow fila in dgDetalle.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells["IdProducto"].Value != null && Convert.ToInt32(fila.Cells["IdProducto"].Value) == idProductoSeleccionado)
                {
                    int cantExistente = Convert.ToInt32(fila.Cells["Cantidad"].Value);

                    if (cantExistente + cantidadAgregar > stockProductoSeleccionado)
                    {
                        MessageBox.Show("Alcanzaste el límite del stock disponible para este producto.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    fila.Cells["Cantidad"].Value = cantExistente + cantidadAgregar;
                    fila.Cells["Importe"].Value = (cantExistente + cantidadAgregar) * Convert.ToDecimal(tbPrecioVenta.Text);
                    fila.Cells["StockProd"].Value = stockProductoSeleccionado - (cantExistente + cantidadAgregar);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                dgDetalle.Rows.Add(new object[]
                {
                    idProductoSeleccionado,
                    indexPro.ToString(),
                    tbMercancia.Text,
                    cantidadAgregar,
                    Convert.ToDecimal(tbPrecioVenta.Text),
                    Convert.ToDecimal(tbImporteProd.Text),
                    stockProductoSeleccionado - cantidadAgregar
                });

                indexPro++;
            }

            CalcularTotal();
            LimpiarMercancia();
        }

        private void LimpiarMercancia()
        {
            idProductoSeleccionado = 0;
            stockProductoSeleccionado = 0;
            tbProducto.Clear();
            tbMercancia.Clear();
            tbCantidadProd.Clear();
            tbPrecioVenta.Clear();
            tbImporteProd.Clear();
            btnBuscarProducto.Focus();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FBuscarCliente fBuscarCliente = new FBuscarCliente();
            fBuscarCliente.ShowDialog();

            if (Program.vidCliente > 0)
            {
                DataTable dt = CNCliente.ObtenerCliente(Program.vidCliente.ToString());

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    tbIdCliente.Text = Program.vidCliente.ToString();
                    tbNombreCliente.Text = row["Nombre"].ToString();
                    tbApellidoCliente.Text = row["Apellido"].ToString();
                    tbTelefonoCliente.Text = row["Telefono"].ToString();
                }
            }
        }

        private void tbProducto_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarProducto_Click(sender, e);
            }
        }

        private void tbIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarCliente_Click(sender, e);
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (dgDetalle.Rows.Count == 0 || (dgDetalle.Rows.Count == 1 && dgDetalle.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debe agregar al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow fila in dgDetalle.Rows)
            {
                if (fila.IsNewRow) continue;

                int idProducto = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                int cantidadGrid = Convert.ToInt32(fila.Cells["Cantidad"].Value);

                DataTable dt = cNProducto.ObtenerProducto(idProducto.ToString());
                int stockBD = Convert.ToInt32(dt.Rows[0]["StockUnidades"]);

                if (cantidadGrid > stockBD)
                {
                    string nombreFragancia = fila.Cells["Descripcion"].Value != null ? fila.Cells["Descripcion"].Value.ToString() : "Desconocida";
                    MessageBox.Show("La fragancia '" + nombreFragancia + "' no tiene stock suficiente. Disponible: " + stockBD.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int idUsuario = Program.idUsuarioActual > 0 ? Program.idUsuarioActual : 1;

            CDResultado resultado = CNFacturas.Insertar(Program.vidCliente, idUsuario, dtpFecha.Value, "Activo", "Venta de mostrador", DateTime.Now);

            if (!resultado.Exito || resultado.IdResult <= 0)
            {
                MessageBox.Show("Error al generar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool hayErrorEnDetalle = false;

            foreach (DataGridViewRow fila in dgDetalle.Rows)
            {
                if (fila.IsNewRow) continue;

                int idProducto = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);

                DataTable dt = cNProducto.ObtenerProducto(idProducto.ToString());
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    int stockBD = Convert.ToInt32(row["StockUnidades"]);

                    CNProducto.Actualizar(
                        idProducto, row["Codigo"].ToString(), row["Nombre"].ToString(), row["Marca"].ToString(),
                        row["Descripcion"].ToString(), Convert.ToDecimal(row["CostoPorUnidad"]), Convert.ToDecimal(row["MililitrosPorUnidad"]),
                        Convert.ToDecimal(row["PrecioVenta"]), Convert.ToInt32(row["IdCategoria"]), (stockBD - cantidad),
                        row["Estado"].ToString(), Convert.ToInt32(row["IdUsuarioRegistro"])
                    );
                }

                if (CNDetalleFactura.Insertar(0, resultado.IdResult, idProducto, cantidad, precio) != "OK")
                {
                    hayErrorEnDetalle = true;
                }
            }

            if (hayErrorEnDetalle) MessageBox.Show("Factura guardada con alertas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnCancelar_Click(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgDetalle.Rows.Clear();
            indexPro = 1;
            LimpiarMercancia();
            dtpFecha.Value = DateTime.Now;
            CargarClientePorDefecto();
            CalcularTotal();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void tbIdCliente_TextChanged(object sender, EventArgs e) { }

        private void FVender_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}