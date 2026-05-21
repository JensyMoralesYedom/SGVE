using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FConsultaUsuario : Form
    {
        public int vtieneparametro = 0;
        public int indice = 0;
        public string valorparametro = "";

        CNUsuario objUsuario = new CNUsuario();

        public FConsultaUsuario()
        {
            InitializeComponent();
        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            DGVDatos.AllowUserToAddRows = false;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void ConsultaUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir de la consulta?",
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
            DataTable dt = objUsuario.ObtenerUsuario(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;

                DataGridViewCellStyle styleCabeceraCentro = new DataGridViewCellStyle(DGVDatos.ColumnHeadersDefaultCellStyle);
                styleCabeceraCentro.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewCellStyle styleCabeceraIzquierda = new DataGridViewCellStyle(DGVDatos.ColumnHeadersDefaultCellStyle);
                styleCabeceraIzquierda.Alignment = DataGridViewContentAlignment.MiddleLeft;


                if (DGVDatos.Columns.Contains("IdUsuario"))
                {
                    DGVDatos.Columns["IdUsuario"].HeaderText = "ID";
                    DGVDatos.Columns["IdUsuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["IdUsuario"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["IdUsuario"].Visible = true; // AQUÍ HACEMOS VISIBLE EL ID
                    DGVDatos.Columns["IdUsuario"].FillWeight = 40;
                }

                if (DGVDatos.Columns.Contains("Nombre"))
                {
                    DGVDatos.Columns["Nombre"].HeaderText = "Nombre";
                    DGVDatos.Columns["Nombre"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Nombre"].FillWeight = 110;
                }

                if (DGVDatos.Columns.Contains("Apellido"))
                {
                    DGVDatos.Columns["Apellido"].HeaderText = "Apellido";
                    DGVDatos.Columns["Apellido"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Apellido"].FillWeight = 110;
                }

                if (DGVDatos.Columns.Contains("Usuario"))
                {
                    DGVDatos.Columns["Usuario"].HeaderText = "Usuario";
                    DGVDatos.Columns["Usuario"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Usuario"].FillWeight = 100;
                }

                if (DGVDatos.Columns.Contains("Contraseña")) DGVDatos.Columns["Contraseña"].Visible = false;
                if (DGVDatos.Columns.Contains("FechaRegistro")) DGVDatos.Columns["FechaRegistro"].Visible = false;
                if (DGVDatos.Columns.Contains("UltimoAcceso")) DGVDatos.Columns["UltimoAcceso"].Visible = false;

                if (DGVDatos.Columns.Contains("Rol"))
                {
                    DGVDatos.Columns["Rol"].HeaderText = "Rol";
                    DGVDatos.Columns["Rol"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Rol"].FillWeight = 90;
                }

                if (DGVDatos.Columns.Contains("Email"))
                {
                    DGVDatos.Columns["Email"].HeaderText = "Email";
                    DGVDatos.Columns["Email"].HeaderCell.Style = styleCabeceraIzquierda;
                    DGVDatos.Columns["Email"].FillWeight = 140;
                }

                if (DGVDatos.Columns.Contains("Estado"))
                {
                    DGVDatos.Columns["Estado"].HeaderText = "Estado";
                    DGVDatos.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVDatos.Columns["Estado"].HeaderCell.Style = styleCabeceraCentro;
                    DGVDatos.Columns["Estado"].FillWeight = 60;
                }

                lblCantLabel.Text = "Cantidad de Usuarios: " + dt.Rows.Count.ToString();
            }
            else
            {
                DGVDatos.DataSource = null;
                lblCantLabel.Text = "Cantidad de Usuarios: 0";
            }

            DGVDatos.Refresh();
            LCantUsuario.Visible = false;
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
                indice = DGVDatos.CurrentRow.Index;
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
            if (this.DGVDatos.RowCount > 0)
            {
                indice = 0;
                int colVisible = this.DGVDatos.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Index;
                this.DGVDatos.CurrentCell = this.DGVDatos.Rows[indice].Cells[colVisible];
            }
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                int colVisible = this.DGVDatos.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Index;
                this.DGVDatos.CurrentCell = this.DGVDatos.Rows[indice].Cells[colVisible];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice++;
                int colVisible = this.DGVDatos.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Index;
                this.DGVDatos.CurrentCell = this.DGVDatos.Rows[indice].Cells[colVisible];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (this.DGVDatos.RowCount > 0)
            {
                indice = this.DGVDatos.Rows.Count - 1;
                int colVisible = this.DGVDatos.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Index;
                this.DGVDatos.CurrentCell = this.DGVDatos.Rows[indice].Cells[colVisible];
            }
        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
            ReporteUsuario reporte = new ReporteUsuario();
            reporte.ShowDialog();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            BConsultar_Click(sender, e);
        }

        private void lblBuscar_Click(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void PBotones_Paint(object sender, PaintEventArgs e) { }
    }
}