using BaseDatos;
using System.Data;

namespace Controlador
{
    public class Configuracion_Correos
    {
        #region Variables
        private string SMTP;
        private int Puerto;
        private bool SSL;
        private string CorreoDe;
        private string Asunto;
        private string Cuerpo;
        private string RutaArchivo;
        private bool CredencialesPorDefecto;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public Configuracion_Correos()
        {

        }
        #endregion

        #region Gets y sets
        public string _SMTP { get => SMTP; set => SMTP = value; }
        public int _Puerto { get => Puerto; set => Puerto = value; }
        public bool _SSL { get => SSL; set => SSL = value; }
        public string _CorreoDe { get => CorreoDe; set => CorreoDe = value; }
        public string _Asunto { get => Asunto; set => Asunto = value; }
        public string _Cuerpo { get => Cuerpo; set => Cuerpo = value; }
        public string _RutaArchivo { get => RutaArchivo; set => RutaArchivo = value; }
        public bool _CredencialesPorDefecto { get => CredencialesPorDefecto; set => CredencialesPorDefecto = value; }
        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return C.ListarConfiguracion_Correos();
        }
        #endregion
    }
}
