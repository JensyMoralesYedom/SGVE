using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FMenu : Form
    {
        bool expandiendo = false;
        int alturaMaxima = 0;
        Panel panelActivo = null;
        private bool menuExpandido = true;
        private int anchoExpandido = 215;
        private int anchoColapsado = 60;

        private Form formularioActivo = null;

        public FMenu()
        {
            InitializeComponent();
        }

        private void OcultarAbrirSubMenu(Panel panel, int alt)
        {
            if (panelActivo != null && panelActivo != panel)
            {
                panelActivo.Height = 0;
            }

            panelActivo = panel;
            alturaMaxima = alt;
            expandiendo = panel.Height == 0;
            timerAnimacion.Start();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Program.nombreUsuarioActual))
            {
                lbUsuario.Text = Program.nombreUsuarioActual;
            }
            else
            {
                lbUsuario.Text = "Administrador";
            }

            pMantenimiento.Height = 0;
            pProcesos.Height = 0;
            pConsultasReportes.Height = 0;

            splitContainer1.SplitterDistance = anchoExpandido;

            timerAnimacion.Interval = 10;
            timerMenu.Interval = 10;
        }

        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                if (!formularioActivo.IsDisposed)
                {
                    return;
                }
            }

            splitContainer1.Panel2.Controls.Clear();

            formularioActivo = formularioHijo;

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(formularioHijo);
            splitContainer1.Panel2.Tag = formularioHijo;

            formularioHijo.Show();
        }

        private void AjustarBotonesSubMenu(bool expandido)
        {
            int nuevoPadding = expandido ? 45 : 15;

            Panel[] paneles = new Panel[] { pMantenimiento, pProcesos, pConsultasReportes };

            foreach (Panel pnl in paneles)
            {
                foreach (Control ctrl in pnl.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.Padding = new Padding(nuevoPadding, 0, 0, 0);

                        if (!expandido)
                        {
                            if (btn.Tag == null) btn.Tag = btn.Text;
                            btn.Text = "";
                        }
                        else
                        {
                            if (btn.Tag != null) btn.Text = btn.Tag.ToString();
                        }
                    }
                }
            }
        }

        private void bMantenimiento_Click(object sender, EventArgs e)
        {
            OcultarAbrirSubMenu(pMantenimiento, 150);
        }

        private void bProcesos_Click(object sender, EventArgs e)
        {
            OcultarAbrirSubMenu(pProcesos, 60);
        }

        private void bConsultasReportes_Click(object sender, EventArgs e)
        {
            OcultarAbrirSubMenu(pConsultasReportes, 180);
        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FDashBoard());
        }

        private void bAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FAbout());
        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            if (panelActivo == null) return;

            if (expandiendo)
            {
                panelActivo.Height += 15;
                if (panelActivo.Height >= alturaMaxima)
                {
                    panelActivo.Height = alturaMaxima;
                    timerAnimacion.Stop();
                }
            }
            else
            {
                panelActivo.Height -= 15;
                if (panelActivo.Height <= 0)
                {
                    panelActivo.Height = 0;
                    timerAnimacion.Stop();
                }
            }
        }

        private void bHamburguesa_Click(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                pMantenimiento.Height = 0;
                pProcesos.Height = 0;
                pConsultasReportes.Height = 0;

                bMantenimiento.Text = "";
                bProcesos.Text = "";
                bConsultasReportes.Text = "";
                bDashboard.Text = ""; // Se oculta
                bAcercaDe.Text = "";
                lbUsuario.Visible = false;

                AjustarBotonesSubMenu(false);
            }

            timerMenu.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                if (splitContainer1.SplitterDistance > anchoColapsado)
                {
                    splitContainer1.SplitterDistance -= 15;
                    if (splitContainer1.SplitterDistance < anchoColapsado) splitContainer1.SplitterDistance = anchoColapsado;
                }
                else
                {
                    menuExpandido = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                if (splitContainer1.SplitterDistance < anchoExpandido)
                {
                    splitContainer1.SplitterDistance += 15;
                    if (splitContainer1.SplitterDistance > anchoExpandido) splitContainer1.SplitterDistance = anchoExpandido;
                }
                else
                {
                    menuExpandido = true;
                    timerMenu.Stop();

                    bMantenimiento.Text = "  Mantenimientos";
                    bProcesos.Text = "  Procesos";
                    bConsultasReportes.Text = "  Consultas y Reportes";
                    bDashboard.Text = "  Dashboard"; // Se muestra
                    bAcercaDe.Text = "  Acerca de...";
                    lbUsuario.Visible = true;

                    AjustarBotonesSubMenu(true);
                }
            }
        }

        private void bMantCLiente_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FMantCliente()); }
        private void bMantProveedor_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FMantProveedor()); }
        private void bMantUsuario_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FMantUsuario()); }
        private void bMantProducto_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FMantProducto()); }
        private void bCategoria_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FMantCategoria()); }
        private void bConsultaCategoria_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FConsultaCategoria()); }
        private void bConsultaCliente_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FConsultaCliente()); }
        private void bConsultaProveedor_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FConsultaProveedor()); }
        private void bConsultaUsuario_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FConsultaUsuario()); }
        private void bConsultaProducto_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FConsultaProducto()); }
        private void bMaestroDetalle_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FMaestroDetalleFactura()); }
        private void bVenta_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FVender()); }
        private void bAjusteInventario_Click(object sender, EventArgs e) { AbrirFormularioEnPanel(new FInventario()); }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        // HOVERS
        private void CambiarColorEnter(object sender, EventArgs e) { ((Button)sender).BackColor = ColorTranslator.FromHtml("#C94444"); }
        private void CambiarColorLeave(object sender, EventArgs e) { ((Button)sender).BackColor = ColorTranslator.FromHtml("#25273C"); }

        private void bMantenimiento_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bMantenimiento_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bMantCLiente_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bMantCLiente_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bMantProveedor_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bMantProveedor_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bMantUsuario_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bMantUsuario_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bMantProducto_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bMantProducto_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bCategoria_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bCategoria_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bProcesos_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bProcesos_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bVenta_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bVenta_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bAjusteInventario_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bAjusteInventario_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bConsultasReportes_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bConsultasReportes_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bConsultaCliente_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bConsultaCliente_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bConsultaProveedor_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bConsultaProveedor_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bConsultaUsuario_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bConsultaUsuario_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bConsultaProducto_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bConsultaProducto_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bConsultaCategoria_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bConsultaCategoria_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }
        private void bMaestroDetalle_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bMaestroDetalle_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }

        private void bDashboard_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bDashboard_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }

        private void bAcercaDe_MouseEnter(object sender, EventArgs e) { CambiarColorEnter(sender, e); }
        private void bAcercaDe_MouseLeave(object sender, EventArgs e) { CambiarColorLeave(sender, e); }

        private void FMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¡Esto le hará salir del sistema! \n ¿Seguro que desea hacerlo?",
        "Mensaje del Sistema",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}