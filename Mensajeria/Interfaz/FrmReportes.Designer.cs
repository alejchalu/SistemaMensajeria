namespace Interfaz
{
    partial class FrmReportes
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
            this.RvReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RvReportes
            // 
            this.RvReportes.ActiveViewIndex = -1;
            this.RvReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RvReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.RvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvReportes.Location = new System.Drawing.Point(0, 0);
            this.RvReportes.Name = "RvReportes";
            this.RvReportes.ShowGroupTreeButton = false;
            this.RvReportes.ShowLogo = false;
            this.RvReportes.ShowRefreshButton = false;
            this.RvReportes.Size = new System.Drawing.Size(800, 450);
            this.RvReportes.TabIndex = 0;
            this.RvReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RvReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer RvReportes;
    }
}