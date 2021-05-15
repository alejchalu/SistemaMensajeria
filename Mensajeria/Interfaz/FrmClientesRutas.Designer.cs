namespace Interfaz
{
    partial class FrmClientesRutas
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
            this.GcNoAsignados = new DevExpress.XtraGrid.GridControl();
            this.GvNoAsignados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcAsignados = new DevExpress.XtraGrid.GridControl();
            this.GvAsignados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnAsignar = new System.Windows.Forms.Button();
            this.BtnNoAsignar = new System.Windows.Forms.Button();
            this.CbRutas = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GcNoAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvNoAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbRutas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcNoAsignados
            // 
            this.GcNoAsignados.Location = new System.Drawing.Point(-1, 305);
            this.GcNoAsignados.MainView = this.GvNoAsignados;
            this.GcNoAsignados.Name = "GcNoAsignados";
            this.GcNoAsignados.Size = new System.Drawing.Size(649, 180);
            this.GcNoAsignados.TabIndex = 0;
            this.GcNoAsignados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvNoAsignados});
            // 
            // GvNoAsignados
            // 
            this.GvNoAsignados.GridControl = this.GcNoAsignados;
            this.GvNoAsignados.Name = "GvNoAsignados";
            this.GvNoAsignados.OptionsSelection.MultiSelect = true;
            // 
            // GcAsignados
            // 
            this.GcAsignados.Location = new System.Drawing.Point(-1, 58);
            this.GcAsignados.MainView = this.GvAsignados;
            this.GcAsignados.Name = "GcAsignados";
            this.GcAsignados.Size = new System.Drawing.Size(649, 180);
            this.GcAsignados.TabIndex = 1;
            this.GcAsignados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvAsignados});
            // 
            // GvAsignados
            // 
            this.GvAsignados.GridControl = this.GcAsignados;
            this.GvAsignados.Name = "GvAsignados";
            this.GvAsignados.OptionsSelection.MultiSelect = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(281, 501);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnAsignar
            // 
            this.BtnAsignar.Location = new System.Drawing.Point(238, 256);
            this.BtnAsignar.Name = "BtnAsignar";
            this.BtnAsignar.Size = new System.Drawing.Size(75, 23);
            this.BtnAsignar.TabIndex = 3;
            this.BtnAsignar.Text = "Asignar";
            this.BtnAsignar.UseVisualStyleBackColor = true;
            this.BtnAsignar.Click += new System.EventHandler(this.BtnAsignar_Click);
            // 
            // BtnNoAsignar
            // 
            this.BtnNoAsignar.Location = new System.Drawing.Point(336, 256);
            this.BtnNoAsignar.Name = "BtnNoAsignar";
            this.BtnNoAsignar.Size = new System.Drawing.Size(75, 23);
            this.BtnNoAsignar.TabIndex = 4;
            this.BtnNoAsignar.Text = "No asignar";
            this.BtnNoAsignar.UseVisualStyleBackColor = true;
            this.BtnNoAsignar.Click += new System.EventHandler(this.BtnNoAsignar_Click);
            // 
            // CbRutas
            // 
            this.CbRutas.Location = new System.Drawing.Point(281, 12);
            this.CbRutas.Name = "CbRutas";
            this.CbRutas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbRutas.Properties.DropDownRows = 100;
            this.CbRutas.Properties.NullText = "Elija una opción";
            this.CbRutas.Properties.ThrowExceptionOnInvalidLookUpEditValueType = true;
            this.CbRutas.Size = new System.Drawing.Size(100, 20);
            this.CbRutas.TabIndex = 5;
            this.CbRutas.EditValueChanged += new System.EventHandler(this.CbRutas_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ruta";
            // 
            // FrmClientesRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbRutas);
            this.Controls.Add(this.BtnNoAsignar);
            this.Controls.Add(this.BtnAsignar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GcAsignados);
            this.Controls.Add(this.GcNoAsignados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientesRutas";
            this.Text = "FrmClientesRutas";
            this.Load += new System.EventHandler(this.FrmClientesRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcNoAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvNoAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbRutas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcNoAsignados;
        private DevExpress.XtraGrid.Views.Grid.GridView GvNoAsignados;
        private DevExpress.XtraGrid.GridControl GcAsignados;
        private DevExpress.XtraGrid.Views.Grid.GridView GvAsignados;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnAsignar;
        private System.Windows.Forms.Button BtnNoAsignar;
        private DevExpress.XtraEditors.LookUpEdit CbRutas;
        private System.Windows.Forms.Label label1;
    }
}