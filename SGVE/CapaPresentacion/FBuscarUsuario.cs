using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FBuscarUsuario : Form
    {
        public int indice = 0;
        public int vtieneparametro = 0;
        public string valorparametro = "";

        public FBuscarUsuario()
        {
            InitializeComponent();
        }

        private void FBuscarUsuario_Load(object sender, EventArgs e)
        {
            vtieneparametro = 0;
            Program.idUsuarioActual = 0;
            Program.modificar = false;
            MostrarDatos(); 
            tbBuscar.Focus();
        }

        private void FBuscarUsuario_FormClosing(object sender, FormClosingEventArgs e)
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
            CNUsuario objUsuario = new CNUsuario();
            DGVDatos.DataSource = objUsuario.ObtenerUsuario(valorparametro);
            DGVDatos.AllowUserToAddRows = false;

            if (DGVDatos.Rows.Count > 0)
            {
                DGVDatos.Columns[0].Visible = false; // IdUsuario
                DGVDatos.Columns[4].Visible = false; // Contraseña (Seguridad)
                DGVDatos.Columns[7].Visible = false; // FechaRegistro (Datetime interno)
                DGVDatos.Columns[8].Visible = false; // UltimoAcceso (Datetime interno)

                DGVDatos.Columns[1].Width = 150; // Nombre
                DGVDatos.Columns[2].Width = 150; // Apellido
                DGVDatos.Columns[3].Width = 120; // Usuario
                DGVDatos.Columns[5].Width = 100; // Rol
                DGVDatos.Columns[6].Width = 200; // Email
                DGVDatos.Columns[9].Width = 90;  // Estado
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
            Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
            {
                if (DGVDatos.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    Program.modificar = true;
                    Program.idUsuarioActual = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
                    Close();
                }
            }
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

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                BAceptar_Click(sender, e);
            }
        }

        private void BBuscarDato_Click(object sender, EventArgs e)
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