using System.Data;
using BaseDatos;

namespace Controlador
{
    public class Menus
    {
        #region Variables
        private int ID;
        private int ID_Padre;
        private string Descripcion;
        private string Formulario;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Menus()
        {
        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public int _ID_Padre { get => ID_Padre; set => ID_Padre = value; }
        public string _Descripcion { get => Descripcion; set => Descripcion = value; }
        public string _Formulario { get => Formulario; set => Formulario = value; }
        #endregion

        #region Metodos
        public DataTable ListarMenuPermisos()
        {
            return C.ListarMenuPermisos();
        }

        public DataTable ListarMenu()
        {
            return C.ListarMenu();
        }
        #endregion
    }
}
