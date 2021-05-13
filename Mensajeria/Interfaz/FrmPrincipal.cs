using DevExpress.Utils.Layout;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #region Variables
        private FrmInicioSesion IS = new FrmInicioSesion();
        private const int cGrip = 16;
        private const int cCaption = 32;
        #endregion

        #region Metodos

        //Cambiar de tamaño al formulario
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        //Mover formulario
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void MostrarOcultarSubMenu(ArrayList Indices)
        {
            foreach (int i in Indices)
            {
                if (PaMenuPrincipal.Rows[i].Visible == false)
                {
                    PaMenuPrincipal.Rows[i].Visible = true;
                }
                else if (PaMenuPrincipal.Rows[i].Visible == true)
                {
                    PaMenuPrincipal.Rows[i].Visible = false;
                }
            }
        }
        private void AbrirFormularios(Form FormularioMostrar, string Nombre)
        {
            FormularioMostrar.FormBorderStyle = FormBorderStyle.None;
            FormularioMostrar.Dock = DockStyle.Fill;
            FormularioMostrar.TopLevel = false;
            XtPFormularios.Visible = true;
            XtPFormularios.Dock = DockStyle.Fill;
            bool EncuentraPagina = false;

            DevExpress.XtraTab.XtraTabPageCollection Paginas = XtPFormularios.TabPages;

            foreach (DevExpress.XtraTab.XtraTabPage ListaPagina in Paginas)
            {
                if (ListaPagina.Text == Nombre)
                {
                    XtPFormularios.SelectedTabPage = ListaPagina;
                    EncuentraPagina = true;
                }
            }
            if (XtPFormularios.TabPages.Count == 0 || EncuentraPagina == false)
            {
                DevExpress.XtraTab.XtraTabPage Pagina = new DevExpress.XtraTab.XtraTabPage();

                Pagina.Text = Nombre;
                Pagina.Controls.Add(FormularioMostrar);
                XtPFormularios.TabPages.Add(Pagina);
                XtPFormularios.SelectedTabPage = Pagina;
                FormularioMostrar.BringToFront();
                FormularioMostrar.Show();
            }
        }
        #endregion

        #region Eventos
        private void BtnProcesos_Click(object sender, EventArgs e)
        {
            ArrayList SubMenus = new ArrayList();
            SubMenus.Add(3);
            SubMenus.Add(4);

            MostrarOcultarSubMenu(SubMenus);
        }
        private void BtnIngresosGastos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmIngresosGastos(), "Ingresos y gastos");
        }
        private void BtnDocumentosMensajeros_Click(object sender, EventArgs e)
        {

        }
        private void BtnMantenimientos_Click(object sender, EventArgs e)
        {
            ArrayList SubMenus = new ArrayList();
            SubMenus.Add(6);
            SubMenus.Add(7);
            SubMenus.Add(8);
            SubMenus.Add(9);
            SubMenus.Add(10);
            SubMenus.Add(11);
            SubMenus.Add(12);

            MostrarOcultarSubMenu(SubMenus);
        }
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmClientes(), "Clientes");
        }
        private void BtnMensajeros_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMensajeros(), "Mensajeros");
        }
        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ArrayList SubMenus = new ArrayList();
            SubMenus.Add(14);
            SubMenus.Add(15);

            MostrarOcultarSubMenu(SubMenus);
        }
        private void BtnRptClientes_Click(object sender, EventArgs e)
        {

        }
        private void BtnRptMensajeros_Click(object sender, EventArgs e)
        {

        }
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmUsuarios(), "Usuarios");
        }
        private void BtnCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();
            IS.Show();
        }
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                WindowState = FormWindowState.Maximized;
            }
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void XtPFormularios_CloseButtonClick(object sender, EventArgs e)
        {
            if (XtPFormularios.TabPages.Count == 1)
            {
                XtPFormularios.TabPages.Remove(XtPFormularios.SelectedTabPage);
                XtPFormularios.Visible = false;
            }
            else
            {
                int Indice = 0;
                Indice = XtPFormularios.SelectedTabPageIndex;
                XtPFormularios.TabPages.Remove(XtPFormularios.SelectedTabPage);
                XtPFormularios.SelectedTabPageIndex = Indice - 1;
            }
        }

        private void BtnRutas_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmRutas(), "Rutas");
        }

        private void BtnPerfiles_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmPerfiles(), "Perfiles");
        }
        #endregion
    }
}
