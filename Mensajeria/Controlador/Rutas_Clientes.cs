using System;
using System.Collections;
using BaseDatos;

namespace Controlador
{
    class Rutas_Clientes
    {
        #region Variables
        private int ID;
        private int ID_Rutas;
        private string ID_Cliente;
        private DateTime Fecha_Registro;
        private string Usuario_Registro;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Rutas_Clientes()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public int _ID_Rutas { get => ID_Rutas; set => ID_Rutas = value; }
        public string _ID_Cliente { get => ID_Cliente; set => ID_Cliente = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        #endregion

        #region Metodos
        public void Insertar()
        {
            C.InsertarRutas_Clientes(_ID_Rutas, _ID_Cliente, _Fecha_Registro, _Usuario_Registro);
        }

        public void Actualizar()
        {
            C.ActualizarRutas_Clientes(_ID, _ID_Rutas, _ID_Cliente);
        }

        public void Eliminar()
        {
            C.EliminarRutas_Clientes(_ID);
        }
        #endregion
    }
}
