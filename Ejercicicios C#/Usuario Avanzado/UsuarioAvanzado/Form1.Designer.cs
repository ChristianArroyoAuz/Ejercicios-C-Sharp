namespace UsuarioAvanzado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_login = new System.Windows.Forms.TextBox();
            this.grp_datos = new System.Windows.Forms.GroupBox();
            this.txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.lst_intereses = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdb_inactivo = new System.Windows.Forms.RadioButton();
            this.rdb_activo = new System.Windows.Forms.RadioButton();
            this.combo_pais = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.grp_usuarios = new System.Windows.Forms.GroupBox();
            this.lst_inactivos = new System.Windows.Forms.ListBox();
            this.lst_activos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contador = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grp_datos.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_usuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            resources.ApplyResources(this.txt_login, "txt_login");
            this.txt_login.Name = "txt_login";
            // 
            // grp_datos
            // 
            resources.ApplyResources(this.grp_datos, "grp_datos");
            this.grp_datos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_datos.BackgroundImage = global::UsuarioAvanzado.Properties.Resources.images;
            this.grp_datos.Controls.Add(this.txt_telefono);
            this.grp_datos.Controls.Add(this.txt_fecha);
            this.grp_datos.Controls.Add(this.lst_intereses);
            this.grp_datos.Controls.Add(this.groupBox4);
            this.grp_datos.Controls.Add(this.combo_pais);
            this.grp_datos.Controls.Add(this.label7);
            this.grp_datos.Controls.Add(this.label6);
            this.grp_datos.Controls.Add(this.label5);
            this.grp_datos.Controls.Add(this.label4);
            this.grp_datos.Controls.Add(this.label2);
            this.grp_datos.Controls.Add(this.label3);
            this.grp_datos.Controls.Add(this.txt_contraseña);
            this.grp_datos.Controls.Add(this.txt_nombre);
            this.grp_datos.Controls.Add(this.txt_login);
            this.grp_datos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grp_datos.Name = "grp_datos";
            this.grp_datos.TabStop = false;
            // 
            // txt_telefono
            // 
            resources.ApplyResources(this.txt_telefono, "txt_telefono");
            this.txt_telefono.Name = "txt_telefono";
            // 
            // txt_fecha
            // 
            resources.ApplyResources(this.txt_fecha, "txt_fecha");
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            this.txt_fecha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lst_intereses
            // 
            this.lst_intereses.FormattingEnabled = true;
            resources.ApplyResources(this.lst_intereses, "lst_intereses");
            this.lst_intereses.Name = "lst_intereses";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.rdb_inactivo);
            this.groupBox4.Controls.Add(this.rdb_activo);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // rdb_inactivo
            // 
            resources.ApplyResources(this.rdb_inactivo, "rdb_inactivo");
            this.rdb_inactivo.Name = "rdb_inactivo";
            this.rdb_inactivo.TabStop = true;
            this.rdb_inactivo.UseVisualStyleBackColor = true;
            // 
            // rdb_activo
            // 
            resources.ApplyResources(this.rdb_activo, "rdb_activo");
            this.rdb_activo.Name = "rdb_activo";
            this.rdb_activo.TabStop = true;
            this.rdb_activo.UseVisualStyleBackColor = true;
            // 
            // combo_pais
            // 
            this.combo_pais.FormattingEnabled = true;
            this.combo_pais.Items.AddRange(new object[] {
            resources.GetString("combo_pais.Items"),
            resources.GetString("combo_pais.Items1"),
            resources.GetString("combo_pais.Items2"),
            resources.GetString("combo_pais.Items3"),
            resources.GetString("combo_pais.Items4"),
            resources.GetString("combo_pais.Items5"),
            resources.GetString("combo_pais.Items6"),
            resources.GetString("combo_pais.Items7"),
            resources.GetString("combo_pais.Items8"),
            resources.GetString("combo_pais.Items9"),
            resources.GetString("combo_pais.Items10"),
            resources.GetString("combo_pais.Items11"),
            resources.GetString("combo_pais.Items12"),
            resources.GetString("combo_pais.Items13"),
            resources.GetString("combo_pais.Items14"),
            resources.GetString("combo_pais.Items15")});
            resources.ApplyResources(this.combo_pais, "combo_pais");
            this.combo_pais.Name = "combo_pais";
            this.combo_pais.SelectedIndexChanged += new System.EventHandler(this.combo_pais_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_contraseña
            // 
            resources.ApplyResources(this.txt_contraseña, "txt_contraseña");
            this.txt_contraseña.Name = "txt_contraseña";
            // 
            // txt_nombre
            // 
            resources.ApplyResources(this.txt_nombre, "txt_nombre");
            this.txt_nombre.Name = "txt_nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::UsuarioAvanzado.Properties.Resources.images;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btn_eliminar, "btn_eliminar");
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btn_guardar, "btn_guardar");
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btn_nuevo, "btn_nuevo");
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // grp_usuarios
            // 
            this.grp_usuarios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grp_usuarios.Controls.Add(this.lst_inactivos);
            this.grp_usuarios.Controls.Add(this.lst_activos);
            resources.ApplyResources(this.grp_usuarios, "grp_usuarios");
            this.grp_usuarios.Name = "grp_usuarios";
            this.grp_usuarios.TabStop = false;
            // 
            // lst_inactivos
            // 
            this.lst_inactivos.FormattingEnabled = true;
            resources.ApplyResources(this.lst_inactivos, "lst_inactivos");
            this.lst_inactivos.Name = "lst_inactivos";
            // 
            // lst_activos
            // 
            this.lst_activos.FormattingEnabled = true;
            resources.ApplyResources(this.lst_activos, "lst_activos");
            this.lst_activos.Name = "lst_activos";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // contador
            // 
            resources.ApplyResources(this.contador, "contador");
            this.contador.Name = "contador";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bandera_de_Guayaquil1.png");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_usuarios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_datos);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_datos.ResumeLayout(false);
            this.grp_datos.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grp_usuarios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.GroupBox grp_datos;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_intereses;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdb_inactivo;
        private System.Windows.Forms.RadioButton rdb_activo;
        private System.Windows.Forms.ComboBox combo_pais;
        private System.Windows.Forms.GroupBox grp_usuarios;
        private System.Windows.Forms.ListBox lst_inactivos;
        private System.Windows.Forms.ListBox lst_activos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label contador;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.MaskedTextBox txt_fecha;
        private System.Windows.Forms.MaskedTextBox txt_telefono;
    }
}

