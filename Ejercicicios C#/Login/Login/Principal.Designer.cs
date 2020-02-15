namespace Login
{
    partial class Principal
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
            this.etiquetaBienvevido = new System.Windows.Forms.Label();
            this.etiquetaUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // etiquetaBienvevido
            // 
            this.etiquetaBienvevido.AutoSize = true;
            this.etiquetaBienvevido.Font = new System.Drawing.Font("SketchFlow Print", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaBienvevido.Location = new System.Drawing.Point(12, 9);
            this.etiquetaBienvevido.Name = "etiquetaBienvevido";
            this.etiquetaBienvevido.Size = new System.Drawing.Size(261, 40);
            this.etiquetaBienvevido.TabIndex = 0;
            this.etiquetaBienvevido.Text = "BIENVENIDO";
            // 
            // etiquetaUser
            // 
            this.etiquetaUser.AutoSize = true;
            this.etiquetaUser.Font = new System.Drawing.Font("SketchFlow Print", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaUser.Location = new System.Drawing.Point(288, 9);
            this.etiquetaUser.Name = "etiquetaUser";
            this.etiquetaUser.Size = new System.Drawing.Size(133, 40);
            this.etiquetaUser.TabIndex = 1;
            this.etiquetaUser.Text = "label2";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 72);
            this.Controls.Add(this.etiquetaUser);
            this.Controls.Add(this.etiquetaBienvevido);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiquetaBienvevido;
        private System.Windows.Forms.Label etiquetaUser;
    }
}