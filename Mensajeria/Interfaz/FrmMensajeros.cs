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
    public partial class FrmMensajeros : Form
    {
        public FrmMensajeros()
        {
            InitializeComponent();
        }
        #region Variables
        private Mensajeros Me = new Mensajeros();
        #endregion

        #region Metodos
        private void CargarDatosLinea()
        {
            TxtIdentificacion.Text = Convert.ToString(GvMensajeros.GetRowCellValue(Convert.ToInt32(GvMensajeros.GetSelectedRows()[0]), "Identificación"));
            TxtNombre.Text = Convert.ToString(GvMensajeros.GetRowCellValue(Convert.ToInt32(GvMensajeros.GetSelectedRows()[0]), "Nombre"));
            TxtTelefono.Text = Convert.ToString(GvMensajeros.GetRowCellValue(Convert.ToInt32(GvMensajeros.GetSelectedRows()[0]), "Teléfono"));
            TxtEmail.Text = Convert.ToString(GvMensajeros.GetRowCellValue(Convert.ToInt32(GvMensajeros.GetSelectedRows()[0]), "Email"));
            CeActivo.Checked = Convert.ToBoolean(GvMensajeros.GetRowCellValue(Convert.ToInt32(GvMensajeros.GetSelectedRows()[0]), "Activo"));
            DeFechaIngreso.DateTime = Convert.ToDateTime(GvMensajeros.GetRowCellValue(Convert.ToInt32(GvMensajeros.GetSelectedRows()[0]), "Fecha ingreso"));
            TxtID.Text = Convert.ToString(GvMensajeros.GetRowCellValue(Convert.ToInt32(GvMensajeros.GetSelectedRows()[0]), "ID"));
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
                    Me._ID = Convert.ToInt32(TxtID.Text);

                    Me.Eliminar();

                    M.UnBoton("Registro eliminado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcMensajeros.DataSource = Me.Listar();
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

                Me.Insertar();

                FrmMensaje M = new FrmMensaje();
                M.UnBoton("Registro ingresado correctamente", "Aceptar", Properties.Resources._checked);

                Limpiar();

                GcMensajeros.DataSource = Me.Listar();
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

                    Me.Actualizar();

                    M.UnBoton("Registro actualizado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcMensajeros.DataSource = Me.Listar();
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
                GcMensajeros.DataSource = Me.Listar();
                GvMensajeros.Columns[0].Visible = false;
                GvMensajeros.OptionsBehavior.Editable = false;

                DeFechaIngreso.DateTime = DateTime.Now;
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
            DeFechaIngreso.DateTime = DateTime.Now;
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtID.Clear();
            CeActivo.Checked = false;
        }

        private void Asignar()
        {
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                Me._ID = Convert.ToInt32(TxtID.Text);
            }
            Me._Identificacion = TxtIdentificacion.Text;
            Me._Nombre = TxtNombre.Text;
            Me._Telefono = TxtTelefono.Text;
            Me._Email = TxtEmail.Text;
            Me._Fecha_Ingreso = DeFechaIngreso.DateTime;
            Me._Activo = CeActivo.Checked;
            Me._Fecha_Registro = DateTime.Now;
            Me._Usuario_Registro = Globales.Usuario;
        }
        #endregion

        #region Eventos
        private void FrmMensajeros_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void FrmMensajeros_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GvMensajeros_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
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
