namespace List_View
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView_Estudiantes = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Carrera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.botonCargar = new System.Windows.Forms.Button();
            this.botonImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.comboBox_Carrera = new System.Windows.Forms.ComboBox();
            this.boton_Ingresar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Estudiante";
            // 
            // listView_Estudiantes
            // 
            this.listView_Estudiantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Carrera});
            this.listView_Estudiantes.FullRowSelect = true;
            this.listView_Estudiantes.GridLines = true;
            this.listView_Estudiantes.Location = new System.Drawing.Point(11, 152);
            this.listView_Estudiantes.Name = "listView_Estudiantes";
            this.listView_Estudiantes.Size = new System.Drawing.Size(327, 97);
            this.listView_Estudiantes.TabIndex = 1;
            this.listView_Estudiantes.UseCompatibleStateImageBehavior = false;
            this.listView_Estudiantes.View = System.Windows.Forms.View.Details;
            this.listView_Estudiantes.SelectedIndexChanged += new System.EventHandler(this.listView_Estudiantes_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            // 
            // Carrera
            // 
            this.Carrera.Text = "Carrera";
            // 
            // botonCargar
            // 
            this.botonCargar.Location = new System.Drawing.Point(11, 255);
            this.botonCargar.Name = "botonCargar";
            this.botonCargar.Size = new System.Drawing.Size(75, 23);
            this.botonCargar.TabIndex = 2;
            this.botonCargar.Text = "Cargar";
            this.botonCargar.UseVisualStyleBackColor = true;
            this.botonCargar.Click += new System.EventHandler(this.botonCargar_Click);
            // 
            // botonImprimir
            // 
            this.botonImprimir.Location = new System.Drawing.Point(263, 255);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(75, 23);
            this.botonImprimir.TabIndex = 3;
            this.botonImprimir.Text = "Imprimir";
            this.botonImprimir.UseVisualStyleBackColor = true;
            this.botonImprimir.Click += new System.EventHandler(this.botonImprimir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Poner en true: full row select y gridlines. y en View poner en details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(84, 26);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(254, 20);
            this.txt_Id.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Carrera:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(84, 59);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(254, 20);
            this.txt_Nombre.TabIndex = 10;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(84, 91);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(254, 20);
            this.txt_Apellido.TabIndex = 11;
            // 
            // comboBox_Carrera
            // 
            this.comboBox_Carrera.FormattingEnabled = true;
            this.comboBox_Carrera.Location = new System.Drawing.Point(84, 117);
            this.comboBox_Carrera.Name = "comboBox_Carrera";
            this.comboBox_Carrera.Size = new System.Drawing.Size(254, 21);
            this.comboBox_Carrera.TabIndex = 12;
            // 
            // boton_Ingresar
            // 
            this.boton_Ingresar.Location = new System.Drawing.Point(92, 255);
            this.boton_Ingresar.Name = "boton_Ingresar";
            this.boton_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.boton_Ingresar.TabIndex = 13;
            this.boton_Ingresar.Text = "Ingresar";
            this.boton_Ingresar.UseVisualStyleBackColor = true;
            this.boton_Ingresar.Click += new System.EventHandler(this.boton_Ingresar_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(182, 255);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.boton_Eliminar.TabIndex = 14;
            this.boton_Eliminar.Text = "Eliminar";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(348, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(274, 97);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Carrerra";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "PASAR DATOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Ingresar);
            this.Controls.Add(this.comboBox_Carrera);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonImprimir);
            this.Controls.Add(this.botonCargar);
            this.Controls.Add(this.listView_Estudiantes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Estudiante";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_Estudiantes;
        private System.Windows.Forms.Button botonCargar;
        private System.Windows.Forms.Button botonImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Carrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.ComboBox comboBox_Carrera;
        private System.Windows.Forms.Button boton_Ingresar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
    }
}

