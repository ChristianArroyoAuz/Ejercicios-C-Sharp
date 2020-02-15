namespace User_Activo_Inactivo
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
            this.grpBox_IngresoDatos = new System.Windows.Forms.GroupBox();
            this.msk_Fecha = new System.Windows.Forms.MaskedTextBox();
            this.mskBox_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.cmbBox_Pais = new System.Windows.Forms.ComboBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_IdAutomarcado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox_Intereses = new System.Windows.Forms.GroupBox();
            this.lstBox_Intereses = new System.Windows.Forms.ListBox();
            this.grpBox_Sexo = new System.Windows.Forms.GroupBox();
            this.radBtn_femenino = new System.Windows.Forms.RadioButton();
            this.radBtn_Masculino = new System.Windows.Forms.RadioButton();
            this.grpBox_Estado = new System.Windows.Forms.GroupBox();
            this.radBtn_Inactivo = new System.Windows.Forms.RadioButton();
            this.radBtn_Activo = new System.Windows.Forms.RadioButton();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.grpBox_Registro = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstBox_Inactivos = new System.Windows.Forms.ListBox();
            this.lstBox_Activos = new System.Windows.Forms.ListBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.grpBox_IngresoDatos.SuspendLayout();
            this.grpBox_Intereses.SuspendLayout();
            this.grpBox_Sexo.SuspendLayout();
            this.grpBox_Estado.SuspendLayout();
            this.grpBox_Registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_IngresoDatos
            // 
            this.grpBox_IngresoDatos.Controls.Add(this.msk_Fecha);
            this.grpBox_IngresoDatos.Controls.Add(this.mskBox_Telefono);
            this.grpBox_IngresoDatos.Controls.Add(this.cmbBox_Pais);
            this.grpBox_IngresoDatos.Controls.Add(this.txt_Contrasenia);
            this.grpBox_IngresoDatos.Controls.Add(this.txt_Nombre);
            this.grpBox_IngresoDatos.Controls.Add(this.txt_Login);
            this.grpBox_IngresoDatos.Controls.Add(this.label7);
            this.grpBox_IngresoDatos.Controls.Add(this.label2);
            this.grpBox_IngresoDatos.Controls.Add(this.label6);
            this.grpBox_IngresoDatos.Controls.Add(this.label5);
            this.grpBox_IngresoDatos.Controls.Add(this.label4);
            this.grpBox_IngresoDatos.Controls.Add(this.label3);
            this.grpBox_IngresoDatos.Controls.Add(this.lbl_IdAutomarcado);
            this.grpBox_IngresoDatos.Controls.Add(this.label1);
            this.grpBox_IngresoDatos.Location = new System.Drawing.Point(13, 6);
            this.grpBox_IngresoDatos.Name = "grpBox_IngresoDatos";
            this.grpBox_IngresoDatos.Size = new System.Drawing.Size(230, 200);
            this.grpBox_IngresoDatos.TabIndex = 0;
            this.grpBox_IngresoDatos.TabStop = false;
            this.grpBox_IngresoDatos.Text = "Ingreso de datos:";
            // 
            // msk_Fecha
            // 
            this.msk_Fecha.Location = new System.Drawing.Point(96, 117);
            this.msk_Fecha.Mask = "00/00/0000";
            this.msk_Fecha.Name = "msk_Fecha";
            this.msk_Fecha.Size = new System.Drawing.Size(100, 20);
            this.msk_Fecha.TabIndex = 4;
            this.msk_Fecha.ValidatingType = typeof(System.DateTime);
            // 
            // mskBox_Telefono
            // 
            this.mskBox_Telefono.AccessibleDescription = "";
            this.mskBox_Telefono.Location = new System.Drawing.Point(96, 170);
            this.mskBox_Telefono.Mask = "9999999";
            this.mskBox_Telefono.Name = "mskBox_Telefono";
            this.mskBox_Telefono.PromptChar = '+';
            this.mskBox_Telefono.Size = new System.Drawing.Size(100, 20);
            this.mskBox_Telefono.TabIndex = 6;
            this.mskBox_Telefono.Tag = "";
            // 
            // cmbBox_Pais
            // 
            this.cmbBox_Pais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBox_Pais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBox_Pais.FormattingEnabled = true;
            this.cmbBox_Pais.Items.AddRange(new object[] {
            "Colombia\t",
            "Costa Rica\t",
            "Cuba\t",
            "Ecuador\t",
            "Francia",
            "Alemania\t",
            "Panama\t"});
            this.cmbBox_Pais.Location = new System.Drawing.Point(97, 90);
            this.cmbBox_Pais.Name = "cmbBox_Pais";
            this.cmbBox_Pais.Size = new System.Drawing.Size(127, 21);
            this.cmbBox_Pais.TabIndex = 2;
            this.cmbBox_Pais.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Pais_SelectedIndexChanged);
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.Location = new System.Drawing.Point(97, 143);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.PasswordChar = '*';
            this.txt_Contrasenia.Size = new System.Drawing.Size(100, 20);
            this.txt_Contrasenia.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(97, 65);
            this.txt_Nombre.MaxLength = 1000000;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(97, 39);
            this.txt_Login.MaxLength = 100000;
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Login.Size = new System.Drawing.Size(100, 20);
            this.txt_Login.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "País:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login:";
            // 
            // lbl_IdAutomarcado
            // 
            this.lbl_IdAutomarcado.AutoSize = true;
            this.lbl_IdAutomarcado.Location = new System.Drawing.Point(103, 19);
            this.lbl_IdAutomarcado.Name = "lbl_IdAutomarcado";
            this.lbl_IdAutomarcado.Size = new System.Drawing.Size(13, 13);
            this.lbl_IdAutomarcado.TabIndex = 1;
            this.lbl_IdAutomarcado.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // grpBox_Intereses
            // 
            this.grpBox_Intereses.Controls.Add(this.lstBox_Intereses);
            this.grpBox_Intereses.Location = new System.Drawing.Point(12, 218);
            this.grpBox_Intereses.Name = "grpBox_Intereses";
            this.grpBox_Intereses.Size = new System.Drawing.Size(231, 112);
            this.grpBox_Intereses.TabIndex = 1;
            this.grpBox_Intereses.TabStop = false;
            this.grpBox_Intereses.Text = "Intereses:";
            // 
            // lstBox_Intereses
            // 
            this.lstBox_Intereses.FormattingEnabled = true;
            this.lstBox_Intereses.Items.AddRange(new object[] {
            "Ciencia",
            "Deportes",
            "Educación",
            "Ocio",
            "Salud"});
            this.lstBox_Intereses.Location = new System.Drawing.Point(9, 17);
            this.lstBox_Intereses.Name = "lstBox_Intereses";
            this.lstBox_Intereses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBox_Intereses.Size = new System.Drawing.Size(188, 82);
            this.lstBox_Intereses.TabIndex = 7;
            this.lstBox_Intereses.SelectedIndexChanged += new System.EventHandler(this.lstBox_Intereses_SelectedIndexChanged);
            // 
            // grpBox_Sexo
            // 
            this.grpBox_Sexo.Controls.Add(this.radBtn_femenino);
            this.grpBox_Sexo.Controls.Add(this.radBtn_Masculino);
            this.grpBox_Sexo.Location = new System.Drawing.Point(249, 250);
            this.grpBox_Sexo.Name = "grpBox_Sexo";
            this.grpBox_Sexo.Size = new System.Drawing.Size(115, 80);
            this.grpBox_Sexo.TabIndex = 2;
            this.grpBox_Sexo.TabStop = false;
            this.grpBox_Sexo.Text = "Sexo:";
            // 
            // radBtn_femenino
            // 
            this.radBtn_femenino.AutoSize = true;
            this.radBtn_femenino.Location = new System.Drawing.Point(9, 42);
            this.radBtn_femenino.Name = "radBtn_femenino";
            this.radBtn_femenino.Size = new System.Drawing.Size(71, 17);
            this.radBtn_femenino.TabIndex = 9;
            this.radBtn_femenino.TabStop = true;
            this.radBtn_femenino.Text = "Femenino";
            this.radBtn_femenino.UseVisualStyleBackColor = true;
            // 
            // radBtn_Masculino
            // 
            this.radBtn_Masculino.AutoSize = true;
            this.radBtn_Masculino.Location = new System.Drawing.Point(9, 19);
            this.radBtn_Masculino.Name = "radBtn_Masculino";
            this.radBtn_Masculino.Size = new System.Drawing.Size(73, 17);
            this.radBtn_Masculino.TabIndex = 8;
            this.radBtn_Masculino.TabStop = true;
            this.radBtn_Masculino.Text = "Masculino";
            this.radBtn_Masculino.UseVisualStyleBackColor = true;
            // 
            // grpBox_Estado
            // 
            this.grpBox_Estado.Controls.Add(this.radBtn_Inactivo);
            this.grpBox_Estado.Controls.Add(this.radBtn_Activo);
            this.grpBox_Estado.Location = new System.Drawing.Point(370, 250);
            this.grpBox_Estado.Name = "grpBox_Estado";
            this.grpBox_Estado.Size = new System.Drawing.Size(137, 81);
            this.grpBox_Estado.TabIndex = 3;
            this.grpBox_Estado.TabStop = false;
            this.grpBox_Estado.Text = "Estado:";
            // 
            // radBtn_Inactivo
            // 
            this.radBtn_Inactivo.AutoSize = true;
            this.radBtn_Inactivo.Location = new System.Drawing.Point(14, 43);
            this.radBtn_Inactivo.Name = "radBtn_Inactivo";
            this.radBtn_Inactivo.Size = new System.Drawing.Size(63, 17);
            this.radBtn_Inactivo.TabIndex = 11;
            this.radBtn_Inactivo.TabStop = true;
            this.radBtn_Inactivo.Text = "Inactivo";
            this.radBtn_Inactivo.UseVisualStyleBackColor = true;
            // 
            // radBtn_Activo
            // 
            this.radBtn_Activo.AutoSize = true;
            this.radBtn_Activo.Location = new System.Drawing.Point(14, 19);
            this.radBtn_Activo.Name = "radBtn_Activo";
            this.radBtn_Activo.Size = new System.Drawing.Size(55, 17);
            this.radBtn_Activo.TabIndex = 10;
            this.radBtn_Activo.TabStop = true;
            this.radBtn_Activo.Text = "Activo";
            this.radBtn_Activo.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(513, 252);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(94, 34);
            this.btn_Nuevo.TabIndex = 14;
            this.btn_Nuevo.Text = "Nuevo usuario";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(617, 254);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(121, 30);
            this.btn_Guardar.TabIndex = 12;
            this.btn_Guardar.Text = "Guardar Info Usuario";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(513, 293);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(94, 31);
            this.btn_Eliminar.TabIndex = 17;
            this.btn_Eliminar.Text = "Eliminar Usuario";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // grpBox_Registro
            // 
            this.grpBox_Registro.Controls.Add(this.label9);
            this.grpBox_Registro.Controls.Add(this.label8);
            this.grpBox_Registro.Controls.Add(this.lstBox_Inactivos);
            this.grpBox_Registro.Controls.Add(this.lstBox_Activos);
            this.grpBox_Registro.Location = new System.Drawing.Point(249, 6);
            this.grpBox_Registro.Name = "grpBox_Registro";
            this.grpBox_Registro.Size = new System.Drawing.Size(489, 238);
            this.grpBox_Registro.TabIndex = 7;
            this.grpBox_Registro.TabStop = false;
            this.grpBox_Registro.Text = "Registro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Usuarios inactivos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Usuarios activos:";
            // 
            // lstBox_Inactivos
            // 
            this.lstBox_Inactivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstBox_Inactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox_Inactivos.FormattingEnabled = true;
            this.lstBox_Inactivos.Location = new System.Drawing.Point(9, 145);
            this.lstBox_Inactivos.Name = "lstBox_Inactivos";
            this.lstBox_Inactivos.Size = new System.Drawing.Size(474, 69);
            this.lstBox_Inactivos.Sorted = true;
            this.lstBox_Inactivos.TabIndex = 16;
            this.lstBox_Inactivos.SelectedIndexChanged += new System.EventHandler(this.lstBox_Inactivos_SelectedIndexChanged);
            // 
            // lstBox_Activos
            // 
            this.lstBox_Activos.AccessibleDescription = "";
            this.lstBox_Activos.AccessibleName = "";
            this.lstBox_Activos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstBox_Activos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox_Activos.FormattingEnabled = true;
            this.lstBox_Activos.Location = new System.Drawing.Point(9, 37);
            this.lstBox_Activos.Name = "lstBox_Activos";
            this.lstBox_Activos.Size = new System.Drawing.Size(474, 69);
            this.lstBox_Activos.Sorted = true;
            this.lstBox_Activos.TabIndex = 15;
            this.lstBox_Activos.SelectedIndexChanged += new System.EventHandler(this.lstBox_Activos_SelectedIndexChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(617, 293);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(121, 31);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 336);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.grpBox_Registro);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.grpBox_Estado);
            this.Controls.Add(this.grpBox_Sexo);
            this.Controls.Add(this.grpBox_Intereses);
            this.Controls.Add(this.grpBox_IngresoDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox_IngresoDatos.ResumeLayout(false);
            this.grpBox_IngresoDatos.PerformLayout();
            this.grpBox_Intereses.ResumeLayout(false);
            this.grpBox_Sexo.ResumeLayout(false);
            this.grpBox_Sexo.PerformLayout();
            this.grpBox_Estado.ResumeLayout(false);
            this.grpBox_Estado.PerformLayout();
            this.grpBox_Registro.ResumeLayout(false);
            this.grpBox_Registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_IngresoDatos;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_IdAutomarcado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox_Intereses;
        private System.Windows.Forms.ListBox lstBox_Intereses;
        private System.Windows.Forms.GroupBox grpBox_Sexo;
        private System.Windows.Forms.RadioButton radBtn_femenino;
        private System.Windows.Forms.RadioButton radBtn_Masculino;
        private System.Windows.Forms.GroupBox grpBox_Estado;
        private System.Windows.Forms.RadioButton radBtn_Inactivo;
        private System.Windows.Forms.RadioButton radBtn_Activo;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.GroupBox grpBox_Registro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstBox_Inactivos;
        private System.Windows.Forms.ListBox lstBox_Activos;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox mskBox_Telefono;
        private System.Windows.Forms.MaskedTextBox msk_Fecha;
        public System.Windows.Forms.ComboBox cmbBox_Pais;
    }
}

