using System;
using BaseDatos;

namespace Controlador
{
    public class Rutas
    {
        #region Variables
        private int ID;
        private string Nombre;
        private string ID_Mensajero;
        private string ID_Cliente;
        private DateTime Fecha_Registro;
        private string Usuario_Registro;
        private bool Activo;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Rutas()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public string _ID_Mensajero { get => ID_Mensajero; set => ID_Mensajero = value; }
        public string _ID_Cliente { get => ID_Cliente; set => ID_Cliente = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        public bool _Activo { get => Activo; set => Activo = value; }
        #endregion

        #region Metodos
        public void Insertar()
        {
            C.InsertarRutas(_Nombre, _ID_Mensajero,_Fecha_Registro, _Usuario_Registro, _Activo);
        }

        public void Actualizar()
        {
            C.ActualizarRutas(_ID, _Nombre, _ID_Mensajero, _Activo);
        }

        public void Eliminar()
        {
            C.EliminarRutas(_ID);
        }
        #endregion
    }
}
