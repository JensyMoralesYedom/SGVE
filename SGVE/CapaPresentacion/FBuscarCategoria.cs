using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FBuscarCategoria : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";
        CNCategoria cNCategoria = new CNCategoria();

        public FBuscarCategoria()
        {
            InitializeComponent();
        }

        private void FBuscarCategoria_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidCategoria = 0;
            Program.modificar = false;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void FBuscarCategoria_FormClosing(object sender, FormClosingEventArgs e)
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

        public void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            DataTable dt = cNCategoria.ObtenerCategoria(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;

                DataGridViewCellStyle styleCentro = new DataGridViewCellStyle(DGVDatos.ColumnHeadersDefaultCellStyle);
                styleCentro.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (DGVDatos.Columns.Contains("IdCategoria"))
                {
                    DGVDatos.Columns["IdCategoria"].HeaderText = "ID";
                    DGVDatos.Columns["IdCategoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["IdCategoria"].HeaderCell.Style = styleCentro;
                    DGVDatos.Columns["IdCategoria"].FillWeight = 40;
                }

                if (DGVDatos.Columns.Contains("NombreCategoria"))
                {
                    DGVDatos.Columns["NombreCategoria"].HeaderText = "Categoría";
                    DGVDatos.Columns["NombreCategoria"].FillWeight = 100;
                }

                if (DGVDatos.Columns.Contains("Descripcion"))
                {
                    DGVDatos.Columns["Descripcion"].HeaderText = "Descripción";
                    DGVDatos.Columns["Descripcion"].FillWeight = 140;
                }

                if (DGVDatos.Columns.Contains("Estado"))
                {
                    DGVDatos.Columns["Estado"].HeaderText = "Estado";
                    DGVDatos.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["Estado"].HeaderCell.Style = styleCentro;
                    DGVDatos.Columns["Estado"].FillWeight = 60;
                }

                if (DGVDatos.Columns.Contains("FechaRegistro"))
                {
                    DGVDatos.Columns["FechaRegistro"].HeaderText = "F. Registro";
                    DGVDatos.Columns["FechaRegistro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["FechaRegistro"].HeaderCell.Style = styleCentro;
                    DGVDatos.Columns["FechaRegistro"].FillWeight = 80;
                }

                if (DGVDatos.Columns.Contains("NombreUsuario"))
                {
                    DGVDatos.Columns["NombreUsuario"].HeaderText = "Usuario";
                    DGVDatos.Columns["NombreUsuario"].FillWeight = 80;
                }

                if (DGVDatos.Columns.Contains("IdUsuarioRegistro"))
                    DGVDatos.Columns["IdUsuarioRegistro"].Visible = false;
            }
            else
            {
                DGVDatos.DataSource = null;
            }
        }

        private void baceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
            {
                Program.modificar = true;
                Program.vidCategoria = Convert.ToInt32(DGVDatos.CurrentRow.Cells["IdCategoria"].Value);
                this.Close();
            }
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false;
            Program.vidCategoria = 0;
            this.Close();
        }

        private void BBuscarDato_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
            {
                indice = DGVDatos.CurrentRow.Index;
            }
        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                baceptar_Click(sender, e);
            }
        }

        private void bPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 0)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            if (DGVDatos.RowCount > 0)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.FirstDisplayedCell?.ColumnIndex ?? 0];
            }
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}