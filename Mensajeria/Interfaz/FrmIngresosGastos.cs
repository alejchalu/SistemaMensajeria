using Controlador;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmIngresosGastos : Form
    {
        public FrmIngresosGastos()
        {
            InitializeComponent();
        }

        #region Variables
        private Ingresos_Gastos IG = new Ingresos_Gastos();
        #endregion

        #region Metodos
        private void CargarDatosLinea()
        {
            TxtDescripcion.Text = Convert.ToString(GvIngresosGastos.GetRowCellValue(Convert.ToInt32(GvIngresosGastos.GetSelectedRows()[0]), "Descripción"));
            TxtMonto.Text = Convert.ToString(GvIngresosGastos.GetRowCellValue(Convert.ToInt32(GvIngresosGastos.GetSelectedRows()[0]), "Monto"));
            CbTipo.Text = Convert.ToString(GvIngresosGastos.GetRowCellValue(Convert.ToInt32(GvIngresosGastos.GetSelectedRows()[0]), "Tipo"));
            DeFecha.DateTime = Convert.ToDateTime(GvIngresosGastos.GetRowCellValue(Convert.ToInt32(GvIngresosGastos.GetSelectedRows()[0]), "Fecha transacción"));
            TxtID.Text = Convert.ToString(GvIngresosGastos.GetRowCellValue(Convert.ToInt32(GvIngresosGastos.GetSelectedRows()[0]), "ID"));
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
                    IG._ID = Convert.ToInt32(TxtID.Text);

                    IG.Eliminar();

                    M.UnBoton("Registro eliminado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcIngresosGastos.DataSource = IG.Listar();
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

                IG.Insertar();

                FrmMensaje M = new FrmMensaje();
                M.UnBoton("Registro ingresado correctamente", "Aceptar", Properties.Resources._checked);

                Limpiar();

                GcIngresosGastos.DataSource = IG.Listar();
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

                    IG.Actualizar();

                    M.UnBoton("Registro actualizado correctamente", "Aceptar", Properties.Resources._checked);

                    Limpiar();

                    GcIngresosGastos.DataSource = IG.Listar();
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
                GcIngresosGastos.DataSource = IG.Listar();
                GvIngresosGastos.Columns[0].Visible = false;
                GvIngresosGastos.OptionsBehavior.Editable = false;

                DeFecha.DateTime = DateTime.Now;
                CbTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        } 
        private void Limpiar()
        {
            CbTipo.SelectedIndex = 0;
            DeFecha.DateTime = DateTime.Now;
            TxtMonto.Clear();
            TxtDescripcion.Clear();
            TxtID.Clear();
        }
        private void Asignar()
        {
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                IG._ID = Convert.ToInt32(TxtID.Text);
            }
            IG._Tipo = CbTipo.Text;
            IG._Descripcion = TxtDescripcion.Text;
            IG._Monto = Convert.ToDouble(TxtMonto.Text);
            IG._Fecha_Transaccion = DeFecha.DateTime;
            IG._Fecha_Registro = DateTime.Now;
            IG._Usuario_Registro = Globales.Usuario;
        }
        #endregion

        #region Eventos
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
        private void FrmIngresosGastos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void FrmIngresosGastos_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void GvIngresosGastos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            CargarDatosLinea();
        }
        #endregion
    }
}
