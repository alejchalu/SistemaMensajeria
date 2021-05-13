namespace Interfaz
{
    partial class FrmRutas
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
            this.GcRutas = new DevExpress.XtraGrid.GridControl();
            this.GvRutas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbMensajero = new DevExpress.XtraEditors.LookUpEdit();
            this.CeActivo = new DevExpress.XtraEditors.CheckEdit();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GcRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbMensajero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeActivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcRutas
            // 
            this.GcRutas.Dock = System.Windows.Forms.DockStyle.Top;
            this.GcRutas.Location = new System.Drawing.Point(0, 0);
            this.GcRutas.MainView = this.GvRutas;
            this.GcRutas.Name = "GcRutas";
            this.GcRutas.Size = new System.Drawing.Size(641, 200);
            this.GcRutas.TabIndex = 0;
            this.GcRutas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvRutas});
            // 
            // GvRutas
            // 
            this.GvRutas.GridControl = this.GcRutas;
            this.GvRutas.Name = "GvRutas";
            this.GvRutas.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvRutas_RowClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mensajero";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(266, 253);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 5;
            // 
            // CbMensajero
            // 
            this.CbMensajero.Location = new System.Drawing.Point(266, 287);
            this.CbMensajero.Name = "CbMensajero";
            this.CbMensajero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbMensajero.Properties.DropDownRows = 100;
            this.CbMensajero.Properties.NullText = "Elija una opción";
            this.CbMensajero.Properties.ThrowExceptionOnInvalidLookUpEditValueType = true;
            this.CbMensajero.Size = new System.Drawing.Size(100, 20);
            this.CbMensajero.TabIndex = 6;
            // 
            // CeActivo
            // 
            this.CeActivo.Location = new System.Drawing.Point(225, 322);
            this.CeActivo.Name = "CeActivo";
            this.CeActivo.Properties.Caption = "Activo";
            this.CeActivo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CeActivo.Size = new System.Drawing.Size(57, 18);
            this.CeActivo.TabIndex = 7;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(527, 283);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(75, 20);
            this.TxtID.TabIndex = 104;
            this.TxtID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "ID";
            this.label5.Visible = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(331, 443);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 107;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizar.Location = new System.Drawing.Point(250, 443);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 106;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Location = new System.Drawing.Point(169, 443);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 105;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 624);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CeActivo);
            this.Controls.Add(this.CbMensajero);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GcRutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRutas";
            this.Text = "FrmRutas";
            this.Load += new System.EventHandler(this.FrmRutas_Load);
            this.Click += new System.EventHandler(this.FrmRutas_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GcRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbMensajero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeActivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcRutas;
        private DevExpress.XtraGrid.Views.Grid.GridView GvRutas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private DevExpress.XtraEditors.LookUpEdit CbMensajero;
        private DevExpress.XtraEditors.CheckEdit CeActivo;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}