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
    public partial class FrmPerfiles : Form
    {
        public FrmPerfiles()
        {
            InitializeComponent();
        }
        #region Variables
        private Perfiles P = new Perfiles();
        #endregion

        #region Metodos
        private void CargarDatosLinea()
        {
            TxtNombre.Text = Convert.ToString(GvPerfiles.GetRowCellValue(Convert.ToInt32(GvPerfiles.GetSelectedRows()[0]), "Nombre"));
            CeActivo.Checked = Convert.ToBoolean(GvPerfiles.GetRowCellValue(Convert.ToInt32(GvPerfiles.GetSelectedRows()[0]), "Activo"));
            TxtID.Text = Convert.ToString(GvPerfiles.GetRowCellValue(Convert.ToInt32(GvPerfiles.GetSelectedRows()[0]), "ID"));
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
                    P._ID = Convert.ToInt32(TxtID.Text);

                    P.Eliminar();

                    M.UnBoton("Registro eliminado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcPerfiles.DataSource = P.Listar();
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

                    P.Actualizar();

                    M.UnBoton("Registro actualizado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcPerfiles.DataSource = P.Listar();
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

                P.Insertar();

                FrmMensaje M = new FrmMensaje();
                M.UnBoton("Registro ingresado correctamente", "Aceptar", Properties.Resources._checked);

                Limpiar();

                GcPerfiles.DataSource = P.Listar();
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
                GcPerfiles.DataSource = P.Listar();
                GvPerfiles.Columns[0].Visible = false;
                GvPerfiles.OptionsBehavior.Editable = false;
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
            TxtID.Clear();
        }

        private void Asignar()
        {
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                P._ID = Convert.ToInt32(TxtID.Text);
            }
            P._Nombre = TxtNombre.Text;
            P._Activo = CeActivo.Checked;
            P._Fecha_Registro = DateTime.Now;
            P._Usuario_Registro = Globales.Usuario;
        }
        #endregion

        #region Eventos
        private void FrmPerfiles_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void FrmPerfiles_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GvPerfiles_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            CargarDatosLinea();
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
