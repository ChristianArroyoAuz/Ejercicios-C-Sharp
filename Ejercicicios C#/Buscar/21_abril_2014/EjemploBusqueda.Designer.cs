namespace _21_abril_2014
{
    partial class EjemploBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjemploBusqueda));
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.cuadroBusqueda1 = new _21_abril_2014.CuadroBusqueda();
            this.SuspendLayout();
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(38, 65);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(319, 212);
            this.lstResultados.TabIndex = 1;
            // 
            // cuadroBusqueda1
            // 
            this.cuadroBusqueda1.Location = new System.Drawing.Point(12, 12);
            this.cuadroBusqueda1.Name = "cuadroBusqueda1";
            this.cuadroBusqueda1.Resultado = ((System.Collections.Generic.List<string>)(resources.GetObject("cuadroBusqueda1.Resultado")));
            this.cuadroBusqueda1.Size = new System.Drawing.Size(372, 46);
            this.cuadroBusqueda1.TabIndex = 0;
            this.cuadroBusqueda1.TextoBuscar = null;
            this.cuadroBusqueda1.Load += new System.EventHandler(this.cuadroBusqueda1_Load);
            // 
            // EjemploBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 297);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.cuadroBusqueda1);
            this.Name = "EjemploBusqueda";
            this.Text = "EjemploBusqueda";
            this.Load += new System.EventHandler(this.EjemploBusqueda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CuadroBusqueda cuadroBusqueda1;
        private System.Windows.Forms.ListBox lstResultados;
    }
}