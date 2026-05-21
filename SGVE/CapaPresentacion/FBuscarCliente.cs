using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FBuscarCliente : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";

        public FBuscarCliente()
        {
            InitializeComponent();
        }

        private void FBuscarCliente_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidCliente = 0; 
            Program.modificar = false;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void FBuscarCliente_FormClosing(object sender, FormClosingEventArgs e)
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

            DataTable dt = CNCliente.ObtenerCliente(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;

                if (DGVDatos.Columns.Count >= 9)
                {
                    DGVDatos.Columns[0].Width = 60;  // IdCliente
                    DGVDatos.Columns[1].Width = 150; // Nombre
                    DGVDatos.Columns[2].Width = 150; // Apellido
                    DGVDatos.Columns[3].Width = 100; // Telefono
                    DGVDatos.Columns[4].Width = 200; // Direccion
                    DGVDatos.Columns[5].Width = 100; // TipoDocumento
                    DGVDatos.Columns[6].Width = 120; // DocumentoId
                    DGVDatos.Columns[7].Width = 90;  // Sexo
                    DGVDatos.Columns[8].Width = 80;  // Estado
                }
            }
            else
            {
                DGVDatos.DataSource = null;
            }

            DGVDatos.Refresh();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos(); 
        }

        private void BBuscarDato_Click(object sender, EventArgs e)
        {
            MostrarDatos(); 
            tbBuscar.Focus();
        }

        private void baceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null && DGVDatos.Rows.Count > 0)
            {
                Program.vidCliente = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
                Program.modificar = true;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista.", "Mensaje de SIGEMP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false;
            this.Close(); 
        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                baceptar_Click(sender, e);
            }
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
            {
                indice = DGVDatos.CurrentRow.Index;
            }
        }

        private void bPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 0)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[0];
            }
        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[0];
            }
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[0];
            }
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            if (DGVDatos.RowCount > 0)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[0];
            }
        }
    }
}