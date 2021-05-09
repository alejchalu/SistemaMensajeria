namespace Interfaz
{
    partial class FrmClientes
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
            this.GcClientes = new DevExpress.XtraGrid.GridControl();
            this.GvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CeActivo = new DevExpress.XtraEditors.CheckEdit();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.RichTextBox();
            this.TxtComentarios = new System.Windows.Forms.RichTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeActivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcClientes
            // 
            this.GcClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.GcClientes.Location = new System.Drawing.Point(0, 0);
            this.GcClientes.MainView = this.GvClientes;
            this.GcClientes.Name = "GcClientes";
            this.GcClientes.Size = new System.Drawing.Size(657, 190);
            this.GcClientes.TabIndex = 0;
            this.GcClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvClientes});
            // 
            // GvClientes
            // 
            this.GvClientes.GridControl = this.GcClientes;
            this.GvClientes.Name = "GvClientes";
            this.GvClientes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvClientes_RowClick);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Location = new System.Drawing.Point(193, 492);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Actualizar.Location = new System.Drawing.Point(274, 492);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 9;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(355, 492);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Comentarios";
            // 
            // CeActivo
            // 
            this.CeActivo.Location = new System.Drawing.Point(111, 353);
            this.CeActivo.Name = "CeActivo";
            this.CeActivo.Properties.Caption = "Activo";
            this.CeActivo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CeActivo.Size = new System.Drawing.Size(57, 18);
            this.CeActivo.TabIndex = 4;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(152, 222);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.TxtIdentificacion.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(152, 267);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(152, 310);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 3;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDireccion.Location = new System.Drawing.Point(376, 225);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(201, 47);
            this.TxtDireccion.TabIndex = 5;
            this.TxtDireccion.Text = "";
            // 
            // TxtComentarios
            // 
            this.TxtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtComentarios.Location = new System.Drawing.Point(376, 307);
            this.TxtComentarios.Name = "TxtComentarios";
            this.TxtComentarios.Size = new System.Drawing.Size(201, 52);
            this.TxtComentarios.TabIndex = 7;
            this.TxtComentarios.Text = "";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(376, 279);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(201, 20);
            this.TxtEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID";
            this.label7.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(376, 414);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 18;
            this.TxtID.Visible = false;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 663);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtComentarios);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.CeActivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GcClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.Click += new System.EventHandler(this.FrmClientes_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeActivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView GvClientes;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.CheckEdit CeActivo;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.RichTextBox TxtDireccion;
        private System.Windows.Forms.RichTextBox TxtComentarios;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtID;
    }
}