using System;
using System.Data;
using BaseDatos;

namespace Controlador
{
    public class Clientes
    {
        #region Variables
        private int ID;
        private string Identificacion;
        private string Nombre;
        private string Telefono;
        private string Direccion;
        private string Email;
        private string Comentarios;
        private DateTime Fecha_Registro;
        private string Usuario_Registro;
        private bool Activo;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Clientes()
        {
        }
        #endregion

        #region Gets y Sets
        public string _Identificacion { get => Identificacion; set => Identificacion = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public string _Telefono { get => Telefono; set => Telefono = value; }
        public string _Direccion { get => Direccion; set => Direccion = value; }
        public string _Email { get => Email; set => Email = value; }
        public string _Comentarios { get => Comentarios; set => Comentarios = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        public bool _Activo { get => Activo; set => Activo = value; }
        public int _ID { get => ID; set => ID = value; }
        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return C.ListarClientes();
        }
        public void Insertar()
        {
            C.InsertarClientes(_Identificacion,_Nombre,_Telefono,_Direccion,_Email,_Comentarios,_Fecha_Registro,_Usuario_Registro,_Activo);
        }

        public void Actualizar()
        {
            C.ActualizarClientes(_ID, _Identificacion, _Nombre, _Telefono, _Direccion, _Email, _Comentarios,_Activo);
        }

        public void Eliminar()
        {
            C.EliminarClientes(_ID);
        }
        #endregion
    }
}
