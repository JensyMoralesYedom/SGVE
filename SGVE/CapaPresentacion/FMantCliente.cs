using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FMantCliente : Form
    {
        public string mensaje = "";

        public FMantCliente()
        {
            InitializeComponent();
        }

        private void FMantCliente_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitarBotones();
        }

        private void FMantCliente_FormClosing(object sender, FormClosingEventArgs e)
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

        public void LimpiarObjetos()
        {
            tbIdCliente.Clear();
            tbNombreCliente.Clear();
            tbApellidoCliente.Clear();
            tbTelefonoCliente.Clear();
            tbDireccionCliente.Clear();
            cbTipoDocumento.SelectedIndex = -1;
            tbIDDocumento.Clear();
            cbSexo.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
        }

        public void HabilitaControles(bool valor)
        {
            tbIdCliente.ReadOnly = true;
            tbNombreCliente.Enabled = valor;
            tbApellidoCliente.Enabled = valor;
            tbTelefonoCliente.Enabled = valor;
            tbDireccionCliente.Enabled = valor;
            cbTipoDocumento.Enabled = valor;
            tbIDDocumento.Enabled = valor;
            cbSexo.Enabled = valor;
            cbEstado.Enabled = valor;

            if (Program.nuevo)
            {
                cbTipoDocumento.SelectedIndex = 0;
                cbSexo.SelectedIndex = 0;
                cbEstado.SelectedIndex = 0;
            }
        }

        public void HabilitarBotones()
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
                BEditar.Enabled = !string.IsNullOrEmpty(tbIdCliente.Text);
                BBuscar.Enabled = true;
                BCancelar.Enabled = false;
            }
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitarBotones();
            tbNombreCliente.Focus();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombreCliente.Text == string.Empty || tbApellidoCliente.Text == string.Empty)
            {
                MessageBox.Show("El nombre y el apellido son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombreCliente.Focus();
                return;
            }

            try
            {
                if (Program.nuevo)
                {
                    mensaje = CNCliente.Insertar(
                        0,
                        tbNombreCliente.Text,
                        tbApellidoCliente.Text,
                        tbTelefonoCliente.Text,
                        tbDireccionCliente.Text,
                        cbTipoDocumento.Text,
                        tbIDDocumento.Text,
                        cbSexo.Text,
                        cbEstado.Text
                    );
                }
                else
                {
                    mensaje = CNCliente.Actualizar(
                        Program.vidCliente,
                        tbNombreCliente.Text,
                        tbApellidoCliente.Text,
                        tbTelefonoCliente.Text,
                        tbDireccionCliente.Text,
                        cbTipoDocumento.Text,
                        tbIDDocumento.Text,
                        cbSexo.Text,
                        cbEstado.Text
                    );
                }

                if (mensaje == "OK")
                {
                    MessageBox.Show("La operación se ha completado con éxito. Los datos han sido registrados en el sistema.",
                                    "Engage - Confirmación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    Program.nuevo = false;
                    Program.modificar = false;
                    HabilitarBotones();
                    LimpiarObjetos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (tbIdCliente.Text != "")
            {
                Program.modificar = true;
                HabilitarBotones();
            }
            else
            {
                MessageBox.Show("¡Debe buscar un Cliente para poder modificar sus datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitarBotones();
            LimpiarObjetos();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            FBuscarCliente fBuscarCliente = new FBuscarCliente();
            fBuscarCliente.ShowDialog();

            if (Program.modificar)
            {
                RecuperarDatos();
                Program.modificar = false;
                Program.nuevo = false;
                HabilitarBotones();
            }
            else
            {
                LimpiarObjetos();
                BBuscar.Focus();
            }
        }

        public void RecuperarDatos()
        {
            string vparametro = Program.vidCliente.ToString();
            DataTable dt = CNCliente.ObtenerCliente(vparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    tbIdCliente.Text = row["IdCliente"].ToString();
                    tbNombreCliente.Text = row["Nombre"].ToString();
                    tbApellidoCliente.Text = row["Apellido"].ToString();
                    tbTelefonoCliente.Text = row["Telefono"].ToString();
                    tbDireccionCliente.Text = row["Direccion"].ToString();
                    cbTipoDocumento.Text = row["TipoDocumento"].ToString();
                    tbIDDocumento.Text = row["DocumentoId"].ToString();
                    cbSexo.Text = row["Sexo"].ToString();
                    cbEstado.Text = row["Estado"].ToString();
                }
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FMantCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tbIDDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}