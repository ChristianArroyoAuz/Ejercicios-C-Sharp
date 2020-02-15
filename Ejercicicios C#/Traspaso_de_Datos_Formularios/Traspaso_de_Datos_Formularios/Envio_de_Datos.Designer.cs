namespace Traspaso_de_Datos_Formularios
{
    partial class Envio_de_Datos
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
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.boton_Guardar = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.statusStrip_EnvioDatos = new System.Windows.Forms.StatusStrip();
            this.etiqueta_Estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_EnvioDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "INGRESO DE LOS DATOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PASSWORD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "EDAD:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(126, 41);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 0;
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(126, 80);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(100, 20);
            this.txt_Login.TabIndex = 1;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(126, 162);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 20);
            this.txt_Edad.TabIndex = 3;
            // 
            // boton_Guardar
            // 
            this.boton_Guardar.Location = new System.Drawing.Point(76, 198);
            this.boton_Guardar.Name = "boton_Guardar";
            this.boton_Guardar.Size = new System.Drawing.Size(122, 33);
            this.boton_Guardar.TabIndex = 4;
            this.boton_Guardar.Text = "GUARDAR";
            this.boton_Guardar.UseVisualStyleBackColor = true;
            this.boton_Guardar.Click += new System.EventHandler(this.boton_Guardar_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(126, 121);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 2;
            // 
            // statusStrip_EnvioDatos
            // 
            this.statusStrip_EnvioDatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiqueta_Estado});
            this.statusStrip_EnvioDatos.Location = new System.Drawing.Point(0, 241);
            this.statusStrip_EnvioDatos.Name = "statusStrip_EnvioDatos";
            this.statusStrip_EnvioDatos.Size = new System.Drawing.Size(279, 22);
            this.statusStrip_EnvioDatos.TabIndex = 10;
            this.statusStrip_EnvioDatos.Text = "statusStrip1";
            // 
            // etiqueta_Estado
            // 
            this.etiqueta_Estado.Name = "etiqueta_Estado";
            this.etiqueta_Estado.Size = new System.Drawing.Size(32, 17);
            this.etiqueta_Estado.Text = "Listo";
            // 
            // Envio_de_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 263);
            this.Controls.Add(this.statusStrip_EnvioDatos);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.boton_Guardar);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Envio_de_Datos";
            this.Text = "Envio_de_Datos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Envio_de_Datos_FormClosed);
            this.Load += new System.EventHandler(this.Envio_de_Datos_Load);
            this.statusStrip_EnvioDatos.ResumeLayout(false);
            this.statusStrip_EnvioDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Button boton_Guardar;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.StatusStrip statusStrip_EnvioDatos;
        private System.Windows.Forms.ToolStripStatusLabel etiqueta_Estado;
    }
}