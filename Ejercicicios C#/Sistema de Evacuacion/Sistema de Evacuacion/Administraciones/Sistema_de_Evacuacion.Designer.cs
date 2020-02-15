namespace Sistema_de_Evacuacion.Administraciones
{
    partial class Sistema_de_Evacuacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_de_Evacuacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.etiquetaRegistro = new System.Windows.Forms.Label();
            this.botonLogin = new System.Windows.Forms.Button();
            this.botonInformacion = new System.Windows.Forms.Button();
            this.imagenPresentacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "USER:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD:";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUser.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(242, 288);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(282, 41);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPassword.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(242, 344);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(282, 41);
            this.txtPassword.TabIndex = 1;
            // 
            // etiquetaRegistro
            // 
            this.etiquetaRegistro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.etiquetaRegistro.AutoSize = true;
            this.etiquetaRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.etiquetaRegistro.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaRegistro.ForeColor = System.Drawing.Color.Red;
            this.etiquetaRegistro.Location = new System.Drawing.Point(161, 457);
            this.etiquetaRegistro.Name = "etiquetaRegistro";
            this.etiquetaRegistro.Size = new System.Drawing.Size(383, 19);
            this.etiquetaRegistro.TabIndex = 3;
            this.etiquetaRegistro.Text = "¿No dispones de una cuenta? Regístrate ahora.";
            this.etiquetaRegistro.Click += new System.EventHandler(this.etiquetaRegistro_Click);
            // 
            // botonLogin
            // 
            this.botonLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.botonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLogin.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.Location = new System.Drawing.Point(287, 391);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(172, 39);
            this.botonLogin.TabIndex = 2;
            this.botonLogin.Text = "INICIAR SESIÓN";
            this.botonLogin.UseVisualStyleBackColor = false;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // botonInformacion
            // 
            this.botonInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonInformacion.BackColor = System.Drawing.Color.DarkOrange;
            this.botonInformacion.BackgroundImage = global::Sistema_de_Evacuacion.Properties.Resources.Informacion;
            this.botonInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonInformacion.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.botonInformacion.FlatAppearance.BorderSize = 0;
            this.botonInformacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.botonInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.botonInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonInformacion.Location = new System.Drawing.Point(12, 430);
            this.botonInformacion.Name = "botonInformacion";
            this.botonInformacion.Size = new System.Drawing.Size(53, 51);
            this.botonInformacion.TabIndex = 4;
            this.botonInformacion.UseVisualStyleBackColor = false;
            this.botonInformacion.Click += new System.EventHandler(this.botonInformacion_Click);
            // 
            // imagenPresentacion
            // 
            this.imagenPresentacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagenPresentacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenPresentacion.Image = global::Sistema_de_Evacuacion.Properties.Resources.Escape;
            this.imagenPresentacion.Location = new System.Drawing.Point(-2, 0);
            this.imagenPresentacion.Name = "imagenPresentacion";
            this.imagenPresentacion.Size = new System.Drawing.Size(657, 307);
            this.imagenPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPresentacion.TabIndex = 0;
            this.imagenPresentacion.TabStop = false;
            // 
            // Sistema_de_Evacuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(656, 493);
            this.Controls.Add(this.botonInformacion);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.etiquetaRegistro);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagenPresentacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sistema_de_Evacuacion";
            this.Text = "SISTEMA DE EVACUACION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sistema_de_Evacuacion_FormClosing);
            this.Load += new System.EventHandler(this.Sistema_de_Evacuacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenPresentacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenPresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label etiquetaRegistro;
        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Button botonInformacion;
    }
}

