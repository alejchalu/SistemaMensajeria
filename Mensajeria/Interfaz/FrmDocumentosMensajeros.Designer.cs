namespace Interfaz
{
    partial class FrmDocumentosMensajeros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbMensajero = new DevExpress.XtraEditors.LookUpEdit();
            this.CbDocumento = new DevExpress.XtraEditors.LookUpEdit();
            this.RgMetodo = new DevExpress.XtraEditors.RadioGroup();
            this.TxtComentarios = new System.Windows.Forms.RichTextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblEnviando = new DevExpress.XtraEditors.LabelControl();
            this.BarEnviando = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.CbMensajero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgMetodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarEnviando.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensajero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comentarios";
            // 
            // CbMensajero
            // 
            this.CbMensajero.Location = new System.Drawing.Point(196, 114);
            this.CbMensajero.Name = "CbMensajero";
            this.CbMensajero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbMensajero.Properties.DropDownRows = 100;
            this.CbMensajero.Properties.NullText = "Elija una opción";
            this.CbMensajero.Properties.ThrowExceptionOnInvalidLookUpEditValueType = true;
            this.CbMensajero.Size = new System.Drawing.Size(100, 20);
            this.CbMensajero.TabIndex = 4;
            // 
            // CbDocumento
            // 
            this.CbDocumento.Location = new System.Drawing.Point(385, 114);
            this.CbDocumento.Name = "CbDocumento";
            this.CbDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbDocumento.Properties.DropDownRows = 100;
            this.CbDocumento.Properties.NullText = "Elija una opción";
            this.CbDocumento.Properties.ThrowExceptionOnInvalidLookUpEditValueType = true;
            this.CbDocumento.Size = new System.Drawing.Size(100, 20);
            this.CbDocumento.TabIndex = 5;
            // 
            // RgMetodo
            // 
            this.RgMetodo.Location = new System.Drawing.Point(225, 180);
            this.RgMetodo.Name = "RgMetodo";
            this.RgMetodo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Imprimir"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Email"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Whatsapp")});
            this.RgMetodo.Size = new System.Drawing.Size(219, 23);
            this.RgMetodo.TabIndex = 8;
            // 
            // TxtComentarios
            // 
            this.TxtComentarios.Location = new System.Drawing.Point(187, 223);
            this.TxtComentarios.Name = "TxtComentarios";
            this.TxtComentarios.Size = new System.Drawing.Size(298, 89);
            this.TxtComentarios.TabIndex = 9;
            this.TxtComentarios.Text = "";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(291, 341);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblEnviando
            // 
            this.LblEnviando.Location = new System.Drawing.Point(301, 24);
            this.LblEnviando.Name = "LblEnviando";
            this.LblEnviando.Size = new System.Drawing.Size(56, 13);
            this.LblEnviando.TabIndex = 19;
            this.LblEnviando.Text = "Enviando...";
            this.LblEnviando.Visible = false;
            // 
            // BarEnviando
            // 
            this.BarEnviando.Location = new System.Drawing.Point(279, 43);
            this.BarEnviando.Name = "BarEnviando";
            this.BarEnviando.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.BarEnviando.Properties.Step = 25;
            this.BarEnviando.Size = new System.Drawing.Size(100, 18);
            this.BarEnviando.TabIndex = 18;
            this.BarEnviando.Visible = false;
            // 
            // FrmDocumentosMensajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 532);
            this.Controls.Add(this.LblEnviando);
            this.Controls.Add(this.BarEnviando);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtComentarios);
            this.Controls.Add(this.RgMetodo);
            this.Controls.Add(this.CbDocumento);
            this.Controls.Add(this.CbMensajero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDocumentosMensajeros";
            this.Text = "FrmDocumentosMensajeros";
            this.Load += new System.EventHandler(this.FrmDocumentosMensajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CbMensajero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgMetodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarEnviando.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit CbMensajero;
        private DevExpress.XtraEditors.LookUpEdit CbDocumento;
        private DevExpress.XtraEditors.RadioGroup RgMetodo;
        private System.Windows.Forms.RichTextBox TxtComentarios;
        private System.Windows.Forms.Button BtnAceptar;
        internal DevExpress.XtraEditors.LabelControl LblEnviando;
        internal DevExpress.XtraEditors.ProgressBarControl BarEnviando;
    }
}