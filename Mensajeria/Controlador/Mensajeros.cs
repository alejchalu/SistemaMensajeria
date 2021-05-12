using System;
using System.Data;
using BaseDatos;

namespace Controlador
{
    public class Mensajeros
    {
        #region Variables
        private string Identificacion;
        private string Nombre;
        private string Telefono;
        private string Email;
        private DateTime Fecha_Ingreso;
        private DateTime Fecha_Registro;
        private string Usuario_Registro;
        private bool Activo;
        private int ID;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Mensajeros()
        {          
        }
        #endregion

        #region Gets y Sets
        public string _Identificacion { get => Identificacion; set => Identificacion = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public string _Telefono { get => Telefono; set => Telefono = value; }
        public string _Email { get => Email; set => Email = value; }
        public DateTime _Fecha_Ingreso { get => Fecha_Ingreso; set => Fecha_Ingreso = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        public bool _Activo { get => Activo; set => Activo = value; }
        public int _ID { get => ID; set => ID = value; }
        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return C.ListarMensajeros();
        }
        public void Insertar()
        {
            C.InsertarMensajeros(_Identificacion, _Nombre, _Telefono,_Email, _Fecha_Ingreso, _Fecha_Registro, _Usuario_Registro, _Activo);
        }

        public void Actualizar()
        {
            C.ActualizarMensajeros(_ID,_Identificacion, _Nombre, _Telefono,_Email, _Fecha_Ingreso, _Activo);
        }

        public void Eliminar()
        {
            C.EliminarMensajeros(_ID);
        }
        #endregion
    }
}
