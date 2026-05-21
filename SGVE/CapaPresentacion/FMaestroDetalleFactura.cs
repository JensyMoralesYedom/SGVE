using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FMaestroDetalleFactura : Form
    {
        public int vidfactura = 0, vtieneparametro = 0, indice = 0;
        public string valorparametro = "", mensaje = "";
        public CNFacturas objFactura = new CNFacturas();

        public FMaestroDetalleFactura()
        {
            InitializeComponent();
        }

        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            DataTable dt = CNFacturas.ObtenerFacturas(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvFacturas.DataSource = dt;

                DataGridViewCellStyle styleCentro = new DataGridViewCellStyle(dgvFacturas.ColumnHeadersDefaultCellStyle);
                styleCentro.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewCellStyle styleIzquierda = new DataGridViewCellStyle(dgvFacturas.ColumnHeadersDefaultCellStyle);
                styleIzquierda.Alignment = DataGridViewContentAlignment.MiddleLeft;

                if (dgvFacturas.Columns.Contains("IdFactura") || dgvFacturas.Columns.Contains("IdFacturas"))
                {
                    string colID = dgvFacturas.Columns.Contains("IdFactura") ? "IdFactura" : "IdFacturas";
                    dgvFacturas.Columns[colID].HeaderText = "No. Factura";
                    dgvFacturas.Columns[colID].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvFacturas.Columns[colID].HeaderCell.Style = styleCentro;
                    dgvFacturas.Columns[colID].FillWeight = 50;
                }

                if (dgvFacturas.Columns.Contains("IdCliente"))
                {
                    dgvFacturas.Columns["IdCliente"].HeaderText = "ID Cliente";
                    dgvFacturas.Columns["IdCliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvFacturas.Columns["IdCliente"].HeaderCell.Style = styleCentro;
                    dgvFacturas.Columns["IdCliente"].FillWeight = 50;
                }

                if (dgvFacturas.Columns.Contains("IdUsuarioVendedor"))
                {
                    dgvFacturas.Columns["IdUsuarioVendedor"].HeaderText = "ID Vendedor";
                    dgvFacturas.Columns["IdUsuarioVendedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvFacturas.Columns["IdUsuarioVendedor"].HeaderCell.Style = styleCentro;
                    dgvFacturas.Columns["IdUsuarioVendedor"].FillWeight = 60;
                }

                if (dgvFacturas.Columns.Contains("FechaFactura"))
                {
                    dgvFacturas.Columns["FechaFactura"].HeaderText = "Fecha Factura";
                    dgvFacturas.Columns["FechaFactura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvFacturas.Columns["FechaFactura"].HeaderCell.Style = styleCentro;
                    dgvFacturas.Columns["FechaFactura"].FillWeight = 90;
                }

                if (dgvFacturas.Columns.Contains("Estado"))
                {
                    dgvFacturas.Columns["Estado"].HeaderText = "Estado";
                    dgvFacturas.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvFacturas.Columns["Estado"].HeaderCell.Style = styleCentro;
                    dgvFacturas.Columns["Estado"].FillWeight = 60;
                }

                if (dgvFacturas.Columns.Contains("Observaciones"))
                {
                    dgvFacturas.Columns["Observaciones"].HeaderText = "Observaciones";
                    dgvFacturas.Columns["Observaciones"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgvFacturas.Columns["Observaciones"].HeaderCell.Style = styleIzquierda;
                    dgvFacturas.Columns["Observaciones"].FillWeight = 150;
                }

                if (dgvFacturas.Columns.Contains("FechaRegistro"))
                {
                    dgvFacturas.Columns["FechaRegistro"].HeaderText = "F. Registro";
                    dgvFacturas.Columns["FechaRegistro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvFacturas.Columns["FechaRegistro"].HeaderCell.Style = styleCentro;
                    dgvFacturas.Columns["FechaRegistro"].FillWeight = 90;
                }

                lblCantLabel.Text = "Total Facturas: " + dt.Rows.Count.ToString();
            }
            else
            {
                dgvFacturas.DataSource = null;
                lblCantLabel.Text = "Total Facturas: 0";

                if (valorparametro != "")
                {
                    MessageBox.Show("No se encontraron facturas.", "Mensaje de SIGEMP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dgvFacturas.Refresh();
        }

        private void CargarDetalles(string pIdFactura)
        {
            CNDetalleFactura objDetalleFactura = new CNDetalleFactura();
            DataTable dtDetalles = objDetalleFactura.ObtenerDetalleFactura(pIdFactura);

            if (dtDetalles != null && dtDetalles.Rows.Count > 0)
            {
                dgvDetalleFactura.DataSource = dtDetalles;

                DataGridViewCellStyle styleCentro = new DataGridViewCellStyle(dgvDetalleFactura.ColumnHeadersDefaultCellStyle);
                styleCentro.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewCellStyle styleDerecha = new DataGridViewCellStyle(dgvDetalleFactura.ColumnHeadersDefaultCellStyle);
                styleDerecha.Alignment = DataGridViewContentAlignment.MiddleRight;

                if (dgvDetalleFactura.Columns.Contains("IdDetalle"))
                {
                    dgvDetalleFactura.Columns["IdDetalle"].Visible = false;
                }

                if (dgvDetalleFactura.Columns.Contains("IdFactura"))
                {
                    dgvDetalleFactura.Columns["IdFactura"].Visible = false; 
                }

                if (dgvDetalleFactura.Columns.Contains("IdProducto"))
                {
                    dgvDetalleFactura.Columns["IdProducto"].HeaderText = "Cod. Producto";
                    dgvDetalleFactura.Columns["IdProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvDetalleFactura.Columns["IdProducto"].HeaderCell.Style = styleCentro;
                    dgvDetalleFactura.Columns["IdProducto"].FillWeight = 80;
                }

                if (dgvDetalleFactura.Columns.Contains("Producto") || dgvDetalleFactura.Columns.Contains("Nombre"))
                {
                    string colProd = dgvDetalleFactura.Columns.Contains("Producto") ? "Producto" : "Nombre";
                    dgvDetalleFactura.Columns[colProd].HeaderText = "Descripción del Producto";
                    dgvDetalleFactura.Columns[colProd].FillWeight = 150;
                }

                if (dgvDetalleFactura.Columns.Contains("Cantidad"))
                {
                    dgvDetalleFactura.Columns["Cantidad"].HeaderText = "Cant.";
                    dgvDetalleFactura.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvDetalleFactura.Columns["Cantidad"].HeaderCell.Style = styleCentro;
                    dgvDetalleFactura.Columns["Cantidad"].FillWeight = 50;
                }

                if (dgvDetalleFactura.Columns.Contains("Precio"))
                {
                    dgvDetalleFactura.Columns["Precio"].HeaderText = "Precio RD$";
                    dgvDetalleFactura.Columns["Precio"].DefaultCellStyle.Format = "N2";
                    dgvDetalleFactura.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDetalleFactura.Columns["Precio"].HeaderCell.Style = styleDerecha;
                    dgvDetalleFactura.Columns["Precio"].FillWeight = 70;
                }

                if (dgvDetalleFactura.Columns.Contains("ITBIS") || dgvDetalleFactura.Columns.Contains("Impuesto"))
                {
                    string colImp = dgvDetalleFactura.Columns.Contains("ITBIS") ? "ITBIS" : "Impuesto";
                    dgvDetalleFactura.Columns[colImp].HeaderText = "ITBIS";
                    dgvDetalleFactura.Columns[colImp].DefaultCellStyle.Format = "N2";
                    dgvDetalleFactura.Columns[colImp].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDetalleFactura.Columns[colImp].HeaderCell.Style = styleDerecha;
                    dgvDetalleFactura.Columns[colImp].FillWeight = 60;
                }

                if (dgvDetalleFactura.Columns.Contains("SubTotal"))
                {
                    dgvDetalleFactura.Columns["SubTotal"].HeaderText = "SubTotal";
                    dgvDetalleFactura.Columns["SubTotal"].DefaultCellStyle.Format = "N2";
                    dgvDetalleFactura.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDetalleFactura.Columns["SubTotal"].HeaderCell.Style = styleDerecha;
                    dgvDetalleFactura.Columns["SubTotal"].FillWeight = 70;
                }

                if (dgvDetalleFactura.Columns.Contains("Total"))
                {
                    dgvDetalleFactura.Columns["Total"].HeaderText = "Total RD$";
                    dgvDetalleFactura.Columns["Total"].DefaultCellStyle.Format = "N2";
                    dgvDetalleFactura.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDetalleFactura.Columns["Total"].HeaderCell.Style = styleDerecha;
                    dgvDetalleFactura.Columns["Total"].FillWeight = 80;
                }
            }
            else
            {
                dgvDetalleFactura.DataSource = null;
            }
            dgvDetalleFactura.Refresh();
        }

        private void dgvFacturas_CurrentCellChanged(object sender, EventArgs e)
        {
            if ((dgvFacturas.CurrentRow != null) && (dgvFacturas.CurrentRow.Index != -1))
            {
                indice = dgvFacturas.CurrentRow.Index;

                string colID = dgvFacturas.Columns.Contains("IdFactura") ? "IdFactura" :
                               dgvFacturas.Columns.Contains("IdFacturas") ? "IdFacturas" : "";

                if (colID != "")
                {
                    Program.vidfactura = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[colID].Value.ToString());
                    CargarDetalles(Program.vidfactura.ToString());
                }
            }
        }

        private void BConsultar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty)
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

        private void dgvFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CargarDetalles(dgvFacturas.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void FMaestroDetalleFactura_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.Rows.Count > 0)
            {
                indice = 0;
                dgvFacturas.CurrentCell = dgvFacturas.Rows[indice].Cells[dgvFacturas.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                dgvFacturas.CurrentCell = dgvFacturas.Rows[indice].Cells[dgvFacturas.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.dgvFacturas.RowCount - 1)
            {
                indice++;
                dgvFacturas.CurrentCell = dgvFacturas.Rows[indice].Cells[dgvFacturas.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.RowCount > 0)
            {
                indice = dgvFacturas.Rows.Count - 1;
                dgvFacturas.CurrentCell = dgvFacturas.Rows[indice].Cells[dgvFacturas.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            BConsultar_Click(sender, e);
        }
    }
}