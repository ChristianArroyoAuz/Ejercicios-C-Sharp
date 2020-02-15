namespace Paso_Datos_MDI
{
    partial class FormHijo_AdminUsuarios
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
            this.lstBox_Usuarios_FormAdminUsuarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_ID_AdminUsuarios = new System.Windows.Forms.TextBox();
            this.txtBox_Login_AdminUsuarios = new System.Windows.Forms.TextBox();
            this.txtBox_Password_AdminUsuarios = new System.Windows.Forms.TextBox();
            this.txtBox_Nombre_AdminUsuarios = new System.Windows.Forms.TextBox();
            this.btn_Aceptar_AdminUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox_Usuarios_FormAdminUsuarios
            // 
            this.lstBox_Usuarios_FormAdminUsuarios.FormattingEnabled = true;
            this.lstBox_Usuarios_FormAdminUsuarios.Location = new System.Drawing.Point(13, 25);
            this.lstBox_Usuarios_FormAdminUsuarios.Name = "lstBox_Usuarios_FormAdminUsuarios";
            this.lstBox_Usuarios_FormAdminUsuarios.Size = new System.Drawing.Size(220, 108);
            this.lstBox_Usuarios_FormAdminUsuarios.TabIndex = 0;
            this.lstBox_Usuarios_FormAdminUsuarios.SelectedIndexChanged += new System.EventHandler(this.lstBox_Usuarios_FormAdminUsuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre:";
            // 
            // txtBox_ID_AdminUsuarios
            // 
            this.txtBox_ID_AdminUsuarios.Location = new System.Drawing.Point(323, 25);
            this.txtBox_ID_AdminUsuarios.Name = "txtBox_ID_AdminUsuarios";
            this.txtBox_ID_AdminUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ID_AdminUsuarios.TabIndex = 6;
            // 
            // txtBox_Login_AdminUsuarios
            // 
            this.txtBox_Login_AdminUsuarios.Location = new System.Drawing.Point(323, 55);
            this.txtBox_Login_AdminUsuarios.Name = "txtBox_Login_AdminUsuarios";
            this.txtBox_Login_AdminUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Login_AdminUsuarios.TabIndex = 7;
            // 
            // txtBox_Password_AdminUsuarios
            // 
            this.txtBox_Password_AdminUsuarios.Location = new System.Drawing.Point(323, 84);
            this.txtBox_Password_AdminUsuarios.Name = "txtBox_Password_AdminUsuarios";
            this.txtBox_Password_AdminUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Password_AdminUsuarios.TabIndex = 8;
            // 
            // txtBox_Nombre_AdminUsuarios
            // 
            this.txtBox_Nombre_AdminUsuarios.Location = new System.Drawing.Point(323, 113);
            this.txtBox_Nombre_AdminUsuarios.Name = "txtBox_Nombre_AdminUsuarios";
            this.txtBox_Nombre_AdminUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Nombre_AdminUsuarios.TabIndex = 9;
            // 
            // btn_Aceptar_AdminUsuarios
            // 
            this.btn_Aceptar_AdminUsuarios.Location = new System.Drawing.Point(308, 139);
            this.btn_Aceptar_AdminUsuarios.Name = "btn_Aceptar_AdminUsuarios";
            this.btn_Aceptar_AdminUsuarios.Size = new System.Drawing.Size(115, 23);
            this.btn_Aceptar_AdminUsuarios.TabIndex = 10;
            this.btn_Aceptar_AdminUsuarios.Text = "Aceptar";
            this.btn_Aceptar_AdminUsuarios.UseVisualStyleBackColor = true;
            this.btn_Aceptar_AdminUsuarios.Click += new System.EventHandler(this.btn_Aceptar_AdminUsuarios_Click);
            // 
            // FormHijo_AdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 170);
            this.Controls.Add(this.btn_Aceptar_AdminUsuarios);
            this.Controls.Add(this.txtBox_Nombre_AdminUsuarios);
            this.Controls.Add(this.txtBox_Password_AdminUsuarios);
            this.Controls.Add(this.txtBox_Login_AdminUsuarios);
            this.Controls.Add(this.txtBox_ID_AdminUsuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBox_Usuarios_FormAdminUsuarios);
            this.Name = "FormHijo_AdminUsuarios";
            this.Text = "FormHijo_AdminUsuarios";
            this.Load += new System.EventHandler(this.FormHijo_AdminUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_Usuarios_FormAdminUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_ID_AdminUsuarios;
        private System.Windows.Forms.TextBox txtBox_Login_AdminUsuarios;
        private System.Windows.Forms.TextBox txtBox_Password_AdminUsuarios;
        private System.Windows.Forms.TextBox txtBox_Nombre_AdminUsuarios;
        private System.Windows.Forms.Button btn_Aceptar_AdminUsuarios;
    }
}