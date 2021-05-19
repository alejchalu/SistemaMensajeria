namespace Interfaz
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.PnFormularios = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.XtPFormularios = new DevExpress.XtraTab.XtraTabControl();
            this.PbImagenPrincipal = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TlOpcionesMenu = new DevExpress.XtraTreeList.TreeList();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PnFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtPFormularios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagenPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TlOpcionesMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(176)))), ((int)(((byte)(153)))));
            this.BtnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.BtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(176)))), ((int)(((byte)(153)))));
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(0, 526);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCerrarSesion.Size = new System.Drawing.Size(251, 45);
            this.BtnCerrarSesion.TabIndex = 6;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesión_Click);
            // 
            // PnFormularios
            // 
            this.PnFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PnFormularios.Controls.Add(this.BtnMinimizar);
            this.PnFormularios.Controls.Add(this.BtnMaximizar);
            this.PnFormularios.Controls.Add(this.XtPFormularios);
            this.PnFormularios.Controls.Add(this.PbImagenPrincipal);
            this.PnFormularios.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnFormularios.Location = new System.Drawing.Point(254, 0);
            this.PnFormularios.Name = "PnFormularios";
            this.PnFormularios.Size = new System.Drawing.Size(647, 571);
            this.PnFormularios.TabIndex = 3;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Image = global::Interfaz.Properties.Resources.minimizar__1___1_;
            this.BtnMinimizar.Location = new System.Drawing.Point(606, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Image = global::Interfaz.Properties.Resources.minimizar__2___1_;
            this.BtnMaximizar.Location = new System.Drawing.Point(628, 3);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.BtnMaximizar.TabIndex = 2;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // XtPFormularios
            // 
            this.XtPFormularios.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.XtPFormularios.Location = new System.Drawing.Point(81, 145);
            this.XtPFormularios.Name = "XtPFormularios";
            this.XtPFormularios.Size = new System.Drawing.Size(300, 300);
            this.XtPFormularios.TabIndex = 1;
            this.XtPFormularios.Visible = false;
            this.XtPFormularios.CloseButtonClick += new System.EventHandler(this.XtPFormularios_CloseButtonClick);
            // 
            // PbImagenPrincipal
            // 
            this.PbImagenPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbImagenPrincipal.Image = global::Interfaz.Properties.Resources.entrega;
            this.PbImagenPrincipal.Location = new System.Drawing.Point(254, 180);
            this.PbImagenPrincipal.Name = "PbImagenPrincipal";
            this.PbImagenPrincipal.Size = new System.Drawing.Size(216, 147);
            this.PbImagenPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImagenPrincipal.TabIndex = 0;
            this.PbImagenPrincipal.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.TlOpcionesMenu);
            this.panel1.Controls.Add(this.BtnCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 571);
            this.panel1.TabIndex = 4;
            // 
            // TlOpcionesMenu
            // 
            this.TlOpcionesMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TlOpcionesMenu.Location = new System.Drawing.Point(0, 63);
            this.TlOpcionesMenu.Name = "TlOpcionesMenu";
            this.TlOpcionesMenu.OptionsBehavior.Editable = false;
            this.TlOpcionesMenu.Size = new System.Drawing.Size(251, 463);
            this.TlOpcionesMenu.TabIndex = 7;
            this.TlOpcionesMenu.RowClick += new DevExpress.XtraTreeList.RowClickEventHandler(this.TlOpcionesMenu_RowClick);
            // 
            // LblUsuario
            // 
            this.LblUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblUsuario.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(0, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(251, 60);
            this.LblUsuario.TabIndex = 4;
            this.LblUsuario.Text = "Bienvenido\r\n";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(901, 571);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnFormularios);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(901, 573);
            this.Name = "FrmPrincipal";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PnFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtPFormularios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagenPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TlOpcionesMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Panel PnFormularios;
        private System.Windows.Forms.PictureBox PbImagenPrincipal;
        private DevExpress.XtraTab.XtraTabControl XtPFormularios;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTreeList.TreeList TlOpcionesMenu;
        public System.Windows.Forms.Label LblUsuario;
    }
}