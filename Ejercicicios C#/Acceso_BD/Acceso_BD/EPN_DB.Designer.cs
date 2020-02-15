namespace Acceso_BD
{
    partial class EPN_DB
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boton_Guardar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.dataGridView_Alumno = new System.Windows.Forms.DataGridView();
            this.boton_Actualizar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Alumno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESAR DATOS DEL ALUMNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "EDAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CODIGO:";
            // 
            // boton_Guardar
            // 
            this.boton_Guardar.Location = new System.Drawing.Point(272, 39);
            this.boton_Guardar.Name = "boton_Guardar";
            this.boton_Guardar.Size = new System.Drawing.Size(135, 23);
            this.boton_Guardar.TabIndex = 5;
            this.boton_Guardar.Text = "GUARDAR";
            this.boton_Guardar.UseVisualStyleBackColor = true;
            this.boton_Guardar.Click += new System.EventHandler(this.boton_Guardar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(88, 32);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(167, 20);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(88, 58);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(167, 20);
            this.txt_Apellido.TabIndex = 7;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(88, 84);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(167, 20);
            this.txt_Edad.TabIndex = 8;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(88, 110);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(167, 20);
            this.txt_Codigo.TabIndex = 9;
            // 
            // dataGridView_Alumno
            // 
            this.dataGridView_Alumno.AllowUserToAddRows = false;
            this.dataGridView_Alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Alumno.Location = new System.Drawing.Point(15, 136);
            this.dataGridView_Alumno.Name = "dataGridView_Alumno";
            this.dataGridView_Alumno.ReadOnly = true;
            this.dataGridView_Alumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Alumno.Size = new System.Drawing.Size(392, 150);
            this.dataGridView_Alumno.TabIndex = 10;
            // 
            // boton_Actualizar
            // 
            this.boton_Actualizar.Location = new System.Drawing.Point(272, 72);
            this.boton_Actualizar.Name = "boton_Actualizar";
            this.boton_Actualizar.Size = new System.Drawing.Size(135, 23);
            this.boton_Actualizar.TabIndex = 11;
            this.boton_Actualizar.Text = "ACTUALIZAR";
            this.boton_Actualizar.UseVisualStyleBackColor = true;
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(272, 101);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(135, 23);
            this.boton_Eliminar.TabIndex = 12;
            this.boton_Eliminar.Text = "ELIMINAR";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ESCRIBA UN NOMBRE:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 14;
            // 
            // EPN_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 332);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Actualizar);
            this.Controls.Add(this.dataGridView_Alumno);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.boton_Guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EPN_DB";
            this.Text = "EPN";
            this.Load += new System.EventHandler(this.EPN_DB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Alumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button boton_Guardar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.DataGridView dataGridView_Alumno;
        private System.Windows.Forms.Button boton_Actualizar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

