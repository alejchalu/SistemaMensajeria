using Controlador;
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
                    if (nodo.Checked == false)
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
        private void MarcarDesmascar(bool Estado, int ID)
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
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
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
                TlOpcionesMenu.DataSource = M.ListarMenuPermisos();
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
            TlOpcionesMenu.NodeChanged -= TlOpcionesMenu_NodeChanged;
            Cargar();
            TlOpcionesMenu.NodeChanged += TlOpcionesMenu_NodeChanged;
        }

        private void CbPerfiles_EditValueChanged(object sender, EventArgs e)
        {
            TlOpcionesMenu.NodeChanged -= TlOpcionesMenu_NodeChanged;
            CargarMarcados();
            TlOpcionesMenu.NodeChanged += TlOpcionesMenu_NodeChanged;
        }

        private void TlOpcionesMenu_NodeChanged(object sender, DevExpress.XtraTreeList.NodeChangedEventArgs e)
        {

            if (e.ChangeType == DevExpress.XtraTreeList.NodeChangeTypeEnum.CheckedState)
            {
                if (CbPerfiles.EditValue != null)
                {
                    if (e.Node.CheckState == CheckState.Checked || e.Node.CheckState == CheckState.Indeterminate)
                    {
                        MarcarDesmascar(true, Convert.ToInt32(e.Node.GetValue("ID")));
                    }
                    else
                    {
                        MarcarDesmascar(false, Convert.ToInt32(e.Node.GetValue("ID")));
                    }
                }
                else
                {
                    e.Node.CheckState = CheckState.Unchecked;
                }
            }

        }

        private void TlOpcionesMenu_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            if (CbPerfiles.EditValue == null)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton("Debe seleccionar un perfil", "Aceptar", Properties.Resources.close);
            }
        }
        #endregion


    }
}
