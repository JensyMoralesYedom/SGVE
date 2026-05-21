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
    public partial class FMantProveedor : Form
    {
        public string valorparametro = "", mensaje = "";

        public FMantProveedor()
        {
            InitializeComponent();
        }

        private void FMantProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea salir de este formulario?",
                                "Mensaje del Sistema",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiaObjetos()
        {
            tbIdProveedor.Clear();
            tbNombreProveedor.Clear();
            tbRNC.Clear();
            tbTelefono.Clear();
            tbEmail.Clear();
            tbDireccion.Clear();
            tbPersonaContacto.Clear();

            if (cbEstado.Items.Count > 0)
                cbEstado.SelectedIndex = 0;
        }

        private void HabilitaControles(bool valor)
        {
            tbIdProveedor.ReadOnly = true;
            tbNombreProveedor.Enabled = valor;
            tbRNC.Enabled = valor;
            tbTelefono.Enabled = valor;
            tbEmail.Enabled = valor;
            tbDireccion.Enabled = valor;
            tbPersonaContacto.Enabled = valor;
            cbEstado.Enabled = valor;

            if (Program.nuevo)
            {
                if (cbEstado.Items.Count > 0)
                    cbEstado.SelectedIndex = 0;
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
                BEditar.Enabled = (tbIdProveedor.Text != string.Empty);
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
            tbNombreProveedor.Focus();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombreProveedor.Text == string.Empty)
            {
                MessageBox.Show("¡Debe indicar el Nombre del Proveedor!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombreProveedor.Focus();
                return;
            }
            if (tbRNC.Text == string.Empty)
            {
                MessageBox.Show("¡Debe indicar el RNC del Proveedor!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRNC.Focus();
                return;
            }
            if (tbTelefono.Text == string.Empty)
            {
                MessageBox.Show("¡Debe indicar el Teléfono del Proveedor!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTelefono.Focus();
                return;
            }
            if (tbDireccion.Text == string.Empty)
            {
                MessageBox.Show("¡Debe indicar la Dirección del Proveedor!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDireccion.Focus();
                return;
            }
            if (cbEstado.Text == string.Empty)
            {
                MessageBox.Show("¡Debe seleccionar el Estado del Proveedor!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbEstado.Focus();
                return;
            }

            try
            {
                if (Program.nuevo)
                {
                    mensaje = CNProveedor.Insertar(
                        0, 
                        tbNombreProveedor.Text,
                        tbRNC.Text,
                        tbTelefono.Text,
                        tbEmail.Text,
                        tbDireccion.Text,
                        tbPersonaContacto.Text,
                        cbEstado.Text,
                        DateTime.Now,
                        Program.idUsuarioActual
                    );
                }
                else
                {
                    mensaje = CNProveedor.Actualizar(
                        Program.vidProveedor, 
                        tbNombreProveedor.Text,
                        tbRNC.Text,
                        tbTelefono.Text,
                        tbEmail.Text,
                        tbDireccion.Text,
                        tbPersonaContacto.Text,
                        cbEstado.Text,
                        DateTime.Now,
                        Program.idUsuarioActual
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
                MessageBox.Show("Error al guardar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!tbIdProveedor.Text.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Proveedor para poder Modificar sus datos!",
                                "Mensaje del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void MantProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            FBuscarProveedor fBuscarProveedor = new FBuscarProveedor();
            fBuscarProveedor.ShowDialog();

            if (Program.modificar)
            {
                RecuperaDatos(Program.vidProveedor.ToString());

                Program.modificar = false;

                HabilitaBotones();
            }
            else
            {
                LimpiaObjetos();
                BBuscar.Focus();
            }
        }

        private void dtpFechaRegistro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FMantProveedor_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
        }

        public void RecuperaDatos(string vparametro)
        {
            DataTable dt = CNProveedor.ObtenerProveedor(vparametro);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos para el proveedor seleccionado.",
                                "Mensaje del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                tbIdProveedor.Text = row["IdProveedor"].ToString();
                tbNombreProveedor.Text = row["NombreProveedor"].ToString();
                tbRNC.Text = row["RNC"].ToString();
                tbTelefono.Text = row["Telefono"].ToString();
                tbEmail.Text = row["Email"].ToString();
                tbDireccion.Text = row["Direccion"].ToString();
                tbPersonaContacto.Text = row["PersonaContacto"].ToString();
                cbEstado.Text = row["Estado"].ToString();

                Program.vidProveedor = Convert.ToInt32(row["IdProveedor"]);
            }
        }
    }
}