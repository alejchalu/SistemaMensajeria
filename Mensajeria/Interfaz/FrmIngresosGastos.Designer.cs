namespace Interfaz
{
    partial class FrmIngresosGastos
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
            this.GcIngresosGastos = new DevExpress.XtraGrid.GridControl();
            this.GvIngresosGastos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeFecha = new DevExpress.XtraEditors.DateEdit();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.CbTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GcIngresosGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvIngresosGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbTipo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcIngresosGastos
            // 
            this.GcIngresosGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.GcIngresosGastos.Location = new System.Drawing.Point(0, 0);
            this.GcIngresosGastos.MainView = this.GvIngresosGastos;
            this.GcIngresosGastos.Name = "GcIngresosGastos";
            this.GcIngresosGastos.Size = new System.Drawing.Size(641, 200);
            this.GcIngresosGastos.TabIndex = 0;
            this.GcIngresosGastos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvIngresosGastos});
            // 
            // GvIngresosGastos
            // 
            this.GvIngresosGastos.GridControl = this.GcIngresosGastos;
            this.GvIngresosGastos.Name = "GvIngresosGastos";
            this.GvIngresosGastos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvIngresosGastos_RowClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha transacción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID";
            this.label5.Visible = false;
            // 
            // DeFecha
            // 
            this.DeFecha.EditValue = null;
            this.DeFecha.Location = new System.Drawing.Point(375, 264);
            this.DeFecha.Name = "DeFecha";
            this.DeFecha.Properties.BeepOnError = false;
            this.DeFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeFecha.Properties.MaskSettings.Set("mask", "d");
            this.DeFecha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.DeFecha.Size = new System.Drawing.Size(100, 20);
            this.DeFecha.TabIndex = 6;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(145, 316);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(100, 20);
            this.TxtMonto.TabIndex = 7;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(375, 316);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(191, 65);
            this.TxtDescripcion.TabIndex = 8;
            this.TxtDescripcion.Text = "";
            // 
            // CbTipo
            // 
            this.CbTipo.Location = new System.Drawing.Point(145, 264);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbTipo.Properties.Items.AddRange(new object[] {
            "Ingreso",
            "Gasto"});
            this.CbTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CbTipo.Properties.UseReadOnlyAppearance = false;
            this.CbTipo.Size = new System.Drawing.Size(100, 20);
            this.CbTipo.TabIndex = 9;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(30, 385);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 10;
            this.TxtID.Visible = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Location = new System.Drawing.Point(185, 477);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 11;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizar.Location = new System.Drawing.Point(266, 477);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 12;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(347, 477);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FrmIngresosGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 624);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.DeFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GcIngresosGastos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIngresosGastos";
            this.Text = "FrmIngresosGastos";
            this.Load += new System.EventHandler(this.FrmIngresosGastos_Load);
            this.Click += new System.EventHandler(this.FrmIngresosGastos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GcIngresosGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvIngresosGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbTipo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcIngresosGastos;
        private DevExpress.XtraGrid.Views.Grid.GridView GvIngresosGastos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit DeFecha;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.RichTextBox TxtDescripcion;
        private DevExpress.XtraEditors.ComboBoxEdit CbTipo;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}