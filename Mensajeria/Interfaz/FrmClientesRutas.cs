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
            CbRutas.Properties.DataSource = R.ListarCombo();
            DataTable Tabla = (DataTable)CbRutas.Properties.DataSource;
            CbRutas.Properties.ValueMember = "ID";
            CbRutas.Properties.DisplayMember = "Nombre";
            CbRutas.Properties.DropDownRows = Tabla.Rows.Count;
            CbRutas.Properties.PopulateColumns();
            CbRutas.Properties.Columns[CbRutas.Properties.ValueMember].Visible = false;
        }
        private void CargarGrids()
        {
            RC._ID_Rutas = Convert.ToInt32(CbRutas.EditValue);
            GcAsignados.DataSource = RC.ListarAsignados();
            //GvAsignados.Columns[0].Visible = false;
            GvAsignados.OptionsBehavior.Editable = false;

            GcNoAsignados.DataSource = RC.ListarNoAsignados(ClientesAsignados());
            //GvNoAsignados.Columns[0].Visible = false;
            GvNoAsignados.OptionsBehavior.Editable = false;
        }
        private void Asignar()
        {
            foreach (int item in GvNoAsignados.GetSelectedRows())
            {
                
                GvAsignados.AddNewRow();
                int newRowHandle = GvAsignados.FocusedRowHandle;
                GvAsignados.SetRowCellValue(newRowHandle, "ID", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "ID"));
                GvAsignados.SetRowCellValue(newRowHandle, "Nombre", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "Nombre"));
                GvAsignados.SetRowCellValue(newRowHandle, "Teléfono", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "Teléfono"));
                GvAsignados.SetRowCellValue(newRowHandle, "Dirección", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "Dirección"));
                GvAsignados.SetRowCellValue(newRowHandle, "Email", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "Email"));
                GvAsignados.SetRowCellValue(newRowHandle, "Comentarios", GvNoAsignados.GetRowCellValue(Convert.ToInt32(item), "Comentarios"));
                GvAsignados.SetRowCellValue(newRowHandle, "Fecha registro", DateTime.Now);
                GvAsignados.SetRowCellValue(newRowHandle, "Usuario registro", Globales.Usuario);
            }

            GvNoAsignados.DeleteSelectedRows();
        }
        private string ClientesAsignados()
        {
            string IDs = "";
            DataTable Tabla = (DataTable)GcAsignados.DataSource;
            foreach (DataRow row in Tabla.Rows)
            {
                IDs = IDs + row["ID"].ToString() + ",";
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
        #endregion
    }
}
