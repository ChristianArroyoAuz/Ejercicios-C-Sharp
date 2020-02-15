namespace MDI_Ejemplo
{
    partial class Form1
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
            this.menu_Actividades = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_Compras = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Actividades.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Actividades
            // 
            this.menu_Actividades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menu_Actividades.Location = new System.Drawing.Point(0, 0);
            this.menu_Actividades.Name = "menu_Actividades";
            this.menu_Actividades.Size = new System.Drawing.Size(463, 24);
            this.menu_Actividades.TabIndex = 1;
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boton_Compras,
            this.boton_Ventas});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // boton_Compras
            // 
            this.boton_Compras.Name = "boton_Compras";
            this.boton_Compras.Size = new System.Drawing.Size(152, 22);
            this.boton_Compras.Text = "Compras";
            this.boton_Compras.Click += new System.EventHandler(this.boton_Compras_Click);
            // 
            // boton_Ventas
            // 
            this.boton_Ventas.Name = "boton_Ventas";
            this.boton_Ventas.Size = new System.Drawing.Size(152, 22);
            this.boton_Ventas.Text = "Ventas";
            this.boton_Ventas.Click += new System.EventHandler(this.boton_Ventas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 417);
            this.Controls.Add(this.menu_Actividades);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_Actividades;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu_Actividades.ResumeLayout(false);
            this.menu_Actividades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Actividades;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boton_Compras;
        private System.Windows.Forms.ToolStripMenuItem boton_Ventas;
    }
}

