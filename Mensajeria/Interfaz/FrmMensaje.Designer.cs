namespace Interfaz
{
    partial class FrmMensaje
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.TxtMensaje = new System.Windows.Forms.RichTextBox();
            this.CaImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(176)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(-1, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 10);
            this.panel1.TabIndex = 0;
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(176)))), ((int)(((byte)(153)))));
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Btn1.Location = new System.Drawing.Point(72, 112);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(94, 37);
            this.Btn1.TabIndex = 2;
            this.Btn1.Text = "Boton 1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Visible = false;
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(176)))), ((int)(((byte)(153)))));
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Btn2.Location = new System.Drawing.Point(143, 112);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(94, 37);
            this.Btn2.TabIndex = 3;
            this.Btn2.Text = "Boton 2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Visible = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(176)))), ((int)(((byte)(153)))));
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Btn3.Location = new System.Drawing.Point(220, 112);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(94, 37);
            this.Btn3.TabIndex = 4;
            this.Btn3.Text = "Boton 3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Visible = false;
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TxtMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(176)))), ((int)(((byte)(153)))));
            this.TxtMensaje.Location = new System.Drawing.Point(72, 15);
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.ReadOnly = true;
            this.TxtMensaje.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtMensaje.Size = new System.Drawing.Size(299, 91);
            this.TxtMensaje.TabIndex = 100;
            this.TxtMensaje.TabStop = false;
            this.TxtMensaje.Text = "";
            // 
            // CaImagen
            // 
            this.CaImagen.Image = global::Interfaz.Properties.Resources.close;
            this.CaImagen.Location = new System.Drawing.Point(12, 12);
            this.CaImagen.Name = "CaImagen";
            this.CaImagen.Size = new System.Drawing.Size(40, 37);
            this.CaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CaImagen.TabIndex = 6;
            this.CaImagen.TabStop = false;
            // 
            // FrmMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(383, 188);
            this.Controls.Add(this.CaImagen);
            this.Controls.Add(this.TxtMensaje);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMensaje";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMensaje";
            ((System.ComponentModel.ISupportInitialize)(this.CaImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button Btn1;
        public System.Windows.Forms.Button Btn2;
        public System.Windows.Forms.Button Btn3;
        public System.Windows.Forms.RichTextBox TxtMensaje;
        public System.Windows.Forms.PictureBox CaImagen;
    }
}