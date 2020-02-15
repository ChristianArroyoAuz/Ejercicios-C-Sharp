namespace Traspaso_de_Datos_Formularios
{
    partial class Recepcion_de_Datos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lista_Usuarios = new System.Windows.Forms.ListBox();
            this.boton_Ingresar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.boton_Actualizar = new System.Windows.Forms.Button();
            this.barraEstado_Formulario_Recepcion = new System.Windows.Forms.StatusStrip();
            this.etiquetaEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraEstado_Formulario_Recepcion.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACION DE USUARIOS";
            // 
            // lista_Usuarios
            // 
            this.lista_Usuarios.FormattingEnabled = true;
            this.lista_Usuarios.Location = new System.Drawing.Point(17, 52);
            this.lista_Usuarios.Name = "lista_Usuarios";
            this.lista_Usuarios.Size = new System.Drawing.Size(335, 108);
            this.lista_Usuarios.TabIndex = 1;
            this.lista_Usuarios.SelectedIndexChanged += new System.EventHandler(this.lista_Usuarios_SelectedIndexChanged);
            // 
            // boton_Ingresar
            // 
            this.boton_Ingresar.Location = new System.Drawing.Point(17, 175);
            this.boton_Ingresar.Name = "boton_Ingresar";
            this.boton_Ingresar.Size = new System.Drawing.Size(106, 23);
            this.boton_Ingresar.TabIndex = 2;
            this.boton_Ingresar.Text = "INGRESAR";
            this.boton_Ingresar.UseVisualStyleBackColor = true;
            this.boton_Ingresar.Click += new System.EventHandler(this.boton_Ingresar_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(246, 175);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(106, 23);
            this.boton_Eliminar.TabIndex = 3;
            this.boton_Eliminar.Text = "ELIMINAR";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // boton_Actualizar
            // 
            this.boton_Actualizar.Location = new System.Drawing.Point(134, 175);
            this.boton_Actualizar.Name = "boton_Actualizar";
            this.boton_Actualizar.Size = new System.Drawing.Size(106, 23);
            this.boton_Actualizar.TabIndex = 4;
            this.boton_Actualizar.Text = "ACTUALIZAR";
            this.boton_Actualizar.UseVisualStyleBackColor = true;
            this.boton_Actualizar.Click += new System.EventHandler(this.boton_Actualizar_Click);
            // 
            // barraEstado_Formulario_Recepcion
            // 
            this.barraEstado_Formulario_Recepcion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetaEstado});
            this.barraEstado_Formulario_Recepcion.Location = new System.Drawing.Point(0, 206);
            this.barraEstado_Formulario_Recepcion.Name = "barraEstado_Formulario_Recepcion";
            this.barraEstado_Formulario_Recepcion.Size = new System.Drawing.Size(367, 22);
            this.barraEstado_Formulario_Recepcion.TabIndex = 5;
            this.barraEstado_Formulario_Recepcion.Text = "statusStrip1";
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(32, 17);
            this.etiquetaEstado.Text = "Listo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Recepcion_de_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 228);
            this.Controls.Add(this.barraEstado_Formulario_Recepcion);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.boton_Actualizar);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Ingresar);
            this.Controls.Add(this.lista_Usuarios);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Recepcion_de_Datos";
            this.Text = "Recepcion de Datos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Recepcion_de_Datos_FormClosed);
            this.Load += new System.EventHandler(this.Recepcion_de_Datos_Load);
            this.barraEstado_Formulario_Recepcion.ResumeLayout(false);
            this.barraEstado_Formulario_Recepcion.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lista_Usuarios;
        private System.Windows.Forms.Button boton_Ingresar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Button boton_Actualizar;
        private System.Windows.Forms.StatusStrip barraEstado_Formulario_Recepcion;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaEstado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

