using Controlador;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        #region Variables
        private Clientes C = new Clientes();
        #endregion

        #region Metodos
        private void CargarDatosLinea()
        {
            TxtIdentificacion.Text = Convert.ToString(GvClientes.GetRowCellValue(Convert.ToInt32(GvClientes.GetSelectedRows()[0]), "Identificacion"));
            TxtNombre.Text = Convert.ToString(GvClientes.GetRowCellValue(Convert.ToInt32(GvClientes.GetSelectedRows()[0]), "Nombre"));
            TxtTelefono.Text = Convert.ToString(GvClientes.GetRowCellValue(Convert.ToInt32(GvClientes.GetSelectedRows()[0]), "Telefono"));
            CeActivo.Checked = Convert.ToBoolean(GvClientes.GetRowCellValue(Convert.ToInt32(GvClientes.GetSelectedRows()[0]), "Activo"));
            TxtDireccion.Text = Convert.ToString(GvClientes.GetRowCellValue(Convert.ToInt32(GvClientes.GetSelectedRows()[0]), "Direccion"));
            TxtEmail.Text = Convert.ToString(GvClientes.GetRowCellValue(Convert.ToInt32(GvClientes.GetSelectedRows()[0]), "Email"));
            TxtComentarios.Text = Convert.ToString(GvClientes.GetRowCellValue(Convert.ToInt32(GvClientes.GetSelectedRows()[0]), "Comentarios"));
            TxtID.Text = Convert.ToString(GvClientes.GetRowCellValue(Convert.ToInt32(GvClientes.GetSelectedRows()[0]), "ID"));
        }
        private void Eliminar()
        {
            try
            {
                FrmMensaje M = new FrmMensaje();
                if (TxtID.Text == "")
                {
                    M.UnBoton("Debe seleccionar un registro", "Aceptar", Properties.Resources.close);
                }
                else if (M.DosBotones("¿Realmente desea eliminar el registro?", "Si", "No", Properties.Resources.warning, DialogResult.Yes, DialogResult.No) == DialogResult.Yes)
                {
                    C._ID = Convert.ToInt32(TxtID.Text);

                    C.Eliminar();

                    M.UnBoton("Registro eliminado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcClientes.DataSource = C.Listar();
                }
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void Actualizar()
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

                    C.Actualizar();

                    M.UnBoton("Registro actualizado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcClientes.DataSource = C.Listar();
                }
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void Agregar()
        {
            try
            {
                Asignar();

                C.Insertar();

                FrmMensaje M = new FrmMensaje();
                M.UnBoton("Registro ingresado correctamente", "Aceptar", Properties.Resources._checked);

                Limpiar();

                GcClientes.DataSource = C.Listar();
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
                GcClientes.DataSource = C.Listar();
                GvClientes.Columns[0].Visible = false;
                GvClientes.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void Limpiar()
        {
            TxtIdentificacion.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            CeActivo.Checked = false;
            TxtEmail.Clear();
            TxtComentarios.Clear();
            TxtID.Clear();
        }
        private void Asignar()
        {
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                C._ID = Convert.ToInt32(TxtID.Text);
            }
            C._Identificacion = TxtIdentificacion.Text;
            C._Nombre = TxtNombre.Text;
            C._Telefono = TxtTelefono.Text;
            C._Direccion = TxtDireccion.Text;
            C._Activo = CeActivo.Checked;
            C._Email = TxtEmail.Text;
            C._Comentarios = TxtComentarios.Text;
            C._Fecha_Registro = DateTime.Now;
            C._Usuario_Registro = Globales.Usuario;
        }
        #endregion

        #region Eventos
        private void FrmClientes_Load(object sender, System.EventArgs e)
        {
            Cargar();
        }
        private void FrmClientes_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void GvClientes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            CargarDatosLinea();
        }
        #endregion
    }
}
