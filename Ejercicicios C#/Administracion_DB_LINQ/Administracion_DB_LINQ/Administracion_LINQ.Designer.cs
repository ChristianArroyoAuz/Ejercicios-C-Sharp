namespace Administracion_DB_LINQ
{
    partial class Administracion_LINQ
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
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.boton_Guardar = new System.Windows.Forms.Button();
            this.boton_Actualizar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.lista_Usuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(274, 5);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(115, 20);
            this.txt_Id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(274, 31);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(115, 20);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(274, 57);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(115, 20);
            this.txt_Login.TabIndex = 7;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(274, 83);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(115, 20);
            this.txt_Password.TabIndex = 8;
            // 
            // boton_Guardar
            // 
            this.boton_Guardar.Location = new System.Drawing.Point(274, 109);
            this.boton_Guardar.Name = "boton_Guardar";
            this.boton_Guardar.Size = new System.Drawing.Size(115, 23);
            this.boton_Guardar.TabIndex = 9;
            this.boton_Guardar.Text = "Guardar";
            this.boton_Guardar.UseVisualStyleBackColor = true;
            this.boton_Guardar.Click += new System.EventHandler(this.boton_Guardar_Click);
            // 
            // boton_Actualizar
            // 
            this.boton_Actualizar.Location = new System.Drawing.Point(274, 138);
            this.boton_Actualizar.Name = "boton_Actualizar";
            this.boton_Actualizar.Size = new System.Drawing.Size(115, 23);
            this.boton_Actualizar.TabIndex = 10;
            this.boton_Actualizar.Text = "Actualizar";
            this.boton_Actualizar.UseVisualStyleBackColor = true;
            this.boton_Actualizar.Click += new System.EventHandler(this.boton_Actualizar_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(274, 167);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(115, 23);
            this.boton_Eliminar.TabIndex = 11;
            this.boton_Eliminar.Text = "Eliminar";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // lista_Usuarios
            // 
            this.lista_Usuarios.FormattingEnabled = true;
            this.lista_Usuarios.Location = new System.Drawing.Point(12, 12);
            this.lista_Usuarios.Name = "lista_Usuarios";
            this.lista_Usuarios.Size = new System.Drawing.Size(194, 173);
            this.lista_Usuarios.TabIndex = 12;
            // 
            // Administracion_LINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 200);
            this.Controls.Add(this.lista_Usuarios);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Actualizar);
            this.Controls.Add(this.boton_Guardar);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label1);
            this.Name = "Administracion_LINQ";
            this.Text = "Administracion LINQ";
            this.Load += new System.EventHandler(this.Administracion_LINQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button boton_Guardar;
        private System.Windows.Forms.Button boton_Actualizar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.ListBox lista_Usuarios;
    }
}

