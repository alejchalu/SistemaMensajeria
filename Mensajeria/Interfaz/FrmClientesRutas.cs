using Controlador;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmClientesRutas : Form
    {
        public FrmClientesRutas()
        {
            InitializeComponent();
        }

        #region Variables
        private Rutas_Clientes RC = new Rutas_Clientes();
        private Rutas R = new Rutas();
        #endregion

        #region Metodos
        private void Cargar()
        {
            try
            {
                CbRutas.Properties.DataSource = R.ListarCombo();
                DataTable Tabla = (DataTable)CbRutas.Properties.DataSource;
                CbRutas.Properties.ValueMember = "ID";
                CbRutas.Properties.DisplayMember = "Nombre";
                CbRutas.Properties.DropDownRows = Tabla.Rows.Count;
                CbRutas.Properties.PopulateColumns();
                CbRutas.Properties.Columns[CbRutas.Properties.ValueMember].Visible = false;
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void CargarGrids()
        {
            try
            {
                RC._ID_Rutas = Convert.ToInt32(CbRutas.EditValue);
                GcAsignados.DataSource = RC.ListarAsignados();
                GvAsignados.Columns[0].Visible = false;
                GvAsignados.Columns[1].Visible = false;
                GvAsignados.OptionsBehavior.Editable = false;

                GcNoAsignados.DataSource = RC.ListarNoAsignados(ClientesAsignados());
                GvNoAsignados.Columns[0].Visible = false;
                GvNoAsignados.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void NoAsignar()
        {
            try
            {
                foreach (int item in GvAsignados.GetSelectedRows())
                {

                    GvNoAsignados.AddNewRow();
                    int Indice = GvNoAsignados.FocusedRowHandle;
                    GvNoAsignados.SetRowCellValue(Indice, "ID", GvAsignados.GetRowCellValue(Convert.ToInt32(item), "ID_Cliente"));
                    GvNoAsignados.SetRowCellValue(Indice, "Nombre", GvAsignados.GetRowCellValue(Convert.ToInt32(item), "Nombre"));
                    GvNoAsignados.SetRowCellValue(Indice, "Teléfono", GvAsignados.GetRowCellValue(Convert.ToInt32(item), "Teléfono"));
                    GvNoAsignados.SetRowCellValue(Indice, "Dirección", GvAsignados.GetRowCellValue(Convert.ToInt32(item), "Dirección"));
                    GvNoAsignados.SetRowCellValue(Indice, "Email", GvAsignados.GetRowCellValue(Convert.ToInt32(item), "Email"));
                    GvNoAsignados.SetRowCellValue(Indice, "Comentarios", GvAsignados.GetRowCellValue(Convert.ToInt32(item), "Comentarios"));

                    RC._ID_Rutas = Convert.ToInt32(GvAsignados.GetRowCellValue(item, "ID_Rutas"));
                    RC._ID_Cliente = Convert.ToInt32(GvAsignados.GetRowCellValue(item, "ID_Cliente"));
                    RC.Eliminar();

                    GvNoAsignados.UpdateCurrentRow();
                }

                GvAsignados.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void Asignar()
        {
            try
            {
                foreach (int item in GvNoAsignados.GetSelectedRows())
                {
                    GvAsignados.AddNewRow();
                    int Indice = GvAsignados.FocusedRowHandle;
                    GvAsignados.SetRowCellValue(Indice, "ID_Rutas", Convert.ToInt32(CbRutas.EditValue));
                    GvAsignados.SetRowCellValue(Indice, "ID_Cliente", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "ID"));
                    GvAsignados.SetRowCellValue(Indice, "Nombre", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "Nombre"));
                    GvAsignados.SetRowCellValue(Indice, "Teléfono", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "Teléfono"));
                    GvAsignados.SetRowCellValue(Indice, "Dirección", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "Dirección"));
                    GvAsignados.SetRowCellValue(Indice, "Email", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "Email"));
                    GvAsignados.SetRowCellValue(Indice, "Comentarios", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "Comentarios"));
                    GvAsignados.SetRowCellValue(Indice, "Fecha registro", DateTime.Now);
                    GvAsignados.SetRowCellValue(Indice, "Usuario registro", Globales.Usuario);

                    RC._ID_Rutas = Convert.ToInt32(CbRutas.EditValue);
                    RC._ID_Cliente = Convert.ToInt32(GvNoAsignados.GetRowCellValue(item, "ID"));
                    RC._Fecha_Registro = DateTime.Now;
                    RC._Usuario_Registro = Globales.Usuario;
                    RC.Insertar();

                    GvAsignados.UpdateCurrentRow();

                }

                GvNoAsignados.DeleteSelectedRows();
                
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private string ClientesAsignados()
        {
            string IDs = "";
            DataTable Tabla = (DataTable)GcAsignados.DataSource;
            foreach (DataRow row in Tabla.Rows)
            {
                IDs = IDs + row["ID_Cliente"].ToString() + ",";
            }

            return IDs;
        }
        #endregion

        #region Eventos
        private void FrmClientesRutas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void CbRutas_EditValueChanged(object sender, EventArgs e)
        {
            CargarGrids();
        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            Asignar();
        }

        private void BtnNoAsignar_Click(object sender, EventArgs e)
        {
            NoAsignar();
        }
        #endregion
    }
}
