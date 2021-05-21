using System;
using System.Data;
using BaseDatos;

namespace Controlador
{
    public class Usuarios
    {
        #region Variables
        private int ID;
        private string Usuario;
        private string Contraseña;
        private string Nombre;
        private int ID_Perfil;
        private DateTime Fecha_Registro;
        private string Usuario_Registro;
        private bool Activo;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Usuarios()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public string _Usuario { get => Usuario; set => Usuario = value; }
        public string _Contraseña { get => Contraseña; set => Contraseña = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public int _ID_Perfil { get => ID_Perfil; set => ID_Perfil = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        public bool _Activo { get => Activo; set => Activo = value; }
        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return C.ListarUsuarios();
        }
        public void Insertar()
        {
            C.InsertarUsuarios(_Usuario, _Contraseña, _Nombre, _ID_Perfil, _Fecha_Registro, _Usuario_Registro, _Activo);
        }

        public void Actualizar()
        {
            C.ActualizarUsuarios(_ID, _Usuario, _Contraseña, _Nombre, _ID_Perfil, _Activo);
        }

        public void Eliminar()
        {
            C.EliminarUsuarios(_ID);
        }

        public string Validar()
        {
            string Cadena = C.ValidaUsuarios(_Usuario, _Contraseña);
            if (Cadena != "")
            {
                string[] parametros = Cadena.Split(',');
                _Nombre = parametros[0];
                _ID_Perfil = Convert.ToInt32(parametros[1]);
            }
            else
            {
                Cadena = "";
            }
            
            return Cadena;         
        }
        #endregion
    }
}
