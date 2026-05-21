using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FConsultaCategoria : Form
    {
        public int vtieneparametro = 0, indice = 0;
        public string valorparametro = "";
        CNCategoria objNegocio = new CNCategoria();

        public FConsultaCategoria()
        {
            InitializeComponent();
        }

        private void FConsultaCategoria_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void FConsultaCategoria_FormClosing(object sender, FormClosingEventArgs e)
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
            DataTable dt = objNegocio.ObtenerCategoria(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;

                DataGridViewCellStyle styleCabeceraCentro = new DataGridViewCellStyle(DGVDatos.ColumnHeadersDefaultCellStyle);
                styleCabeceraCentro.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewCellStyle styleCabeceraIzquierda = new DataGridViewCellStyle(DGVDatos.ColumnHeadersDefaultCellStyle);
                styleCabeceraIzquierda.Alignment = DataGridViewContentAlignment.MiddleLeft;

                if (DGVDatos.Columns.Contains("IdCategoria"))
                {
                    DGVDatos.Columns["IdCategoria"].HeaderText = "ID";
                    DGVDatos.Columns["IdCategoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["IdCategoria"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["IdCategoria"].FillWeight = 40;
                }

                if (DGVDatos.Columns.Contains("NombreCategoria"))
                {
                    DGVDatos.Columns["NombreCategoria"].HeaderText = "Categoría";
                    DGVDatos.Columns["NombreCategoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    DGVDatos.Columns["NombreCategoria"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["NombreCategoria"].FillWeight = 120;
                }

                if (DGVDatos.Columns.Contains("Descripcion"))
                {
                    DGVDatos.Columns["Descripcion"].HeaderText = "Descripción";
                    DGVDatos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    DGVDatos.Columns["Descripcion"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Descripcion"].FillWeight = 160;
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
                    DGVDatos.Columns["FechaRegistro"].HeaderText = "F. Registro";
                    DGVDatos.Columns["FechaRegistro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["FechaRegistro"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["FechaRegistro"].FillWeight = 90;
                }

                if (DGVDatos.Columns.Contains("NombreUsuario"))
                {
                    DGVDatos.Columns["NombreUsuario"].HeaderText = "Usuario";
                    DGVDatos.Columns["NombreUsuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    DGVDatos.Columns["NombreUsuario"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["NombreUsuario"].FillWeight = 90;
                }

                if (DGVDatos.Columns.Contains("IdUsuarioRegistro"))
                {
                    DGVDatos.Columns["IdUsuarioRegistro"].Visible = false;
                }

                LCantCategoria.Text = "Cantidad de Categorías: " + dt.Rows.Count.ToString();
            }
            else
            {
                DGVDatos.DataSource = null;
                LCantCategoria.Text = "Cantidad de Categorías: 0";
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

        private void BImprimir_Click(object sender, EventArgs e)
        {
            ReporteCategoria reporte = new ReporteCategoria();
            reporte.ShowDialog();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
                indice = DGVDatos.CurrentRow.Index;
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}