namespace Administracion_De_Autos
{
    partial class Administracion_de_Autos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.idtxt = new System.Windows.Forms.Label();
            this.lista_de_Autos = new System.Windows.Forms.ListBox();
            this.EtiquetaId = new System.Windows.Forms.Label();
            this.marcatxt = new System.Windows.Forms.TextBox();
            this.modelotxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EtiquetaModelo = new System.Windows.Forms.Label();
            this.EtiquetaNombre = new System.Windows.Forms.Label();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idtxt
            // 
            this.idtxt.AutoSize = true;
            this.idtxt.Location = new System.Drawing.Point(73, 9);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(13, 13);
            this.idtxt.TabIndex = 22;
            this.idtxt.Text = "1";
            // 
            // lista_de_Autos
            // 
            this.lista_de_Autos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lista_de_Autos.FormattingEnabled = true;
            this.lista_de_Autos.Location = new System.Drawing.Point(182, 9);
            this.lista_de_Autos.Name = "lista_de_Autos";
            this.lista_de_Autos.Size = new System.Drawing.Size(299, 95);
            this.lista_de_Autos.TabIndex = 21;
            this.lista_de_Autos.SelectedIndexChanged += new System.EventHandler(this.lista_de_Autos_SelectedIndexChanged);
            // 
            // EtiquetaId
            // 
            this.EtiquetaId.AutoSize = true;
            this.EtiquetaId.Location = new System.Drawing.Point(12, 9);
            this.EtiquetaId.Name = "EtiquetaId";
            this.EtiquetaId.Size = new System.Drawing.Size(16, 13);
            this.EtiquetaId.TabIndex = 20;
            this.EtiquetaId.Text = "Id";
            // 
            // marcatxt
            // 
            this.marcatxt.Location = new System.Drawing.Point(76, 78);
            this.marcatxt.Name = "marcatxt";
            this.marcatxt.Size = new System.Drawing.Size(100, 20);
            this.marcatxt.TabIndex = 18;
            // 
            // modelotxt
            // 
            this.modelotxt.Location = new System.Drawing.Point(76, 52);
            this.modelotxt.Name = "modelotxt";
            this.modelotxt.Size = new System.Drawing.Size(100, 20);
            this.modelotxt.TabIndex = 17;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(76, 26);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(100, 20);
            this.nombretxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Marca";
            // 
            // EtiquetaModelo
            // 
            this.EtiquetaModelo.AutoSize = true;
            this.EtiquetaModelo.Location = new System.Drawing.Point(12, 55);
            this.EtiquetaModelo.Name = "EtiquetaModelo";
            this.EtiquetaModelo.Size = new System.Drawing.Size(42, 13);
            this.EtiquetaModelo.TabIndex = 14;
            this.EtiquetaModelo.Text = "Modelo";
            // 
            // EtiquetaNombre
            // 
            this.EtiquetaNombre.AutoSize = true;
            this.EtiquetaNombre.Location = new System.Drawing.Point(12, 29);
            this.EtiquetaNombre.Name = "EtiquetaNombre";
            this.EtiquetaNombre.Size = new System.Drawing.Size(44, 13);
            this.EtiquetaNombre.TabIndex = 13;
            this.EtiquetaNombre.Text = "Nombre";
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(182, 120);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(101, 23);
            this.botonGuardar.TabIndex = 12;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(75, 120);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(101, 23);
            this.botonNuevo.TabIndex = 23;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(289, 120);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(101, 23);
            this.botonEliminar.TabIndex = 24;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // Administracion_de_Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(497, 154);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.lista_de_Autos);
            this.Controls.Add(this.EtiquetaId);
            this.Controls.Add(this.marcatxt);
            this.Controls.Add(this.modelotxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EtiquetaModelo);
            this.Controls.Add(this.EtiquetaNombre);
            this.Controls.Add(this.botonGuardar);
            this.Name = "Administracion_de_Autos";
            this.Text = "Administracion de Autos";
            this.Load += new System.EventHandler(this.Administracion_de_Autos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idtxt;
        private System.Windows.Forms.ListBox lista_de_Autos;
        private System.Windows.Forms.Label EtiquetaId;
        private System.Windows.Forms.TextBox marcatxt;
        private System.Windows.Forms.TextBox modelotxt;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EtiquetaModelo;
        private System.Windows.Forms.Label EtiquetaNombre;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonEliminar;
    }
}

