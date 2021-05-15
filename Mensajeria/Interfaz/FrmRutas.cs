using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmRutas : Form
    {
        public FrmRutas()
        {
            InitializeComponent();
        }

        #region Variables
        private Rutas R = new Rutas();
        private Mensajeros Me = new Mensajeros();
        #endregion

        #region Metodos
        private void CargarDatosLineas()
        {
            TxtNombre.Text = Convert.ToString(GvRutas.GetRowCellValue(Convert.ToInt32(GvRutas.GetSelectedRows()[0]), "Nombre"));
            CeActivo.Checked = Convert.ToBoolean(GvRutas.GetRowCellValue(Convert.ToInt32(GvRutas.GetSelectedRows()[0]), "Activo"));
            CbMensajero.EditValue = Convert.ToInt32(GvRutas.GetRowCellValue(Convert.ToInt32(GvRutas.GetSelectedRows()[0]), "ID_Mensajero"));
            TxtID.Text = Convert.ToString(GvRutas.GetRowCellValue(Convert.ToInt32(GvRutas.GetSelectedRows()[0]), "ID"));
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
                    R._ID = Convert.ToInt32(TxtID.Text);

                    R.Eliminar();

                    M.UnBoton("Registro eliminado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcRutas.DataSource = R.Listar();
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

                    R.Actualizar();

                    M.UnBoton("Registro actualizado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcRutas.DataSource = R.Listar();
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

                R.Insertar();

                FrmMensaje M = new FrmMensaje();
                M.UnBoton("Registro ingresado correctamente", "Aceptar", Properties.Resources._checked);

                Limpiar();

                GcRutas.DataSource = R.Listar();
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
                GcRutas.DataSource = R.Listar();
                GvRutas.Columns[0].Visible = false;
                GvRutas.Columns[2].Visible = false;
                GvRutas.OptionsBehavior.Editable = false;

                CbMensajero.Properties.DataSource = Me.ListarCombo();
                DataTable Tabla = (DataTable)CbMensajero.Properties.DataSource;
                CbMensajero.Properties.ValueMember = "ID";
                CbMensajero.Properties.DisplayMember = "Nombre";
                CbMensajero.Properties.DropDownRows = Tabla.Rows.Count;
                CbMensajero.Properties.PopulateColumns();
                CbMensajero.Properties.Columns[CbMensajero.Properties.ValueMember].Visible = false;
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        } 
        private void Limpiar()
        {
            TxtNombre.Clear();
            CeActivo.Checked = false;
            CbMensajero.SelectionLength = 0;
            TxtID.Clear();
        }

        private void Asignar()
        {
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                R._ID = Convert.ToInt32(TxtID.Text);
            }
            R._Nombre = TxtNombre.Text;
            R._Activo = CeActivo.Checked;
            R._Fecha_Registro = DateTime.Now;
            R._Usuario_Registro = Globales.Usuario;
            R._ID_Mensajero = Convert.ToInt32(CbMensajero.EditValue);
        }
        #endregion

        #region Eventos
        private void GvRutas_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            CargarDatosLineas();
        }

        private void FrmRutas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void FrmRutas_Click(object sender, EventArgs e)
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
        #endregion
    }
}
