namespace Arbol_Genealogico
{
    partial class Registro_Genealogico
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
            this.trv_Genealogico = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.boton_Agregar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.boton_Imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trv_Genealogico
            // 
            this.trv_Genealogico.Location = new System.Drawing.Point(12, 12);
            this.trv_Genealogico.Name = "trv_Genealogico";
            this.trv_Genealogico.Size = new System.Drawing.Size(162, 178);
            this.trv_Genealogico.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(297, 5);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(200, 20);
            this.txt_Id.TabIndex = 0;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(297, 31);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(297, 57);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(200, 20);
            this.txt_Apellido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido:";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(297, 83);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // boton_Agregar
            // 
            this.boton_Agregar.Location = new System.Drawing.Point(297, 109);
            this.boton_Agregar.Name = "boton_Agregar";
            this.boton_Agregar.Size = new System.Drawing.Size(200, 23);
            this.boton_Agregar.TabIndex = 4;
            this.boton_Agregar.Text = "AGREGAR";
            this.boton_Agregar.UseVisualStyleBackColor = true;
            this.boton_Agregar.Click += new System.EventHandler(this.boton_Agregar_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(297, 138);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(200, 23);
            this.boton_Eliminar.TabIndex = 5;
            this.boton_Eliminar.Text = "ELIMINAR";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // boton_Imprimir
            // 
            this.boton_Imprimir.Location = new System.Drawing.Point(297, 167);
            this.boton_Imprimir.Name = "boton_Imprimir";
            this.boton_Imprimir.Size = new System.Drawing.Size(200, 23);
            this.boton_Imprimir.TabIndex = 6;
            this.boton_Imprimir.Text = "IMPRIMIR";
            this.boton_Imprimir.UseVisualStyleBackColor = true;
            this.boton_Imprimir.Click += new System.EventHandler(this.boton_Imprimir_Click);
            // 
            // Registro_Genealogico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 199);
            this.Controls.Add(this.boton_Imprimir);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Agregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trv_Genealogico);
            this.Name = "Registro_Genealogico";
            this.Text = "Arbol Genealogico";
            this.Load += new System.EventHandler(this.Registro_Genealogico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trv_Genealogico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boton_Agregar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Button boton_Imprimir;
    }
}

