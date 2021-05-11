using System;
using System.Data;
using BaseDatos;

namespace Controlador
{
    public class Ingresos_Gastos
    {
        #region Variables
        private int ID;
        private DateTime Fecha_Transaccion;
        private double Monto;
        private string Descripcion;
        private string Tipo;
        private DateTime Fecha_Registro;
        private string Usuario_Registro;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Ingresos_Gastos()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public DateTime _Fecha_Transaccion { get => Fecha_Transaccion; set => Fecha_Transaccion = value; }
        public double _Monto { get => Monto; set => Monto = value; }
        public string _Descripcion { get => Descripcion; set => Descripcion = value; }
        public string _Tipo { get => Tipo; set => Tipo = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return C.ListarIngresosGastos();
        }
        public void Insertar()
        {
            C.InsertarIngresos_Gastos(_Fecha_Transaccion, _Monto, _Descripcion, _Tipo, _Fecha_Registro, _Usuario_Registro);
        }

        public void Actualizar()
        {
            C.ActualizarIngresos_Gastos(_ID, _Fecha_Transaccion, _Monto, _Descripcion, _Tipo);
        }

        public void Eliminar()
        {
            C.EliminarIngresos_Gastos(_ID);
        }
        #endregion
    }
}
