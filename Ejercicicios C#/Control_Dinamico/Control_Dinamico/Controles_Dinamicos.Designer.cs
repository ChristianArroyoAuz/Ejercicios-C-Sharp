namespace Control_Dinamico
{
    partial class Controles_Dinamicos
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
            this.boton_Crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_Crear
            // 
            this.boton_Crear.Location = new System.Drawing.Point(12, 12);
            this.boton_Crear.Name = "boton_Crear";
            this.boton_Crear.Size = new System.Drawing.Size(75, 23);
            this.boton_Crear.TabIndex = 0;
            this.boton_Crear.Text = "Crear";
            this.boton_Crear.UseVisualStyleBackColor = true;
            this.boton_Crear.Click += new System.EventHandler(this.boton_Crear_Click);
            // 
            // Controles_Dinamicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.boton_Crear);
            this.Name = "Controles_Dinamicos";
            this.Text = "Controles Dinamicos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_Crear;
    }
}

