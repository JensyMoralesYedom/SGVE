using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FConsultaProveedor : Form
    {
        public int vidsuplidor = 0;
        public int vtieneparametro = 0;
        public int indice = 0;
        public string valorparametro = "";
        public string mensaje = "";

        public FConsultaProveedor()
        {
            InitializeComponent();
        }

        private void ConsultaProveedor_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void ConsultaProveedor_FormClosing(object sender, FormClosingEventArgs e)
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
            DataTable dt = CNProveedor.ObtenerProveedor(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;

                DataGridViewCellStyle styleCabeceraCentro = new DataGridViewCellStyle(DGVDatos.ColumnHeadersDefaultCellStyle);
                styleCabeceraCentro.Alignment = DataGridViewContentAlignment.MiddleCenter;


                if (DGVDatos.Columns.Contains("IdProveedor"))
                {
                    DGVDatos.Columns["IdProveedor"].HeaderText = "ID";
                    DGVDatos.Columns["IdProveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["IdProveedor"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["IdProveedor"].FillWeight = 40;
                }

                if (DGVDatos.Columns.Contains("Nombre"))
                {
                    DGVDatos.Columns["Nombre"].HeaderText = "Nombre";
                    DGVDatos.Columns["Nombre"].FillWeight = 140;
                }

                if (DGVDatos.Columns.Contains("RNC"))
                {
                    DGVDatos.Columns["RNC"].HeaderText = "RNC";
                    DGVDatos.Columns["RNC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["RNC"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["RNC"].FillWeight = 80;
                }

                if (DGVDatos.Columns.Contains("Telefono"))
                {
                    DGVDatos.Columns["Telefono"].HeaderText = "Teléfono";
                    DGVDatos.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["Telefono"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["Telefono"].FillWeight = 80;
                }

                if (DGVDatos.Columns.Contains("Email"))
                {
                    DGVDatos.Columns["Email"].HeaderText = "Correo Electrónico";
                    DGVDatos.Columns["Email"].FillWeight = 120;
                }

                if (DGVDatos.Columns.Contains("Direccion"))
                {
                    DGVDatos.Columns["Direccion"].HeaderText = "Dirección";
                    DGVDatos.Columns["Direccion"].FillWeight = 150; 
                }

                if (DGVDatos.Columns.Contains("Contacto"))
                {
                    DGVDatos.Columns["Contacto"].HeaderText = "Contacto";
                    DGVDatos.Columns["Contacto"].FillWeight = 100;
                }

                if (DGVDatos.Columns.Contains("Estado"))
                {
                    DGVDatos.Columns["Estado"].HeaderText = "Estado";
                    DGVDatos.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["Estado"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["Estado"].FillWeight = 60;
                }

                if (DGVDatos.Columns.Contains("FechaRegistro"))
                {
                    DGVDatos.Columns["FechaRegistro"].HeaderText = "Fecha";
                    DGVDatos.Columns["FechaRegistro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["FechaRegistro"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["FechaRegistro"].FillWeight = 80;
                }

                if (DGVDatos.Columns.Contains("UsuarioRegistro"))
                {
                    DGVDatos.Columns["UsuarioRegistro"].HeaderText = "Usuario";
                    DGVDatos.Columns["UsuarioRegistro"].FillWeight = 80;
                }

                if (DGVDatos.Columns.Contains("IdUsuarioRegistro"))
                {
                    DGVDatos.Columns["IdUsuarioRegistro"].Visible = false;
                }

            }
            else
            {
                DGVDatos.DataSource = null;
            }

            DGVDatos.Refresh();

            int cantidad = dt != null ? dt.Rows.Count : 0;
            LCantProveedor.Text = "Cantidad de Proveedores: " + cantidad.ToString();
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
                indice = DGVDatos.CurrentRow.Index;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BConsultar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 0)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (DGVDatos.RowCount > 0)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
            ReporteProveedor reporte = new ReporteProveedor();
            reporte.ShowDialog();
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}