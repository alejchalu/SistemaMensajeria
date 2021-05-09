namespace Interfaz
{
    partial class FrmUsuarios
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.GvUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CeActivo = new DevExpress.XtraEditors.CheckEdit();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CbPerfil = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbPerfil.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Location = new System.Drawing.Point(206, 592);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizar.Location = new System.Drawing.Point(287, 592);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 6;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // GcUsuarios
            // 
            this.GcUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.GcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.GcUsuarios.MainView = this.GvUsuarios;
            this.GcUsuarios.Name = "GcUsuarios";
            this.GcUsuarios.Size = new System.Drawing.Size(657, 200);
            this.GcUsuarios.TabIndex = 100;
            this.GcUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvUsuarios});
            // 
            // GvUsuarios
            // 
            this.GvUsuarios.Appearance.Row.Options.UseTextOptions = true;
            this.GvUsuarios.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GvUsuarios.GridControl = this.GcUsuarios;
            this.GvUsuarios.Name = "GvUsuarios";
            this.GvUsuarios.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvUsuarios_RowClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Perfil";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(193, 246);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(193, 299);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(100, 20);
            this.TxtContraseña.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(373, 246);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // CeActivo
            // 
            this.CeActivo.Location = new System.Drawing.Point(289, 340);
            this.CeActivo.Name = "CeActivo";
            this.CeActivo.Properties.Caption = "Activo";
            this.CeActivo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CeActivo.Size = new System.Drawing.Size(57, 18);
            this.CeActivo.TabIndex = 4;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(368, 592);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // CbPerfil
            // 
            this.CbPerfil.Location = new System.Drawing.Point(373, 299);
            this.CbPerfil.Name = "CbPerfil";
            this.CbPerfil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbPerfil.Properties.DropDownRows = 100;
            this.CbPerfil.Properties.NullText = "Elija una opción";
            this.CbPerfil.Properties.ThrowExceptionOnInvalidLookUpEditValueType = true;
            this.CbPerfil.Size = new System.Drawing.Size(100, 20);
            this.CbPerfil.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "ID";
            this.label5.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(12, 280);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(75, 20);
            this.TxtID.TabIndex = 102;
            this.TxtID.Visible = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 663);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbPerfil);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.CeActivo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GcUsuarios);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.Click += new System.EventHandler(this.FrmUsuarios_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbPerfil.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnActualizar;
        private DevExpress.XtraGrid.GridControl GcUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView GvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtNombre;
        private DevExpress.XtraEditors.CheckEdit CeActivo;
        private System.Windows.Forms.Button BtnEliminar;
        private DevExpress.XtraEditors.LookUpEdit CbPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtID;
    }
}