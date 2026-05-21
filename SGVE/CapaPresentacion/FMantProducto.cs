using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FMantProducto : Form
    {
        public string mensaje = "";

        public FMantProducto()
        {
            InitializeComponent();
        }

        private void MantProducto_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiaObjetos()
        {
            tbIdProducto.Clear();
            tbCodigo.Clear();
            tbNombre.Clear();
            tbMarca.Clear();
            tbDescripcion.Clear();
            tbMililitrosPorUnidad.Clear();
            tbCostoPorUnidad.Clear();
            tbPrecioVenta.Clear();
            tbStockUnidades.Clear();
            cbCategoria.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
        }

        private void HabilitaControles(bool valor)
        {
            tbIdProducto.ReadOnly = true;
            tbCodigo.Enabled = valor;
            tbNombre.Enabled = valor;
            tbMarca.Enabled = valor;
            tbDescripcion.Enabled = valor;
            tbMililitrosPorUnidad.Enabled = valor;
            tbCostoPorUnidad.Enabled = valor;
            tbPrecioVenta.Enabled = valor;
            tbStockUnidades.Enabled = valor;
            cbCategoria.Enabled = valor;
            cbEstado.Enabled = valor;

            if (Program.nuevo && valor)
            {
                cbCategoria.SelectedIndex = -1;
                cbEstado.SelectedIndex = -1;
            }
        }

        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true);
                BNuevo.Enabled = false;
                BGuardar.Enabled = true;
                BEditar.Enabled = false;
                BBuscar.Enabled = false;
                BCancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false);
                BNuevo.Enabled = true;
                BGuardar.Enabled = false;
                BEditar.Enabled = tbIdProducto.Text != "";
                BBuscar.Enabled = true;
                BCancelar.Enabled = false;
            }
        }

        private void CargarCategorias()
        {
            try
            {
                CNCategoria cNCategoria = new CNCategoria();
                DataTable dt = cNCategoria.ObtenerCategoria("");
                cbCategoria.DataSource = null;
                cbCategoria.DataSource = dt;
                cbCategoria.DisplayMember = "NombreCategoria";
                cbCategoria.ValueMember = "IdCategoria";
                cbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Mensaje de SIGEMP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MantProducto_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            CargarCategorias();
            HabilitaBotones();
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbCodigo.Focus();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCodigo.Text))
            {
                MessageBox.Show("¡Debe indicar el Código del Producto!");
                tbCodigo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("¡Debe indicar el Nombre del Producto!");
                tbNombre.Focus();
                return;
            }
            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("¡Debe seleccionar la Categoría del Producto!");
                cbCategoria.Focus();
                return;
            }
            if (cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("¡Debe seleccionar el Estado del Producto!");
                cbEstado.Focus();
                return;
            }

            decimal costo, mililitros, precio;
            int stock;

            if (!decimal.TryParse(tbCostoPorUnidad.Text, out costo))
            {
                MessageBox.Show("El Costo debe ser un número válido.");
                tbCostoPorUnidad.Focus();
                return;
            }
            if (!decimal.TryParse(tbMililitrosPorUnidad.Text, out mililitros))
            {
                MessageBox.Show("Los Mililitros deben ser un número válido.");
                tbMililitrosPorUnidad.Focus();
                return;
            }
            if (!decimal.TryParse(tbPrecioVenta.Text, out precio))
            {
                MessageBox.Show("El Precio debe ser un número válido.");
                tbPrecioVenta.Focus();
                return;
            }
            if (!int.TryParse(tbStockUnidades.Text, out stock))
            {
                MessageBox.Show("El Stock debe ser un número entero.");
                tbStockUnidades.Focus();
                return;
            }

            try
            {
                int idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);

                if (Program.nuevo)
                {
                    mensaje = CNProducto.Insertar(
                        0,
                        tbCodigo.Text,
                        tbNombre.Text,
                        tbMarca.Text,
                        tbDescripcion.Text,
                        costo,
                        mililitros,
                        precio,
                        idCategoria,
                        stock,
                        cbEstado.Text,
                        Program.idUsuarioActual
                    );
                }
                else
                {
                    mensaje = CNProducto.Actualizar(
                        Convert.ToInt32(tbIdProducto.Text),
                        tbCodigo.Text,
                        tbNombre.Text,
                        tbMarca.Text,
                        tbDescripcion.Text,
                        costo,
                        mililitros,
                        precio,
                        idCategoria,
                        stock,
                        cbEstado.Text,
                        Program.idUsuarioActual
                    );
                }

                if (mensaje == "OK")
                {
                    MessageBox.Show("La operación se ha completado con éxito. Los datos han sido registrados en el sistema.",
                                    "Engage - Confirmación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    Program.nuevo = false;
                    Program.modificar = false;
                    HabilitaBotones();
                    LimpiaObjetos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (tbIdProducto.Text != "")
            {
                Program.nuevo = false;
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("¡Debe buscar un Producto para poder modificar sus datos!");
            }
        }

        private void MantProducto_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            FBuscarProducto fBuscarProducto = new FBuscarProducto();
            fBuscarProducto.ShowDialog();

            if (Program.modificar)
            {
                Program.nuevo = false;
                Program.modificar = false;
                RecuperaDatos();
                HabilitaBotones();
            }
            else
            {
                LimpiaObjetos();
                BBuscar.Focus();
            }
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vidProducto.ToString();
            CNProducto cNProducto = new CNProducto();
            DataTable dt = cNProducto.ObtenerProducto(vparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbIdProducto.Text = row["IdProducto"].ToString();
                tbCodigo.Text = row["Codigo"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbMarca.Text = row["Marca"].ToString();
                tbDescripcion.Text = row["Descripcion"].ToString();
                tbMililitrosPorUnidad.Text = row["MililitrosPorUnidad"].ToString();
                tbCostoPorUnidad.Text = row["CostoPorUnidad"].ToString();
                tbPrecioVenta.Text = row["PrecioVenta"].ToString();
                tbStockUnidades.Text = row["StockUnidades"].ToString();
                cbCategoria.SelectedValue = row["IdCategoria"];
                cbEstado.Text = row["Estado"].ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblCodigo_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void tbCodigo_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e) { }
        private void toolTip1_Popup_1(object sender, PopupEventArgs e) { }
        private void PBotones_Paint(object sender, PaintEventArgs e) { }
        private void lblCostoPorMl_Click(object sender, EventArgs e) { }
        private void tbMililitrosPorUnidad_TextChanged(object sender, EventArgs e) { }
        private void tbCostoPorUnidad_TextChanged(object sender, EventArgs e) { }
        private void tbStockUnidades_TextChanged(object sender, EventArgs e) { }
    }
}