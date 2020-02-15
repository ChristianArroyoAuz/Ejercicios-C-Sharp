namespace Login_MDI
{
    partial class Administracion
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
            this.menuStrip_Administrador = new System.Windows.Forms.MenuStrip();
            this.boton_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_Compras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Administrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Administrador
            // 
            this.menuStrip_Administrador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boton_Nuevo});
            this.menuStrip_Administrador.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Administrador.Name = "menuStrip_Administrador";
            this.menuStrip_Administrador.Size = new System.Drawing.Size(480, 24);
            this.menuStrip_Administrador.TabIndex = 1;
            this.menuStrip_Administrador.Text = "menuStrip1";
            // 
            // boton_Nuevo
            // 
            this.boton_Nuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boton_Ventas,
            this.boton_Compras});
            this.boton_Nuevo.Name = "boton_Nuevo";
            this.boton_Nuevo.Size = new System.Drawing.Size(54, 20);
            this.boton_Nuevo.Text = "Nuevo";
            // 
            // boton_Ventas
            // 
            this.boton_Ventas.Name = "boton_Ventas";
            this.boton_Ventas.Size = new System.Drawing.Size(152, 22);
            this.boton_Ventas.Text = "Ventas";
            this.boton_Ventas.Click += new System.EventHandler(this.boton_Ventas_Click);
            // 
            // boton_Compras
            // 
            this.boton_Compras.Name = "boton_Compras";
            this.boton_Compras.Size = new System.Drawing.Size(152, 22);
            this.boton_Compras.Text = "Compras";
            this.boton_Compras.Click += new System.EventHandler(this.boton_Compras_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 407);
            this.Controls.Add(this.menuStrip_Administrador);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_Administrador;
            this.Name = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.menuStrip_Administrador.ResumeLayout(false);
            this.menuStrip_Administrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Administrador;
        private System.Windows.Forms.ToolStripMenuItem boton_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem boton_Ventas;
        private System.Windows.Forms.ToolStripMenuItem boton_Compras;
    }
}