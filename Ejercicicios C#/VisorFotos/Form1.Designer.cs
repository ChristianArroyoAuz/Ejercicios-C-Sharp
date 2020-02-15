namespace VisorFotos
{
    partial class VisorFotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorFotos));
            this.picMostrarFoto = new System.Windows.Forms.PictureBox();
            this.btnSeleccionFoto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ofdSeleccionFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnAgrandar = new System.Windows.Forms.Button();
            this.btnReducir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picMostrarFoto
            // 
            this.picMostrarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picMostrarFoto.BackColor = System.Drawing.Color.White;
            this.picMostrarFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMostrarFoto.Location = new System.Drawing.Point(23, 33);
            this.picMostrarFoto.Name = "picMostrarFoto";
            this.picMostrarFoto.Size = new System.Drawing.Size(380, 258);
            this.picMostrarFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMostrarFoto.TabIndex = 0;
            this.picMostrarFoto.TabStop = false;
            this.picMostrarFoto.Click += new System.EventHandler(this.picMostrarFoto_Click);
            // 
            // btnSeleccionFoto
            // 
            this.btnSeleccionFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionFoto.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSeleccionFoto.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionFoto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSeleccionFoto.Location = new System.Drawing.Point(467, 81);
            this.btnSeleccionFoto.Name = "btnSeleccionFoto";
            this.btnSeleccionFoto.Size = new System.Drawing.Size(117, 32);
            this.btnSeleccionFoto.TabIndex = 1;
            this.btnSeleccionFoto.Text = "Seleccionar";
            this.btnSeleccionFoto.UseVisualStyleBackColor = false;
            this.btnSeleccionFoto.Click += new System.EventHandler(this.btnSeleccionFoto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Location = new System.Drawing.Point(627, 81);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 33);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ofdSeleccionFoto
            // 
            this.ofdSeleccionFoto.Filter = "Archivos Bitmap|*.BMP|Archivos JPEG|*.JPG|Archivos GIF|*.GIF";
            this.ofdSeleccionFoto.Title = "Seleccionar una foto";
            // 
            // btnAgrandar
            // 
            this.btnAgrandar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgrandar.Location = new System.Drawing.Point(583, 253);
            this.btnAgrandar.Name = "btnAgrandar";
            this.btnAgrandar.Size = new System.Drawing.Size(38, 23);
            this.btnAgrandar.TabIndex = 3;
            this.btnAgrandar.Text = "^";
            this.btnAgrandar.UseVisualStyleBackColor = true;
            this.btnAgrandar.Click += new System.EventHandler(this.btnAgrandar_Click);
            // 
            // btnReducir
            // 
            this.btnReducir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReducir.Location = new System.Drawing.Point(627, 253);
            this.btnReducir.Name = "btnReducir";
            this.btnReducir.Size = new System.Drawing.Size(38, 23);
            this.btnReducir.TabIndex = 4;
            this.btnReducir.Text = "v";
            this.btnReducir.UseVisualStyleBackColor = true;
            this.btnReducir.Click += new System.EventHandler(this.btnReducir_Click);
            // 
            // VisorFotos
            // 
            this.AcceptButton = this.btnSeleccionFoto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(801, 303);
            this.Controls.Add(this.btnReducir);
            this.Controls.Add(this.btnAgrandar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSeleccionFoto);
            this.Controls.Add(this.picMostrarFoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisorFotos";
            this.Text = "Visor de Fotos";
            this.Load += new System.EventHandler(this.VisorFotos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMostrarFoto;
        private System.Windows.Forms.Button btnSeleccionFoto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.OpenFileDialog ofdSeleccionFoto;
        private System.Windows.Forms.Button btnAgrandar;
        private System.Windows.Forms.Button btnReducir;
    }
}

