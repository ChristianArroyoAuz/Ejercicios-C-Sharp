namespace ControlUsuarioBuscar
{
    partial class Buscador_de_Palabras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador_de_Palabras));
            this.Lista_de_Resultados = new System.Windows.Forms.ListBox();
            this.Control_Usuario = new ControlUsuarioBuscar.CuadroDeBusqueda();
            this.SuspendLayout();
            // 
            // Lista_de_Resultados
            // 
            this.Lista_de_Resultados.FormattingEnabled = true;
            this.Lista_de_Resultados.Location = new System.Drawing.Point(12, 103);
            this.Lista_de_Resultados.Name = "Lista_de_Resultados";
            this.Lista_de_Resultados.Size = new System.Drawing.Size(458, 121);
            this.Lista_de_Resultados.TabIndex = 1;
            // 
            // Control_Usuario
            // 
            this.Control_Usuario.Location = new System.Drawing.Point(12, 12);
            this.Control_Usuario.Name = "Control_Usuario";
            this.Control_Usuario.ResultadoBusqueda1 = ((System.Collections.Generic.List<string>)(resources.GetObject("Control_Usuario.ResultadoBusqueda1")));
            this.Control_Usuario.Size = new System.Drawing.Size(458, 90);
            this.Control_Usuario.TabIndex = 0;
            this.Control_Usuario.Texto_a_Buscar1 = null;
            // 
            // Buscador_de_Palabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 240);
            this.Controls.Add(this.Lista_de_Resultados);
            this.Controls.Add(this.Control_Usuario);
            this.Name = "Buscador_de_Palabras";
            this.Text = "Buscador Palabras";
            this.Load += new System.EventHandler(this.Buscador_de_Palabras_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CuadroDeBusqueda Control_Usuario;
        private System.Windows.Forms.ListBox Lista_de_Resultados;
    }
}