namespace Paso_Datos_MDI
{
    partial class FormHijo_MiCuenta
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
            this.txtBox_Login_MiCuenta = new System.Windows.Forms.TextBox();
            this.txtBox_Password_MiCuenta = new System.Windows.Forms.TextBox();
            this.txtBox_Nombre_MiCuenta = new System.Windows.Forms.TextBox();
            this.btn_Guardar_MiCuenta = new System.Windows.Forms.Button();
            this.lbl_contadorID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // txtBox_Login_MiCuenta
            // 
            this.txtBox_Login_MiCuenta.Location = new System.Drawing.Point(90, 45);
            this.txtBox_Login_MiCuenta.Name = "txtBox_Login_MiCuenta";
            this.txtBox_Login_MiCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Login_MiCuenta.TabIndex = 4;
            // 
            // txtBox_Password_MiCuenta
            // 
            this.txtBox_Password_MiCuenta.Location = new System.Drawing.Point(90, 79);
            this.txtBox_Password_MiCuenta.Name = "txtBox_Password_MiCuenta";
            this.txtBox_Password_MiCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Password_MiCuenta.TabIndex = 5;
            // 
            // txtBox_Nombre_MiCuenta
            // 
            this.txtBox_Nombre_MiCuenta.Location = new System.Drawing.Point(90, 111);
            this.txtBox_Nombre_MiCuenta.Name = "txtBox_Nombre_MiCuenta";
            this.txtBox_Nombre_MiCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Nombre_MiCuenta.TabIndex = 6;
            // 
            // btn_Guardar_MiCuenta
            // 
            this.btn_Guardar_MiCuenta.Location = new System.Drawing.Point(66, 151);
            this.btn_Guardar_MiCuenta.Name = "btn_Guardar_MiCuenta";
            this.btn_Guardar_MiCuenta.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar_MiCuenta.TabIndex = 7;
            this.btn_Guardar_MiCuenta.Text = "Guardar";
            this.btn_Guardar_MiCuenta.UseVisualStyleBackColor = true;
            this.btn_Guardar_MiCuenta.Click += new System.EventHandler(this.btn_Guardar_MiCuenta_Click);
            // 
            // lbl_contadorID
            // 
            this.lbl_contadorID.AutoSize = true;
            this.lbl_contadorID.Location = new System.Drawing.Point(90, 24);
            this.lbl_contadorID.Name = "lbl_contadorID";
            this.lbl_contadorID.Size = new System.Drawing.Size(35, 13);
            this.lbl_contadorID.TabIndex = 8;
            this.lbl_contadorID.Text = "label5";
            // 
            // FormHijo_MiCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 187);
            this.Controls.Add(this.lbl_contadorID);
            this.Controls.Add(this.btn_Guardar_MiCuenta);
            this.Controls.Add(this.txtBox_Nombre_MiCuenta);
            this.Controls.Add(this.txtBox_Password_MiCuenta);
            this.Controls.Add(this.txtBox_Login_MiCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHijo_MiCuenta";
            this.Text = "FormHijo_MiCuenta";
            this.Load += new System.EventHandler(this.FormHijo_MiCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Login_MiCuenta;
        private System.Windows.Forms.TextBox txtBox_Password_MiCuenta;
        private System.Windows.Forms.TextBox txtBox_Nombre_MiCuenta;
        private System.Windows.Forms.Button btn_Guardar_MiCuenta;
        private System.Windows.Forms.Label lbl_contadorID;
    }
}