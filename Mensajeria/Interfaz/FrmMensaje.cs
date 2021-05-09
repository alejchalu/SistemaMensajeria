using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmMensaje : Form
    {
        public FrmMensaje()
        {
            InitializeComponent();
        }

        #region Variables

        #endregion

        #region Metodos
        public void UnBoton(string Mensaje,string TextoBoton,Image imagen)
        {
            TxtMensaje.Text = Mensaje;
            Btn2.Visible = true;
            Btn2.Text = "Aceptar";
            Btn1.Visible = false;
            Btn3.Visible = false;
            CaImagen.Image = imagen;
            Btn2.Focus();

            this.ShowDialog();
        }

        public DialogResult DosBotones(string Mensaje, string TextoBoton1, string TextoBoton2, Image imagen, DialogResult Resultado1, DialogResult Resultado2)
        {
            TxtMensaje.Text = Mensaje;
            Btn1.Visible = true;
            Btn1.Text = TextoBoton1;
            Btn3.Visible = true;
            Btn3.Text = TextoBoton2;
            Btn2.Visible = false;
            CaImagen.Image = imagen;
            Btn1.Focus();

            Btn1.DialogResult = Resultado1;
            Btn3.DialogResult = Resultado2;

            this.ShowDialog();

            return this.DialogResult;
        }
        #endregion

        #region Eventos
        private void Btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
