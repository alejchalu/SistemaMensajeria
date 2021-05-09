using Controlador;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        #region Variables
        private Usuarios U = new Usuarios();
        private Perfiles P = new Perfiles();
        #endregion

        #region Metodos
        private void Limpiar()
        {
            TxtNombre.Clear();
            TxtContraseña.Clear();
            TxtUsuario.Clear();
            CeActivo.Checked = false;
            CbPerfil.EditValue = null;
            TxtID.Clear();
        }

        private void Asignar()
        {
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                U._ID = Convert.ToInt32(TxtID.Text);
            }             
            U._Nombre = TxtNombre.Text;
            U._Usuario = TxtUsuario.Text;
            U._Contraseña = TxtContraseña.Text;
            U._Activo = CeActivo.Checked;
            U._Fecha_Registro = DateTime.Now;
            U._Usuario_Registro = Globales.Usuario;
            U._ID_Perfil = Convert.ToInt32(CbPerfil.EditValue);
        }
        #endregion

        #region Eventos
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {           
            GcUsuarios.DataSource = U.Listar();
            GvUsuarios.Columns[0].Visible = false;
            GvUsuarios.Columns[4].Visible = false;
            GvUsuarios.OptionsBehavior.Editable = false;

            CbPerfil.Properties.DataSource = P.ListarCombo();
            DataTable Tabla = (DataTable)CbPerfil.Properties.DataSource;
            CbPerfil.Properties.ValueMember = "ID";
            CbPerfil.Properties.DisplayMember = "Nombre";
            CbPerfil.Properties.DropDownRows = Tabla.Rows.Count;
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();

                U.Insertar();

                FrmMensaje M = new FrmMensaje();
                M.UnBoton("Registro ingresado correctamente", "Aceptar", Properties.Resources._checked);

                Limpiar();

                GcUsuarios.DataSource = U.Listar();
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void GvUsuarios_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            TxtUsuario.Text = Convert.ToString(GvUsuarios.GetRowCellValue(Convert.ToInt32(GvUsuarios.GetSelectedRows()[0]), "Usuario"));
            TxtContraseña.Text = Convert.ToString(GvUsuarios.GetRowCellValue(Convert.ToInt32(GvUsuarios.GetSelectedRows()[0]), "Contraseña"));
            TxtNombre.Text = Convert.ToString(GvUsuarios.GetRowCellValue(Convert.ToInt32(GvUsuarios.GetSelectedRows()[0]), "Nombre"));
            CeActivo.Checked = Convert.ToBoolean(GvUsuarios.GetRowCellValue(Convert.ToInt32(GvUsuarios.GetSelectedRows()[0]), "Activo"));
            CbPerfil.EditValue = Convert.ToInt32(GvUsuarios.GetRowCellValue(Convert.ToInt32(GvUsuarios.GetSelectedRows()[0]), "ID_Perfil"));
            TxtID.Text = Convert.ToString(GvUsuarios.GetRowCellValue(Convert.ToInt32(GvUsuarios.GetSelectedRows()[0]), "ID"));
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMensaje M = new FrmMensaje();
                if (TxtID.Text == "")
                {
                    M.UnBoton("Debe seleccionar un registro", "Aceptar", Properties.Resources.close);
                }
                else if (M.DosBotones("¿Realmente desea actualizar el registro?", "Si", "No", Properties.Resources.warning, DialogResult.Yes, DialogResult.No) == DialogResult.Yes)
                {
                    Asignar();

                    U.Actualizar();

                    M.UnBoton("Registro actualizado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcUsuarios.DataSource = U.Listar();
                }
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMensaje M = new FrmMensaje();
                if (TxtID.Text == "")
                {
                    M.UnBoton("Debe seleccionar un registro", "Aceptar", Properties.Resources.close);
                }
                else if (M.DosBotones("¿Realmente desea eliminar el registro?", "Si", "No", Properties.Resources.warning,DialogResult.Yes,DialogResult.No) == DialogResult.Yes)
                {
                    U._ID = Convert.ToInt32(TxtID.Text);

                    U.Eliminar();

                    M.UnBoton("Registro eliminado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcUsuarios.DataSource = U.Listar();
                }
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void FrmUsuarios_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion    
    }
}
