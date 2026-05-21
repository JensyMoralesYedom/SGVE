using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FLogin : Form
    {
        private bool usuarioActivo = false;
        private bool passActivo = false;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FLogin()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Usuario";
            txtUsuario.ForeColor = Color.FromArgb(180, 180, 180);
            txtPassword.Text = "Contraseña";
            txtPassword.ForeColor = Color.FromArgb(180, 180, 180);
            txtPassword.UseSystemPasswordChar = false;

            this.ActiveControl = panelLeft;
        }

        private void panelContainer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelRight_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (!usuarioActivo)
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
                usuarioActivo = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.FromArgb(180, 180, 180);
                usuarioActivo = false;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (!passActivo)
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
                passActivo = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.FromArgb(180, 180, 180);
                txtPassword.UseSystemPasswordChar = false;
                passActivo = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (usuario == "" || usuario == "Usuario" || password == "" || password == "Contraseña")
            {
                MostrarError("Por favor ingrese usuario y contraseña.");
                return;
            }

            btnIngresar.Enabled = false;
            btnIngresar.Text = "Verificando...";

            try
            {
                if (ValidarCredenciales(usuario, password))
                {
                    MessageBox.Show("¡Bienvenido al sistema ENGAGE!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FMenu fMenu = new FMenu();
                    fMenu.FormClosed += (s, args) => this.Close();
                    fMenu.Show();
                    this.Hide();
                }
                else
                {
                    MostrarError("Usuario o contraseña incorrectos, o inactivo.");
                    RestaurarBoton();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fallo de conexión a BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RestaurarBoton();
            }
        }

        private void RestaurarBoton()
        {
            btnIngresar.Enabled = true;
            btnIngresar.Text = "INGRESAR";
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.FromArgb(180, 180, 180);
            txtPassword.UseSystemPasswordChar = false;
            passActivo = false;
            txtUsuario.Focus();
        }

        private bool ValidarCredenciales(string usuario, string password)
        {
            CNUsuario objUsuario = new CNUsuario();
            DataTable dt = objUsuario.ObtenerUsuario(usuario);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string bdUsuario = row["Usuario"].ToString().Trim();
                    string bdPassword = row["Contraseña"].ToString().Trim();
                    string bdEstado = row["Estado"].ToString().Trim();

                    bool usuarioCoincide = bdUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase);
                    bool passCoincide = (bdPassword == password);
                    bool estadoCoincide = bdEstado.Equals("Activo", StringComparison.OrdinalIgnoreCase);

                    if (usuarioCoincide && passCoincide && estadoCoincide)
                    {
                        Program.idUsuarioActual = Convert.ToInt32(row["IdUsuario"]);
                        Program.nombreUsuarioActual = row["Nombre"].ToString() + " " + row["Apellido"].ToString();

                        return true;
                    }
                }
            }
            return false;
        }

        private void MostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            lblError.Visible = true;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                lblError.Visible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIngresar_Click(sender, e);
        }

        private void FLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(Color.FromArgb(241, 14, 15), 2))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        private void picLogo_Click(object sender, EventArgs e) { }
        private void lblSlogan_Click(object sender, EventArgs e) { }
        private void picIconUsuario_Click(object sender, EventArgs e) { }
        private void picIconPass_Click(object sender, EventArgs e) { }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }
    }
}