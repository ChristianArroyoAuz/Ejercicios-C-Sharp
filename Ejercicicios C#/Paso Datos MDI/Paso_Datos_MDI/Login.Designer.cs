namespace Paso_Datos_MDI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OKForm1 = new System.Windows.Forms.Button();
            this.txtBox_LoginForm1 = new System.Windows.Forms.TextBox();
            this.txtBox_PassForm1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btn_OKForm1
            // 
            this.btn_OKForm1.Location = new System.Drawing.Point(90, 94);
            this.btn_OKForm1.Name = "btn_OKForm1";
            this.btn_OKForm1.Size = new System.Drawing.Size(75, 23);
            this.btn_OKForm1.TabIndex = 2;
            this.btn_OKForm1.Text = "OK";
            this.btn_OKForm1.UseVisualStyleBackColor = true;
            this.btn_OKForm1.Click += new System.EventHandler(this.btn_OKForm1_Click);
            // 
            // txtBox_LoginForm1
            // 
            this.txtBox_LoginForm1.Location = new System.Drawing.Point(79, 27);
            this.txtBox_LoginForm1.Name = "txtBox_LoginForm1";
            this.txtBox_LoginForm1.Size = new System.Drawing.Size(100, 20);
            this.txtBox_LoginForm1.TabIndex = 0;
            // 
            // txtBox_PassForm1
            // 
            this.txtBox_PassForm1.Location = new System.Drawing.Point(79, 53);
            this.txtBox_PassForm1.Name = "txtBox_PassForm1";
            this.txtBox_PassForm1.Size = new System.Drawing.Size(100, 20);
            this.txtBox_PassForm1.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 129);
            this.Controls.Add(this.txtBox_PassForm1);
            this.Controls.Add(this.txtBox_LoginForm1);
            this.Controls.Add(this.btn_OKForm1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OKForm1;
        private System.Windows.Forms.TextBox txtBox_LoginForm1;
        private System.Windows.Forms.TextBox txtBox_PassForm1;
    }
}

