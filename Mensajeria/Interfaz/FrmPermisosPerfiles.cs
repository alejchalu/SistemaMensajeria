using Controlador;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmPermisosPerfiles : Form
    {
        public FrmPermisosPerfiles()
        {
            InitializeComponent();
        }

        #region Variables
        private Perfiles P = new Perfiles();
        private Perfil_Permisos PP = new Perfil_Permisos();
        private Menus M = new Menus();
        #endregion

        #region Metodos
        private void CargarMarcados()
        {
            try
            {

                PP._ID_Perfil = Convert.ToInt32(CbPerfiles.EditValue);
                DataTable Lista = PP.Listar();

                TlOpcionesMenu.UncheckAll();

                foreach (DataRow Linea in Lista.Rows)
                {
                    TreeListNode nodo = TlOpcionesMenu.FindNodeByKeyID(Convert.ToInt32(Linea[0]));
                    if (nodo != null && nodo.Checked == false)
                    {
                        nodo.Checked = true;
                    }

                }
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }

        }
        private void MarcarDesmascarDB(bool Estado, int ID)
        {
            try
            {
                PP._ID_Perfil = Convert.ToInt32(CbPerfiles.EditValue);
                PP._ID = ID;
                PP._Fecha_Registro = DateTime.Now;
                PP._Usuario_Registro = Globales.Usuario;

                if (Estado)
                {
                    PP.Insertar();
                }
                else
                {
                    PP.Eliminar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void Cargar()
        {
            try
            {
                CbPerfiles.Properties.DataSource = P.ListarCombo();
                DataTable Tabla = (DataTable)CbPerfiles.Properties.DataSource;
                CbPerfiles.Properties.ValueMember = "ID";
                CbPerfiles.Properties.DisplayMember = "Nombre";
                CbPerfiles.Properties.DropDownRows = Tabla.Rows.Count;
                CbPerfiles.Properties.PopulateColumns();
                CbPerfiles.Properties.Columns[CbPerfiles.Properties.ValueMember].Visible = false;

                TlOpcionesMenu.ParentFieldName = "ID_Padre";
                TlOpcionesMenu.KeyFieldName = "ID";
                TlOpcionesMenu.DataSource = M.ListarMenu();
                TlOpcionesMenu.Columns[1].Visible = false;
                TlOpcionesMenu.OptionsBehavior.AllowIndeterminateCheckState = false;
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void MarcarDesmarcar(TreeListNode Nodo)
        {
            try
            {
                if (Nodo.Checked)
                {

                    //Cuando es un nodo padre
                    foreach (TreeListNode NodoHijo in Nodo.Nodes)
                    {
                        NodoHijo.Checked = true;
                        MarcarDesmascarDB(true, Convert.ToInt32(NodoHijo.GetValue("ID")));
                    }

                    MarcarDesmascarDB(true, Convert.ToInt32(Nodo.GetValue("ID")));
                }
                else
                {

                    //Cuando es un nodo padre
                    foreach (TreeListNode NodoHijo in Nodo.Nodes)
                    {
                        NodoHijo.Checked = false;
                        MarcarDesmascarDB(false, Convert.ToInt32(NodoHijo.GetValue("ID")));
                    }

                    MarcarDesmascarDB(false, Convert.ToInt32(Nodo.GetValue("ID")));
                }

                //Cuando es un nodo hijo
                if (Nodo.ParentNode != null)
                {
                    bool HijoMarcado = false;
                    Nodo = Nodo.ParentNode;
                    foreach (TreeListNode NodoHijo in Nodo.Nodes)
                    {
                        if (NodoHijo.CheckState == CheckState.Checked)
                        {
                            HijoMarcado = true;
                        }
                    }

                    if (HijoMarcado == false)
                    {
                        Nodo.CheckState = CheckState.Unchecked;
                        MarcarDesmascarDB(false, Convert.ToInt32(Nodo.GetValue("ID")));
                    }
                    else if(Nodo.CheckState != CheckState.Checked)
                    {
                        Nodo.CheckState = CheckState.Checked;
                        MarcarDesmascarDB(true, Convert.ToInt32(Nodo.GetValue("ID")));
                    }
                }
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        #endregion

        #region Eventos
        private void FrmPermisosPerfiles_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void CbPerfiles_EditValueChanged(object sender, EventArgs e)
        {
            CargarMarcados();
        }

        private void TlOpcionesMenu_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            if (CbPerfiles.EditValue == null)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton("Debe seleccionar un perfil", "Aceptar", Properties.Resources.close);
                e.Node.CheckState = CheckState.Unchecked;
            }
            else
            {
                MarcarDesmarcar(e.Node);
            }
        }
        #endregion


    }
}
