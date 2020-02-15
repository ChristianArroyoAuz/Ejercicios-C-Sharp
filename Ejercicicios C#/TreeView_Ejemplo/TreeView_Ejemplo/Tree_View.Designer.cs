namespace TreeView_Ejemplo
{
    partial class Tree_View
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
            this.arbol_Peliculas = new System.Windows.Forms.TreeView();
            this.etiquetaPeliculas = new System.Windows.Forms.Label();
            this.arbol_Peliculas_2 = new System.Windows.Forms.TreeView();
            this.etiqueta_Peliculas_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arbol_Peliculas
            // 
            this.arbol_Peliculas.Location = new System.Drawing.Point(12, 25);
            this.arbol_Peliculas.Name = "arbol_Peliculas";
            this.arbol_Peliculas.Size = new System.Drawing.Size(260, 76);
            this.arbol_Peliculas.TabIndex = 0;
            this.arbol_Peliculas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.arbol_Peliculas_AfterSelect);
            // 
            // etiquetaPeliculas
            // 
            this.etiquetaPeliculas.AutoSize = true;
            this.etiquetaPeliculas.Location = new System.Drawing.Point(9, 9);
            this.etiquetaPeliculas.Name = "etiquetaPeliculas";
            this.etiquetaPeliculas.Size = new System.Drawing.Size(61, 13);
            this.etiquetaPeliculas.TabIndex = 2;
            this.etiquetaPeliculas.Text = "Peliculas 1.";
            // 
            // arbol_Peliculas_2
            // 
            this.arbol_Peliculas_2.Location = new System.Drawing.Point(12, 128);
            this.arbol_Peliculas_2.Name = "arbol_Peliculas_2";
            this.arbol_Peliculas_2.Size = new System.Drawing.Size(260, 68);
            this.arbol_Peliculas_2.TabIndex = 3;
            // 
            // etiqueta_Peliculas_2
            // 
            this.etiqueta_Peliculas_2.AutoSize = true;
            this.etiqueta_Peliculas_2.Location = new System.Drawing.Point(12, 112);
            this.etiqueta_Peliculas_2.Name = "etiqueta_Peliculas_2";
            this.etiqueta_Peliculas_2.Size = new System.Drawing.Size(67, 13);
            this.etiqueta_Peliculas_2.TabIndex = 4;
            this.etiqueta_Peliculas_2.Text = "Pelicualas 2.";
            // 
            // Tree_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.etiqueta_Peliculas_2);
            this.Controls.Add(this.arbol_Peliculas_2);
            this.Controls.Add(this.etiquetaPeliculas);
            this.Controls.Add(this.arbol_Peliculas);
            this.Name = "Tree_View";
            this.Text = "Arbol de Directorios";
            this.Load += new System.EventHandler(this.Tree_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView arbol_Peliculas;
        private System.Windows.Forms.Label etiquetaPeliculas;
        private System.Windows.Forms.TreeView arbol_Peliculas_2;
        private System.Windows.Forms.Label etiqueta_Peliculas_2;
    }
}

