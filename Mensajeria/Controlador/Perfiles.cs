using System;
using System.Data;
using BaseDatos;

namespace Controlador
{
    public class Perfiles
    {
        #region Variables
        private int ID;
        private string Nombre;
        private DateTime Fecha_Registro;
        private string Usuario_Registro;
        private bool Activo;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Perfiles()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        public bool _Activo { get => Activo; set => Activo = value; }
        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return C.ListarPerfiles();
        }

        public DataTable ListarCombo()
        {
            return C.ListarPerfilesCombo();
        }
        public void Insertar()
        {
            C.InsertarPerfiles(_Nombre, _Fecha_Registro, _Usuario_Registro, _Activo);
        }

        public void Actualizar()
        {
            C.ActualizarPerfiles(_ID, _Nombre, _Activo);
        }

        public void Eliminar()
        {
            C.EliminarPerfiles(_ID);
        }
        #endregion
    }
}
