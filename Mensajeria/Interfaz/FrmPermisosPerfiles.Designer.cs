namespace Interfaz
{
    partial class FrmPermisosPerfiles
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
            this.CbPerfiles = new DevExpress.XtraEditors.LookUpEdit();
            this.TlOpcionesMenu = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.CbPerfiles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TlOpcionesMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perfil";
            // 
            // CbPerfiles
            // 
            this.CbPerfiles.Location = new System.Drawing.Point(152, 23);
            this.CbPerfiles.Name = "CbPerfiles";
            this.CbPerfiles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbPerfiles.Properties.DropDownRows = 100;
            this.CbPerfiles.Properties.NullText = "Elija una opción";
            this.CbPerfiles.Properties.ThrowExceptionOnInvalidLookUpEditValueType = true;
            this.CbPerfiles.Size = new System.Drawing.Size(100, 20);
            this.CbPerfiles.TabIndex = 7;
            this.CbPerfiles.EditValueChanged += new System.EventHandler(this.CbPerfiles_EditValueChanged);
            // 
            // TlOpcionesMenu
            // 
            this.TlOpcionesMenu.Location = new System.Drawing.Point(0, 89);
            this.TlOpcionesMenu.Name = "TlOpcionesMenu";
            this.TlOpcionesMenu.OptionsBehavior.Editable = false;
            this.TlOpcionesMenu.OptionsPrint.PrintHorzLines = false;
            this.TlOpcionesMenu.OptionsPrint.PrintPageHeader = false;
            this.TlOpcionesMenu.OptionsPrint.PrintReportFooter = false;
            this.TlOpcionesMenu.OptionsPrint.PrintTree = false;
            this.TlOpcionesMenu.OptionsPrint.PrintTreeButtons = false;
            this.TlOpcionesMenu.OptionsPrint.PrintVertLines = false;
            this.TlOpcionesMenu.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check;
            this.TlOpcionesMenu.OptionsView.RootCheckBoxStyle = DevExpress.XtraTreeList.NodeCheckBoxStyle.Check;
            this.TlOpcionesMenu.Size = new System.Drawing.Size(632, 443);
            this.TlOpcionesMenu.TabIndex = 10;
            this.TlOpcionesMenu.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.TlOpcionesMenu_AfterCheckNode);
            // 
            // FrmPermisosPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 532);
            this.Controls.Add(this.TlOpcionesMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbPerfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPermisosPerfiles";
            this.Text = "FrmPermisosPerfiles";
            this.Load += new System.EventHandler(this.FrmPermisosPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CbPerfiles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TlOpcionesMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit CbPerfiles;
        private DevExpress.XtraTreeList.TreeList TlOpcionesMenu;
    }
}