using System;
using System.Data;
using BaseDatos;

namespace Controlador
{
    public class Perfil_Permisos
    {
        #region Variables
        private int ID_Perfil;
        private int ID;
        private DateTime Fecha_Registro;
        private string Usuario_Registro;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Perfil_Permisos()
        {
        }
        #endregion

        #region Gets y Sets
        public int _ID_Perfil { get => ID_Perfil; set => ID_Perfil = value; }
        public int _ID { get => ID; set => ID = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return C.ListarPerfilesPermisos(_ID_Perfil);
        }
        public void Insertar()
        {
            C.InsertarPerfil_Permisos(_ID_Perfil,_ID, _Fecha_Registro, _Usuario_Registro);
        }

        public void Eliminar()
        {
            C.EliminarPerfil_Permisos(_ID_Perfil,_ID);
        }
        #endregion
    }
}
