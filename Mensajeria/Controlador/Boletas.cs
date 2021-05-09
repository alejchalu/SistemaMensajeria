using System;
using BaseDatos;

namespace Controlador
{
    public class Boletas
    {
        #region Variables
        private int ID;
        private string ID_Cliente;
        private string ID_Mensajero;
        private string Descripcion;
        private int Cantidad_Objetos;
        private string Numero_Factura;
        private double Costo;
        private DateTime Fecha_Retiro;
        private DateTime Hora_Retiro;
        private DateTime Fecha_Entrega;
        private DateTime Hora_Entrega;
        private DateTime Fecha_Registro;
        private string Usuario_Registro;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Boletas()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public string _ID_Cliente { get => ID_Cliente; set => ID_Cliente = value; }
        public string _ID_Mensajero { get => ID_Mensajero; set => ID_Mensajero = value; }
        public string _Descripcion { get => Descripcion; set => Descripcion = value; }
        public int _Cantidad_Objetos { get => Cantidad_Objetos; set => Cantidad_Objetos = value; }
        public string _Numero_Factura { get => Numero_Factura; set => Numero_Factura = value; }
        public double _Costo { get => Costo; set => Costo = value; }
        public DateTime _Fecha_Retiro { get => Fecha_Retiro; set => Fecha_Retiro = value; }
        public DateTime _Hora_Retiro { get => Hora_Retiro; set => Hora_Retiro = value; }
        public DateTime _Fecha_Entrega { get => Fecha_Entrega; set => Fecha_Entrega = value; }
        public DateTime _Hora_Entrega { get => Hora_Entrega; set => Hora_Entrega = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        #endregion

        #region Metodos
        public void Insertar()
        {
            C.InsertarBoletas(_ID_Cliente, _ID_Mensajero, _Descripcion, _Cantidad_Objetos, _Numero_Factura,
                _Costo, _Fecha_Retiro, _Hora_Retiro,_Fecha_Entrega,_Hora_Entrega,_Fecha_Registro,_Usuario_Registro);
        }

        public void Actualizar()
        {
            C.ActualizarBoletas(_ID,_ID_Cliente, _ID_Mensajero, _Descripcion, _Cantidad_Objetos, _Numero_Factura,
                _Costo, _Fecha_Retiro, _Hora_Retiro, _Fecha_Entrega, _Hora_Entrega);
        }

        public void Eliminar()
        {
            C.EliminarBoletas(_ID);
        }
        #endregion
    }
}
