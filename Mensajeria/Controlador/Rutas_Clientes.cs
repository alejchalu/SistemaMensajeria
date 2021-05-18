using System;
using System.Collections;
using System.Data;
using BaseDatos;

namespace Controlador
{
    public class Rutas_Clientes
    {
        #region Variables
        private int ID_Rutas;
        private int ID_Cliente;
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
        public int _ID_Rutas { get => ID_Rutas; set => ID_Rutas = value; }
        public int _ID_Cliente { get => ID_Cliente; set => ID_Cliente = value; }
        public DateTime _Fecha_Registro { get => Fecha_Registro; set => Fecha_Registro = value; }
        public string _Usuario_Registro { get => Usuario_Registro; set => Usuario_Registro = value; }
        #endregion

        #region Metodos
        public DataTable ListarNoAsignados(string ID_Clientes)
        {
            return C.ListarRutas_ClientesNoAsignados(ID_Clientes);
        }
        public DataTable ListarAsignados()
        {
            return C.ListarRutas_ClientesAsignados(_ID_Rutas);
        }
        public void Insertar()
        {
            C.InsertarRutas_Clientes(_ID_Rutas, _ID_Cliente, _Fecha_Registro, _Usuario_Registro);
        }

        public void Eliminar()
        {
            C.EliminarRutas_Clientes(_ID_Rutas,_ID_Cliente);
        }
        #endregion
    }
}
