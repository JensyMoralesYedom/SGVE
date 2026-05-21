using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FBuscarProveedor : Form
    {
        public int indice = 0;
        public int vtieneparametro = 0;
        public string valorparametro = "";

        private bool cierreControlado = false;

        public FBuscarProveedor()
        {
            InitializeComponent();
        }

        private void FBuscarProveedor_Load(object sender, EventArgs e)
        {
            valorparametro = "%";
            vtieneparametro = 0;
            Program.vidProveedor = 0;
            Program.modificar = false;
            DGVDatos.AllowUserToAddRows = false;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void FBuscarProveedor_FormClosing(object sender, FormClosingEventArgs e)
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
            DataTable dt = CNProveedor.ObtenerProveedor(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;

                if (DGVDatos.Columns.Count >= 11)
                {
                    DGVDatos.Columns[0].Width = 80;     
                    DGVDatos.Columns[1].Width = 200;    
                    DGVDatos.Columns[2].Width = 100;    
                    DGVDatos.Columns[3].Width = 110;    
                    DGVDatos.Columns[4].Width = 150;    
                    DGVDatos.Columns[5].Width = 200;    
                    DGVDatos.Columns[6].Width = 150;    
                    DGVDatos.Columns[7].Width = 90;     
                    DGVDatos.Columns[8].Width = 110;    
                    DGVDatos.Columns[9].Visible = false;   
                    DGVDatos.Columns[10].Visible = false;  
                }

                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[0].Cells[0];
            }
            else if (dt != null && dt.Rows.Count == 0)
            {
                DGVDatos.DataSource = dt;
                MessageBox.Show("No se encontraron proveedores con ese criterio.",
                                "Mensaje del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se retornó ningún valor!",
                                "Mensaje del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
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
            cierreControlado = true;
            Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null && DGVDatos.Rows.Count > 0)
            {
                Program.modificar = true;
                Program.vidProveedor = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
                cierreControlado = true;
                Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista.",
                                "Mensaje del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 0)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[0];
            }
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[0];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[0];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (DGVDatos.RowCount > 0)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[0];
            }
        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            BAceptar_Click(sender, EventArgs.Empty);
        }

        private void BBuscarDato_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text.Trim() != string.Empty)
            {
                vtieneparametro = 1;
                valorparametro = tbBuscar.Text.Trim(); 
            }
            else
            {
                vtieneparametro = 0;
                valorparametro = "";
            }
            MostrarDatos();
        }

        private void TbBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BBuscarDato_Click(sender, e);
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            BBuscarDato_Click(sender, e);
        }
    }
}