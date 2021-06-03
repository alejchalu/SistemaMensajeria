using BaseDatos;
using System;
using System.Data;

namespace Controlador
{
    public class Documentos_Mensajeros
    {
        #region Variables
        private int ID;
        private int ID_Mensajero;
        private int ID_Documento;
        private string Metodo;
        private string Comentarios;
        private DateTime Fecha_Registro;
        private string Usuario_Registro;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Documentos_Mensajeros()
        {

        }
        #endregion

        #region Gets y sets
        public int _ID { get => ID; set => ID = value; }
        public int _ID_Mensajero { get => ID_Mensajero; set => ID_Mensajero = value; }
        public int _ID_Documento { get => ID_Documento; set => ID_Documento = value; }
        public string _Metodo { get => Metodo; set => Metodo = value; }
        public string _Comentarios { get => Comentarios; set => Comentarios = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        #endregion

        #region Metodos
        public DataTable ListarComboDocumentos()
        {
            return C.ListarComboDocumentos();
        }

        public void Insertar()
        {
            C.InsertarDocumentos_Mensajeros(_ID_Mensajero,_ID_Documento,_Metodo,_Comentarios,_Fecha_Registro, _Usuario_Registro);
        }
        #endregion
    }
}
