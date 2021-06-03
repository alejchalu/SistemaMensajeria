using Controlador;
using CrystalDecisions.CrystalReports.Engine;
using Interfaz.Documentos;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmDocumentosMensajeros : Form
    {
        public FrmDocumentosMensajeros()
        {
            InitializeComponent();
        }

        #region Variables
        private Documentos_Mensajeros DM = new Documentos_Mensajeros();
        private Mensajeros Me = new Mensajeros();
        private Configuracion_Correos CCO = new Configuracion_Correos();
        private ReportDocument Reporte = new ReportDocument();
        #endregion

        #region Metodos
        private void CargarDocumento()
        {
            try
            {              
                Reporte.Load(Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Documentos" + CbDocumento.GetColumnValue("NombreRPT").ToString());

                if (CbDocumento.GetColumnValue("Parametros").ToString() != "")
                {
                    ArrayList ParametrosValores = new ArrayList();
                    ParametrosValores.Add(Convert.ToInt32(CbMensajero.EditValue));
                    Reporte.SetParameterValue(0, ParametrosValores[0]);
                    string[] Parametros = CbDocumento.GetColumnValue("Parametros").ToString().Split(',');
                    if (Reporte.ParameterFields.Count > 1)
                    {
                        for (int i = 1; i < Reporte.ParameterFields.Count; i++)
                        {
                            ParametrosValores.Add(Interaction.InputBox("Ingrese el parametro: " + Parametros[i], "Parametros", ""));
                            Reporte.SetParameterValue(i, ParametrosValores[i]);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Whatsapp()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Email()
        {
            try
            {
                BarEnviando.EditValue = 0;
                BarEnviando.Visible = true;
                LblEnviando.Visible = true;

                BarEnviando.PerformStep();
                BarEnviando.Update();

                CargarDocumento();

                DataTable ConfiguracionCorreos = CCO.Listar();
                DataRow Fila = ConfiguracionCorreos.Rows[0];

                Reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Fila["RutaArchivo"].ToString() + CbDocumento.GetColumnValue("NombreRPT").ToString().Replace(".rpt",".pdf"));

                BarEnviando.PerformStep();
                BarEnviando.Update();
       
                Attachment Archivo = new Attachment(Fila["RutaArchivo"].ToString()+ CbDocumento.GetColumnValue("NombreRPT").ToString().Replace(".rpt", ".pdf"));
                MailMessage Correo = new MailMessage();
                SmtpClient Servidor = new SmtpClient();

                Correo.From = new MailAddress(Fila["CorreoDe"].ToString());
                Correo.Subject = Fila["Asunto"].ToString();

                string CorreosPara = Interaction.InputBox("Ingrese los correos a enviar separados por ;", "Correos a enviar", CbMensajero.GetColumnValue("Email").ToString());

                if (CorreosPara.Length > 0)
                {
                    foreach (string Para in CorreosPara.Split(';'))
                    {
                        Correo.To.Add(Para);
                    }
                }

                string CorreosCC = Interaction.InputBox("Ingrese los correos a copiar separados por ;", "Copia correos", "");

                if (CorreosCC.Length > 0)
                {
                    foreach (string Copia in CorreosCC.Split(';'))
                    {
                        Correo.CC.Add(Copia);
                    }
                }
                
                Correo.Attachments.Add(Archivo);
                Correo.Body = Fila["Cuerpo"].ToString();

                BarEnviando.PerformStep();
                BarEnviando.Update();

                Servidor.Host = Fila["SMTP"].ToString();
                Servidor.Port = Convert.ToInt32(Fila["Puerto"].ToString());
                Servidor.EnableSsl = Convert.ToBoolean(Fila["SSL"].ToString());
                Servidor.UseDefaultCredentials = Convert.ToBoolean(Fila["CredencialesPorDefecto"].ToString()); ;
                if (Servidor.UseDefaultCredentials == false)
                {
                    string Contraseña = Interaction.InputBox("Ingrese la contraseña del correo", "Contraseña", "");
                    Servidor.Credentials = new NetworkCredential(Fila["CorreoDe"].ToString(), Contraseña);
                }               
                Servidor.Send(Correo);
                Correo.Dispose();

                File.Delete(Fila["RutaArchivo"].ToString()+ CbDocumento.GetColumnValue("NombreRPT").ToString().Replace(".rpt", ".pdf"));

                BarEnviando.PerformStep();
                BarEnviando.Update();

                BarEnviando.Visible = false;
                LblEnviando.Visible = false;
            }
            catch (Exception)
            {
                BarEnviando.Visible = false;
                LblEnviando.Visible = false;
                throw;
            }
        }
        private void Imprimir()
        {
            try
            {
                FrmReportes R = new FrmReportes();

                CargarDocumento();

                R.RvReportes.ReportSource = Reporte;
                R.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Envio()
        {
            try
            {
                switch (RgMetodo.Properties.Items[RgMetodo.SelectedIndex].Description)
                {
                    case "Imprimir":
                        Imprimir();
                        break;

                    case "Email":
                        Email();
                        break;

                    case "Whatsapp":
                        Whatsapp();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void Limpiar()
        {
            CbMensajero.EditValue = null;
            CbDocumento.EditValue = null;
            TxtComentarios.Clear();
            RgMetodo.SelectedIndex = 0;
        }
        private void Guardar()
        {
            try
            {
                DM._ID_Mensajero = Convert.ToInt32(CbMensajero.EditValue);
                DM._ID_Documento = Convert.ToInt32(CbDocumento.EditValue);
                DM._Metodo = RgMetodo.Properties.Items[RgMetodo.SelectedIndex].Description;
                DM._Comentarios = TxtComentarios.Text;
                DM._Fecha_Registro = DateTime.Now;
                DM._Usuario_Registro = Globales.Usuario;

                DM.Insertar();               

                Envio();

                Limpiar();

                FrmMensaje M = new FrmMensaje();
                M.UnBoton("Documento procesado correctamente", "Aceptar", Properties.Resources._checked);
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        private void Cargar()
        {
            try
            {

                CbMensajero.Properties.DataSource = Me.ListarCombo();
                DataTable TablaM = (DataTable)CbMensajero.Properties.DataSource;
                CbMensajero.Properties.ValueMember = "ID";
                CbMensajero.Properties.DisplayMember = "Nombre";
                CbMensajero.Properties.DropDownRows = TablaM.Rows.Count;
                CbMensajero.Properties.PopulateColumns();
                CbMensajero.Properties.Columns[CbMensajero.Properties.ValueMember].Visible = false;
                CbMensajero.Properties.Columns[2].Visible = false;

                CbDocumento.Properties.DataSource = DM.ListarComboDocumentos();
                DataTable TablaD = (DataTable)CbMensajero.Properties.DataSource;
                CbDocumento.Properties.ValueMember = "ID";
                CbDocumento.Properties.DisplayMember = "Descripcion";
                CbDocumento.Properties.DropDownRows = TablaD.Rows.Count;
                CbDocumento.Properties.PopulateColumns();
                CbDocumento.Properties.Columns[CbDocumento.Properties.ValueMember].Visible = false;
                CbDocumento.Properties.Columns["NombreRPT"].Visible = false;
                CbDocumento.Properties.Columns["Parametros"].Visible = false;
            }
            catch (Exception ex)
            {
                FrmMensaje M = new FrmMensaje();
                M.UnBoton(ex.Message, "Aceptar", Properties.Resources.close);
            }
        }
        #endregion

        #region Eventos
        private void FrmDocumentosMensajeros_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        #endregion
    }
}
