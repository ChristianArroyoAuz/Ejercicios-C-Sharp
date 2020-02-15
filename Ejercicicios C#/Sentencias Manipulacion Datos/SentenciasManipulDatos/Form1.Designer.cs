namespace SentenciasManipulDatos
{
    partial class Form1
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
            this.grbInsertar = new System.Windows.Forms.GroupBox();
            this.grbConsultar = new System.Windows.Forms.GroupBox();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.grbActualizar = new System.Windows.Forms.GroupBox();
            this.txtNombreInsertar = new System.Windows.Forms.TextBox();
            this.txtApellidoInsertar = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstEliminar = new System.Windows.Forms.ListBox();
            this.btnEliminarDatos = new System.Windows.Forms.Button();
            this.cmbDatosActuales = new System.Windows.Forms.ComboBox();
            this.lblApellidoActualizar = new System.Windows.Forms.Label();
            this.lblNombreActualizar = new System.Windows.Forms.Label();
            this.txtApellidoActualizar = new System.Windows.Forms.TextBox();
            this.txtNombreActualizar = new System.Windows.Forms.TextBox();
            this.lblDatosActuales = new System.Windows.Forms.Label();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.grbInsertar.SuspendLayout();
            this.grbConsultar.SuspendLayout();
            this.grbEliminar.SuspendLayout();
            this.grbActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInsertar
            // 
            this.grbInsertar.Controls.Add(this.btnInsertar);
            this.grbInsertar.Controls.Add(this.lblApellido);
            this.grbInsertar.Controls.Add(this.lblNombre);
            this.grbInsertar.Controls.Add(this.txtApellidoInsertar);
            this.grbInsertar.Controls.Add(this.txtNombreInsertar);
            this.grbInsertar.Location = new System.Drawing.Point(12, 13);
            this.grbInsertar.Name = "grbInsertar";
            this.grbInsertar.Size = new System.Drawing.Size(338, 95);
            this.grbInsertar.TabIndex = 0;
            this.grbInsertar.TabStop = false;
            this.grbInsertar.Text = "Insertar";
            // 
            // grbConsultar
            // 
            this.grbConsultar.Controls.Add(this.dataGridView1);
            this.grbConsultar.Location = new System.Drawing.Point(12, 115);
            this.grbConsultar.Name = "grbConsultar";
            this.grbConsultar.Size = new System.Drawing.Size(338, 113);
            this.grbConsultar.TabIndex = 1;
            this.grbConsultar.TabStop = false;
            this.grbConsultar.Text = "Consultar";
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.btnEliminarDatos);
            this.grbEliminar.Controls.Add(this.lstEliminar);
            this.grbEliminar.Location = new System.Drawing.Point(13, 244);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(337, 100);
            this.grbEliminar.TabIndex = 2;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Eliminar";
            // 
            // grbActualizar
            // 
            this.grbActualizar.Controls.Add(this.btnActualizarDatos);
            this.grbActualizar.Controls.Add(this.lblDatosActuales);
            this.grbActualizar.Controls.Add(this.lblApellidoActualizar);
            this.grbActualizar.Controls.Add(this.lblNombreActualizar);
            this.grbActualizar.Controls.Add(this.txtApellidoActualizar);
            this.grbActualizar.Controls.Add(this.txtNombreActualizar);
            this.grbActualizar.Controls.Add(this.cmbDatosActuales);
            this.grbActualizar.Location = new System.Drawing.Point(13, 351);
            this.grbActualizar.Name = "grbActualizar";
            this.grbActualizar.Size = new System.Drawing.Size(337, 100);
            this.grbActualizar.TabIndex = 3;
            this.grbActualizar.TabStop = false;
            this.grbActualizar.Text = "Actualizar";
            // 
            // txtNombreInsertar
            // 
            this.txtNombreInsertar.Location = new System.Drawing.Point(66, 22);
            this.txtNombreInsertar.Name = "txtNombreInsertar";
            this.txtNombreInsertar.Size = new System.Drawing.Size(150, 20);
            this.txtNombreInsertar.TabIndex = 0;
            // 
            // txtApellidoInsertar
            // 
            this.txtApellidoInsertar.Location = new System.Drawing.Point(66, 49);
            this.txtApellidoInsertar.Name = "txtApellidoInsertar";
            this.txtApellidoInsertar.Size = new System.Drawing.Size(150, 20);
            this.txtApellidoInsertar.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(8, 53);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(246, 35);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 74);
            this.dataGridView1.TabIndex = 0;
            // 
            // lstEliminar
            // 
            this.lstEliminar.FormattingEnabled = true;
            this.lstEliminar.Location = new System.Drawing.Point(10, 19);
            this.lstEliminar.Name = "lstEliminar";
            this.lstEliminar.Size = new System.Drawing.Size(221, 69);
            this.lstEliminar.TabIndex = 0;
            // 
            // btnEliminarDatos
            // 
            this.btnEliminarDatos.Location = new System.Drawing.Point(246, 31);
            this.btnEliminarDatos.Name = "btnEliminarDatos";
            this.btnEliminarDatos.Size = new System.Drawing.Size(75, 40);
            this.btnEliminarDatos.TabIndex = 1;
            this.btnEliminarDatos.Text = "Eliminar Datos";
            this.btnEliminarDatos.UseVisualStyleBackColor = true;
            this.btnEliminarDatos.Click += new System.EventHandler(this.btnEliminarDatos_Click);
            // 
            // cmbDatosActuales
            // 
            this.cmbDatosActuales.FormattingEnabled = true;
            this.cmbDatosActuales.Location = new System.Drawing.Point(94, 20);
            this.cmbDatosActuales.Name = "cmbDatosActuales";
            this.cmbDatosActuales.Size = new System.Drawing.Size(121, 21);
            this.cmbDatosActuales.TabIndex = 0;
            // 
            // lblApellidoActualizar
            // 
            this.lblApellidoActualizar.AutoSize = true;
            this.lblApellidoActualizar.Location = new System.Drawing.Point(7, 78);
            this.lblApellidoActualizar.Name = "lblApellidoActualizar";
            this.lblApellidoActualizar.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoActualizar.TabIndex = 7;
            this.lblApellidoActualizar.Text = "Apellido";
            // 
            // lblNombreActualizar
            // 
            this.lblNombreActualizar.AutoSize = true;
            this.lblNombreActualizar.Location = new System.Drawing.Point(6, 51);
            this.lblNombreActualizar.Name = "lblNombreActualizar";
            this.lblNombreActualizar.Size = new System.Drawing.Size(44, 13);
            this.lblNombreActualizar.TabIndex = 6;
            this.lblNombreActualizar.Text = "Nombre";
            // 
            // txtApellidoActualizar
            // 
            this.txtApellidoActualizar.Location = new System.Drawing.Point(65, 74);
            this.txtApellidoActualizar.Name = "txtApellidoActualizar";
            this.txtApellidoActualizar.Size = new System.Drawing.Size(150, 20);
            this.txtApellidoActualizar.TabIndex = 5;
            // 
            // txtNombreActualizar
            // 
            this.txtNombreActualizar.Location = new System.Drawing.Point(65, 47);
            this.txtNombreActualizar.Name = "txtNombreActualizar";
            this.txtNombreActualizar.Size = new System.Drawing.Size(150, 20);
            this.txtNombreActualizar.TabIndex = 4;
            // 
            // lblDatosActuales
            // 
            this.lblDatosActuales.AutoSize = true;
            this.lblDatosActuales.Location = new System.Drawing.Point(7, 22);
            this.lblDatosActuales.Name = "lblDatosActuales";
            this.lblDatosActuales.Size = new System.Drawing.Size(79, 13);
            this.lblDatosActuales.TabIndex = 8;
            this.lblDatosActuales.Text = "Datos Actuales";
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.Location = new System.Drawing.Point(244, 40);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarDatos.TabIndex = 9;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.UseVisualStyleBackColor = true;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 464);
            this.Controls.Add(this.grbActualizar);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbConsultar);
            this.Controls.Add(this.grbInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbInsertar.ResumeLayout(false);
            this.grbInsertar.PerformLayout();
            this.grbConsultar.ResumeLayout(false);
            this.grbEliminar.ResumeLayout(false);
            this.grbActualizar.ResumeLayout(false);
            this.grbActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInsertar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellidoInsertar;
        private System.Windows.Forms.TextBox txtNombreInsertar;
        private System.Windows.Forms.GroupBox grbConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.Button btnEliminarDatos;
        private System.Windows.Forms.ListBox lstEliminar;
        private System.Windows.Forms.GroupBox grbActualizar;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Label lblDatosActuales;
        private System.Windows.Forms.Label lblApellidoActualizar;
        private System.Windows.Forms.Label lblNombreActualizar;
        private System.Windows.Forms.TextBox txtApellidoActualizar;
        private System.Windows.Forms.TextBox txtNombreActualizar;
        private System.Windows.Forms.ComboBox cmbDatosActuales;
    }
}

