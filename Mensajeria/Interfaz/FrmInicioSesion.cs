using System;
using System.Windows.Forms;
using Controlador;

namespace Interfaz
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        #region Variables
        private Usuarios U = new Usuarios();
        private int xClick = 0, yClick = 0;
        #endregion

        #region Eventos
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            TxtUsuario.Focus();
        }

        private void FrmInicioSesion_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            U._Usuario = TxtUsuario.Text;
            U._Contraseña = TxtContraseña.Text;
            Globales.Usuario = TxtUsuario.Text;

            if (TxtUsuario.Text == "" || TxtContraseña.Text == "")
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton("Debe ingresar todos los datos solicitados", "Aceptar", Properties.Resources.close);

                TxtUsuario.Clear();
                TxtContraseña.Clear();
                TxtUsuario.Focus();
            }
            else if (U.Validar() == "")
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton("El usuario o la contraseña son incorrectos", "Aceptar", Properties.Resources.close);

                TxtUsuario.Clear();
                TxtContraseña.Clear();
                TxtUsuario.Focus();
            }
            else
            {
                FrmPrincipal P = new FrmPrincipal();
                P.LblUsuario.Text = P.LblUsuario.Text + U._Nombre;
                this.Hide();
                P.Show();
            }
        }
    }
    #endregion
}
