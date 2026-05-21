using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FConsultaCliente : Form
    {
        public int vtieneparametro = 0, indice = 0;
        public string valorparametro = "";

        public FConsultaCliente()
        {
            InitializeComponent();
        }

        private void FConsultaCliente_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void FConsultaCliente_FormClosing(object sender, FormClosingEventArgs e)
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
            DataTable dt = CNCliente.ObtenerCliente(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;

                DataGridViewCellStyle styleCabeceraCentro = new DataGridViewCellStyle(DGVDatos.ColumnHeadersDefaultCellStyle);
                styleCabeceraCentro.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewCellStyle styleCabeceraIzquierda = new DataGridViewCellStyle(DGVDatos.ColumnHeadersDefaultCellStyle);
                styleCabeceraIzquierda.Alignment = DataGridViewContentAlignment.MiddleLeft;


                if (DGVDatos.Columns.Contains("IdCliente"))
                {
                    DGVDatos.Columns["IdCliente"].HeaderText = "ID";
                    DGVDatos.Columns["IdCliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["IdCliente"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["IdCliente"].FillWeight = 40; 
                }

                if (DGVDatos.Columns.Contains("Nombre"))
                {
                    DGVDatos.Columns["Nombre"].HeaderText = "Nombre";
                    DGVDatos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    DGVDatos.Columns["Nombre"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Nombre"].FillWeight = 110;
                }

                if (DGVDatos.Columns.Contains("Apellido"))
                {
                    DGVDatos.Columns["Apellido"].HeaderText = "Apellido";
                    DGVDatos.Columns["Apellido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    DGVDatos.Columns["Apellido"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Apellido"].FillWeight = 110;
                }

                if (DGVDatos.Columns.Contains("Telefono"))
                {
                    DGVDatos.Columns["Telefono"].HeaderText = "Teléfono";
                    DGVDatos.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    DGVDatos.Columns["Telefono"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Telefono"].FillWeight = 100;
                }

                if (DGVDatos.Columns.Contains("Direccion"))
                {
                    DGVDatos.Columns["Direccion"].HeaderText = "Dirección";
                    DGVDatos.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    DGVDatos.Columns["Direccion"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Direccion"].FillWeight = 140; // Reducimos el exceso de espacio
                }

                if (DGVDatos.Columns.Contains("TipoDocumento"))
                {
                    DGVDatos.Columns["TipoDocumento"].HeaderText = "Tipo Doc.";
                    DGVDatos.Columns["TipoDocumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    DGVDatos.Columns["TipoDocumento"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["TipoDocumento"].FillWeight = 85;
                }

                if (DGVDatos.Columns.Contains("DocumentoId"))
                {
                    DGVDatos.Columns["DocumentoId"].HeaderText = "Documento";
                    DGVDatos.Columns["DocumentoId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    DGVDatos.Columns["DocumentoId"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["DocumentoId"].FillWeight = 100;
                }

                if (DGVDatos.Columns.Contains("Sexo"))
                {
                    DGVDatos.Columns["Sexo"].HeaderText = "Sexo";
                    DGVDatos.Columns["Sexo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    DGVDatos.Columns["Sexo"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Sexo"].FillWeight = 85;
                }

                if (DGVDatos.Columns.Contains("Estado"))
                {
                    DGVDatos.Columns["Estado"].HeaderText = "Estado";
                    DGVDatos.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["Estado"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["Estado"].FillWeight = 60;
                }

                // 3. Forzar el orden correcto de izquierda a derecha
                string[] orden = { "IdCliente", "Nombre", "Apellido", "Telefono", "Direccion", "TipoDocumento", "DocumentoId", "Sexo", "Estado" };
                int displayIndex = 0;
                foreach (string col in orden)
                {
                    if (DGVDatos.Columns.Contains(col))
                    {
                        DGVDatos.Columns[col].DisplayIndex = displayIndex++;
                    }
                }

                LCantCliente.Text = "Cantidad de Clientes: " + dt.Rows.Count.ToString();
            }
            else
            {
                DGVDatos.DataSource = null;
                LCantCliente.Text = "Cantidad de Clientes: 0";

                if (valorparametro != "")
                {
                    MessageBox.Show("No se encontraron datos para mostrar.", "Mensaje de SIGEMP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            DGVDatos.Refresh();
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

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
            ReporteCliente reporte = new ReporteCliente();
            reporte.ShowDialog();
        }

        // --- Navegación ---
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

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
                indice = DGVDatos.CurrentRow.Index;
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LCantCliente_Click(object sender, EventArgs e)
        {
        }
    }
}