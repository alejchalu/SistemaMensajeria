using Controlador;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraTreeList.Nodes;

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
        private Menus M = new Menus();
        private Perfil_Permisos PP = new Perfil_Permisos();
        private const int cGrip = 16;
        private const int cCaption = 32;     
        #endregion

        #region Metodos
        private void Maximizar()
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
        private void CerrarFormularios()
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
        private void CargarPermisos()
        {
            PP._ID_Perfil = Globales.ID_Perfil;
            DataTable Permisos = PP.Listar();

            foreach (TreeListNode nodo in TlOpcionesMenu.Nodes)
            {
                nodo.Visible = false;
                foreach (TreeListNode NodoHijo in nodo.Nodes)
                {
                    NodoHijo.Visible = false;

                }               
            }

            foreach (DataRow Permiso in Permisos.Rows)
            {
                TreeListNode nodo = TlOpcionesMenu.FindNodeByKeyID(Convert.ToInt32(Permiso[0]));
                if (nodo != null)
                {
                    nodo.Visible = true;
                }
            }
        }
        private void Cargar()
        {
            try
            {
                TlOpcionesMenu.ParentFieldName = "ID_Padre";
                TlOpcionesMenu.KeyFieldName = "ID";
                TlOpcionesMenu.DataSource = M.ListarMenu();
                TlOpcionesMenu.Columns[1].Visible = false;

                CargarPermisos();

            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
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
        private void BtnCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();
            IS.Show();
        }
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            Maximizar();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void XtPFormularios_CloseButtonClick(object sender, EventArgs e)
        {
            CerrarFormularios();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void TlOpcionesMenu_RowClick(object sender, DevExpress.XtraTreeList.RowClickEventArgs e)
        {
            if (Convert.ToInt32(e.Node.GetValue("ID_Padre")) != 0 && Convert.ToString(e.Node.GetValue("Formulario")) != "")
            {
                Type Tipo = Type.GetType("Interfaz." + Convert.ToString(e.Node.GetValue("Formulario")));
                Form Formulario = (Form)Activator.CreateInstance(Tipo);
                AbrirFormularios(Formulario, Convert.ToString(e.Node.GetValue("Opciones de menu")));
            }
        }
        #endregion
    }
}
