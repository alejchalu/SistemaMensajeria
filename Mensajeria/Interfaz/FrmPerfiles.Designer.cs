namespace Interfaz
{
    partial class FrmPerfiles
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
            this.GcPerfiles = new DevExpress.XtraGrid.GridControl();
            this.GvPerfiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CeActivo = new DevExpress.XtraEditors.CheckEdit();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GcPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeActivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcPerfiles
            // 
            this.GcPerfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.GcPerfiles.Location = new System.Drawing.Point(0, 0);
            this.GcPerfiles.MainView = this.GvPerfiles;
            this.GcPerfiles.Name = "GcPerfiles";
            this.GcPerfiles.Size = new System.Drawing.Size(641, 200);
            this.GcPerfiles.TabIndex = 0;
            this.GcPerfiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvPerfiles});
            // 
            // GvPerfiles
            // 
            this.GvPerfiles.GridControl = this.GcPerfiles;
            this.GvPerfiles.Name = "GvPerfiles";
            this.GvPerfiles.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvPerfiles_RowClick);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(534, 280);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(75, 20);
            this.TxtID.TabIndex = 106;
            this.TxtID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "ID";
            this.label5.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(275, 261);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nombre";
            // 
            // CeActivo
            // 
            this.CeActivo.Location = new System.Drawing.Point(275, 302);
            this.CeActivo.Name = "CeActivo";
            this.CeActivo.Properties.Caption = "Activo";
            this.CeActivo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CeActivo.Size = new System.Drawing.Size(57, 18);
            this.CeActivo.TabIndex = 109;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(357, 408);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 112;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizar.Location = new System.Drawing.Point(276, 408);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 111;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Location = new System.Drawing.Point(195, 408);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 110;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 624);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CeActivo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GcPerfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPerfiles";
            this.Text = "FrmPerfiles";
            this.Load += new System.EventHandler(this.FrmPerfiles_Load);
            this.Click += new System.EventHandler(this.FrmPerfiles_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GcPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeActivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcPerfiles;
        private DevExpress.XtraGrid.Views.Grid.GridView GvPerfiles;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CheckEdit CeActivo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}