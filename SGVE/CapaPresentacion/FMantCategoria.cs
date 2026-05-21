using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FMantCategoria : Form
    {
        public string valorparametro = "", mensaje = "";

        public FMantCategoria()
        {
            InitializeComponent();
        }

        private void FMantCategoria_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();
        }

        private void FMantCategoria_FormClosing(object sender, FormClosingEventArgs e)
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

        public void LimpiaObjetos()
        {
            tbIdCategoría.Clear();
            tbNombreCategoria.Clear();
            tbDescripción.Clear();

            if (cbEstado.Items.Count > 0)
                cbEstado.SelectedIndex = 0;
        }

        private void HabilitaControles(bool valor)
        {
            tbIdCategoría.ReadOnly = true;
            tbNombreCategoria.Enabled = valor;
            tbDescripción.Enabled = valor;
            cbEstado.Enabled = valor;

            if (Program.nuevo)
                cbEstado.SelectedIndex = 0;
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
                BEditar.Enabled = false;
                BBuscar.Enabled = true;
                BCancelar.Enabled = false;
            }
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbNombreCategoria.Focus();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombreCategoria.Text == String.Empty)
            {
                MessageBox.Show("¡Debe indicar el nombre de la Categoría!");
                tbNombreCategoria.Focus();
                return;
            }

            if (tbDescripción.Text == String.Empty)
            {
                MessageBox.Show("¡Debe indicar la Descripción de la Categoría!");
                tbDescripción.Focus();
                return;
            }

            if (cbEstado.Text == String.Empty)
            {
                MessageBox.Show("¡Debe seleccionar el estado de la Categoría!");
                cbEstado.Focus();
                return;
            }

            try
            {
                int idUsuario = Program.idUsuarioActual > 0 ? Program.idUsuarioActual : 1;

                if (Program.nuevo)
                {
                    mensaje = CNCategoria.Insertar(0, tbNombreCategoria.Text, tbDescripción.Text, cbEstado.Text, DateTime.Now, idUsuario);
                }
                else
                {
                    mensaje = CNCategoria.Actualizar(Program.vidCategoria, tbNombreCategoria.Text, tbDescripción.Text, cbEstado.Text, DateTime.Now, idUsuario);
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
                MessageBox.Show("Error al guardar: " + ex.Message);
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
            if (tbIdCategoría.Text != "")
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("¡Debe de buscar una Categoría para poder Modificar sus datos!");
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
       
            FBuscarCategoria fBuscarCategoria = new FBuscarCategoria();
            fBuscarCategoria.ShowDialog();

            if (Program.modificar)
            {
                RecuperaDatos();  
                BEditar_Click(sender, e);  
            }
            else
            {
                LimpiaObjetos(); 
                BBuscar.Focus();
            }
            
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vidCategoria.ToString();
            CNCategoria cNCategoria = new CNCategoria();
            DataTable dt = cNCategoria.ObtenerCategoria(vparametro);

            foreach (DataRow row in dt.Rows)
            {
                tbIdCategoría.Text = row["IdCategoria"].ToString();
                tbNombreCategoria.Text = row["NombreCategoria"].ToString();
                tbDescripción.Text = row["Descripcion"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }
        }

        private void FMantCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tbNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombreCategoria_Click(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}