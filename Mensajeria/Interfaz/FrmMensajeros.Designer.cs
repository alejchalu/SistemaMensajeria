namespace Interfaz
{
    partial class FrmMensajeros
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
            this.GcMensajeros = new DevExpress.XtraGrid.GridControl();
            this.GvMensajeros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.DeFechaIngreso = new DevExpress.XtraEditors.DateEdit();
            this.CeActivo = new DevExpress.XtraEditors.CheckEdit();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GcMensajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvMensajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeFechaIngreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeFechaIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeActivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcMensajeros
            // 
            this.GcMensajeros.Dock = System.Windows.Forms.DockStyle.Top;
            this.GcMensajeros.Location = new System.Drawing.Point(0, 0);
            this.GcMensajeros.MainView = this.GvMensajeros;
            this.GcMensajeros.Name = "GcMensajeros";
            this.GcMensajeros.Size = new System.Drawing.Size(647, 200);
            this.GcMensajeros.TabIndex = 0;
            this.GcMensajeros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvMensajeros});
            // 
            // GvMensajeros
            // 
            this.GvMensajeros.GridControl = this.GcMensajeros;
            this.GvMensajeros.Name = "GvMensajeros";
            this.GvMensajeros.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvMensajeros_RowClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de ingreso";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(35, 403);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 7;
            this.TxtID.Visible = false;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(184, 246);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.TxtIdentificacion.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(184, 280);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 9;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(402, 239);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 10;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(402, 279);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 11;
            // 
            // DeFechaIngreso
            // 
            this.DeFechaIngreso.EditValue = null;
            this.DeFechaIngreso.Location = new System.Drawing.Point(402, 315);
            this.DeFechaIngreso.Name = "DeFechaIngreso";
            this.DeFechaIngreso.Properties.BeepOnError = false;
            this.DeFechaIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeFechaIngreso.Properties.MaskSettings.Set("mask", "d");
            this.DeFechaIngreso.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.DeFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.DeFechaIngreso.TabIndex = 12;
            // 
            // CeActivo
            // 
            this.CeActivo.Location = new System.Drawing.Point(143, 316);
            this.CeActivo.Name = "CeActivo";
            this.CeActivo.Properties.Caption = "Activo";
            this.CeActivo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CeActivo.Size = new System.Drawing.Size(57, 18);
            this.CeActivo.TabIndex = 13;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(347, 429);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizar.Location = new System.Drawing.Point(266, 429);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 15;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Location = new System.Drawing.Point(185, 429);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmMensajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 571);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CeActivo);
            this.Controls.Add(this.DeFechaIngreso);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GcMensajeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMensajeros";
            this.Text = "FrmMensajeros";
            this.Load += new System.EventHandler(this.FrmMensajeros_Load);
            this.Click += new System.EventHandler(this.FrmMensajeros_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GcMensajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvMensajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeFechaIngreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeFechaIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeActivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcMensajeros;
        private DevExpress.XtraGrid.Views.Grid.GridView GvMensajeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtEmail;
        private DevExpress.XtraEditors.DateEdit DeFechaIngreso;
        private DevExpress.XtraEditors.CheckEdit CeActivo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}