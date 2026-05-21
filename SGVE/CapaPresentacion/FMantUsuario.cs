using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FMantUsuario : Form
    {
        public string valorparametro = "", mensaje = "";

        public FMantUsuario()
        {
            InitializeComponent();
        }

        private void FMantUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir del formulario?",
                                "Mensaje del Sistema",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiaObjetos()
        {
            tbIdUsuario.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbUsuario.Clear();
            tbContraseña.Clear();
            tbEmail.Clear();

            if (cbRol.Items.Count > 0) cbRol.SelectedIndex = 0;
            if (cbEstado.Items.Count > 0) cbEstado.SelectedIndex = 0;
        }

        private void HabilitaControles(bool valor)
        {
            tbIdUsuario.ReadOnly = true;

            tbNombre.Enabled = valor;
            tbApellido.Enabled = valor;
            tbUsuario.Enabled = valor;
            tbContraseña.Enabled = valor;
            tbEmail.Enabled = valor;
            cbRol.Enabled = valor;
            cbEstado.Enabled = valor;

            if (Program.nuevo)
            {
                if (cbRol.Items.Count > 0) cbRol.SelectedIndex = 0;
                if (cbEstado.Items.Count > 0) cbEstado.SelectedIndex = 0;
            }
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
                BEditar.Enabled = !string.IsNullOrEmpty(tbIdUsuario.Text);
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
            tbNombre.Focus();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text)) { MessageBox.Show("¡Debe indicar el Nombre!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbNombre.Focus(); return; }
            if (string.IsNullOrWhiteSpace(tbApellido.Text)) { MessageBox.Show("¡Debe indicar el Apellido!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbApellido.Focus(); return; }
            if (string.IsNullOrWhiteSpace(tbUsuario.Text)) { MessageBox.Show("¡Debe indicar el Usuario!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbUsuario.Focus(); return; }
            if (string.IsNullOrWhiteSpace(tbContraseña.Text)) { MessageBox.Show("¡Debe indicar la Contraseña!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbContraseña.Focus(); return; }
            if (string.IsNullOrWhiteSpace(cbRol.Text)) { MessageBox.Show("¡Debe seleccionar el Rol!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbRol.Focus(); return; }
            if (string.IsNullOrWhiteSpace(cbEstado.Text)) { MessageBox.Show("¡Debe seleccionar el Estado!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbEstado.Focus(); return; }

            try
            {
                DateTime fechaActual = DateTime.Now;

                if (Program.nuevo)
                {
                    mensaje = CNUsuario.Insertar(
                        0, tbNombre.Text.Trim(), tbApellido.Text.Trim(), tbUsuario.Text.Trim(),
                        tbContraseña.Text.Trim(), cbRol.Text, tbEmail.Text.Trim(),
                        fechaActual, fechaActual, cbEstado.Text
                    );
                }
                else
                {
                    mensaje = CNUsuario.Actualizar(
                        Program.idUsuarioActual, tbNombre.Text.Trim(), tbApellido.Text.Trim(), tbUsuario.Text.Trim(),
                        tbContraseña.Text.Trim(), cbRol.Text, tbEmail.Text.Trim(),
                        fechaActual, fechaActual, cbEstado.Text
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
                    LimpiaObjetos();
                    HabilitaBotones();
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

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            LimpiaObjetos();
            HabilitaBotones();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbIdUsuario.Text))
            {
                Program.modificar = true;
                HabilitaBotones();
                tbNombre.Focus();
            }
        }

        private void MantUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            Program.idUsuarioActual = 0;

            FBuscarUsuario fBuscar = new FBuscarUsuario();
            fBuscar.ShowDialog();

            if (Program.idUsuarioActual != 0) 
            {
                RecuperaDatos();

                Program.modificar = false;
                Program.nuevo = false;

                HabilitaBotones(); 
            }
            else
            {
                LimpiaObjetos();
                BBuscar.Focus();
            }
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.idUsuarioActual.ToString();
            CNUsuario objNegocio = new CNUsuario();
            DataTable dt = objNegocio.ObtenerUsuario(vparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                tbIdUsuario.Text = row["IdUsuario"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbApellido.Text = row["Apellido"].ToString();
                tbUsuario.Text = row["Usuario"].ToString();
                tbContraseña.Text = row["Contraseña"].ToString();
                cbRol.Text = row["Rol"].ToString();
                tbEmail.Text = row["Email"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void tbIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblIdUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void FMantUsuario_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}