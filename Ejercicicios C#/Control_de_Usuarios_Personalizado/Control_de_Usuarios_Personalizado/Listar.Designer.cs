namespace Control_de_Usuarios_Personalizado
{
    partial class Listar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boton_Agregar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.etiquetaTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boton_Agregar
            // 
            this.boton_Agregar.Location = new System.Drawing.Point(210, 19);
            this.boton_Agregar.Name = "boton_Agregar";
            this.boton_Agregar.Size = new System.Drawing.Size(141, 20);
            this.boton_Agregar.TabIndex = 5;
            this.boton_Agregar.Text = "AGREGAR";
            this.boton_Agregar.UseVisualStyleBackColor = true;
            this.boton_Agregar.Click += new System.EventHandler(this.boton_Agregar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(56, 19);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(134, 20);
            this.txt_Nombre.TabIndex = 4;
            // 
            // etiquetaTexto
            // 
            this.etiquetaTexto.AutoSize = true;
            this.etiquetaTexto.Location = new System.Drawing.Point(3, 26);
            this.etiquetaTexto.Name = "etiquetaTexto";
            this.etiquetaTexto.Size = new System.Drawing.Size(47, 13);
            this.etiquetaTexto.TabIndex = 3;
            this.etiquetaTexto.Text = "Nombre:";
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boton_Agregar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.etiquetaTexto);
            this.Name = "Listar";
            this.Size = new System.Drawing.Size(377, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_Agregar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label etiquetaTexto;
    }
}
