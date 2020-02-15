namespace ControlUsuarioBuscar
{
    partial class CuadroDeBusqueda
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.EtiquetaBuscar = new System.Windows.Forms.Label();
            this.Buscartxt = new System.Windows.Forms.TextBox();
            this.EtiquetaMensajeError = new System.Windows.Forms.Label();
            this.EtiquetaMensajeBusqueda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(281, 12);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscar.TabIndex = 0;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // EtiquetaBuscar
            // 
            this.EtiquetaBuscar.AutoSize = true;
            this.EtiquetaBuscar.Location = new System.Drawing.Point(15, 22);
            this.EtiquetaBuscar.Name = "EtiquetaBuscar";
            this.EtiquetaBuscar.Size = new System.Drawing.Size(63, 13);
            this.EtiquetaBuscar.TabIndex = 1;
            this.EtiquetaBuscar.Text = "Que Busca:";
            // 
            // Buscartxt
            // 
            this.Buscartxt.Location = new System.Drawing.Point(84, 16);
            this.Buscartxt.Name = "Buscartxt";
            this.Buscartxt.Size = new System.Drawing.Size(191, 20);
            this.Buscartxt.TabIndex = 3;
            this.Buscartxt.Text = "Ingrese la Palabra o Letra a Buscar...";
            this.Buscartxt.Click += new System.EventHandler(this.Buscartxt_Click);
            // 
            // EtiquetaMensajeError
            // 
            this.EtiquetaMensajeError.AutoSize = true;
            this.EtiquetaMensajeError.Location = new System.Drawing.Point(81, 66);
            this.EtiquetaMensajeError.Name = "EtiquetaMensajeError";
            this.EtiquetaMensajeError.Size = new System.Drawing.Size(0, 13);
            this.EtiquetaMensajeError.TabIndex = 4;
            // 
            // EtiquetaMensajeBusqueda
            // 
            this.EtiquetaMensajeBusqueda.AutoSize = true;
            this.EtiquetaMensajeBusqueda.Location = new System.Drawing.Point(81, 39);
            this.EtiquetaMensajeBusqueda.Name = "EtiquetaMensajeBusqueda";
            this.EtiquetaMensajeBusqueda.Size = new System.Drawing.Size(0, 13);
            this.EtiquetaMensajeBusqueda.TabIndex = 5;
            // 
            // CuadroDeBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EtiquetaMensajeBusqueda);
            this.Controls.Add(this.EtiquetaMensajeError);
            this.Controls.Add(this.Buscartxt);
            this.Controls.Add(this.EtiquetaBuscar);
            this.Controls.Add(this.BotonBuscar);
            this.Name = "CuadroDeBusqueda";
            this.Size = new System.Drawing.Size(452, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.Label EtiquetaBuscar;
        private System.Windows.Forms.TextBox Buscartxt;
        private System.Windows.Forms.Label EtiquetaMensajeError;
        private System.Windows.Forms.Label EtiquetaMensajeBusqueda;
    }
}
