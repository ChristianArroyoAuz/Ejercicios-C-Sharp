namespace Cuadros_de_Dialogo
{
    partial class Cuadros_de_Dialogo
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
            this.botonBienvenido = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.botonColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botonPersonal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonBienvenido
            // 
            this.botonBienvenido.Location = new System.Drawing.Point(12, 38);
            this.botonBienvenido.Name = "botonBienvenido";
            this.botonBienvenido.Size = new System.Drawing.Size(100, 23);
            this.botonBienvenido.TabIndex = 0;
            this.botonBienvenido.Text = "Bienvenido";
            this.botonBienvenido.UseVisualStyleBackColor = true;
            this.botonBienvenido.Click += new System.EventHandler(this.botonBienvenido_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // botonColor
            // 
            this.botonColor.Location = new System.Drawing.Point(129, 38);
            this.botonColor.Name = "botonColor";
            this.botonColor.Size = new System.Drawing.Size(75, 23);
            this.botonColor.TabIndex = 2;
            this.botonColor.Text = "Color";
            this.botonColor.UseVisualStyleBackColor = true;
            this.botonColor.Click += new System.EventHandler(this.botonColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOLA";
            // 
            // botonPersonal
            // 
            this.botonPersonal.Location = new System.Drawing.Point(222, 38);
            this.botonPersonal.Name = "botonPersonal";
            this.botonPersonal.Size = new System.Drawing.Size(75, 23);
            this.botonPersonal.TabIndex = 4;
            this.botonPersonal.Text = "Personal";
            this.botonPersonal.UseVisualStyleBackColor = true;
            this.botonPersonal.Click += new System.EventHandler(this.botonPersonal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Cuadros_de_Dialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 76);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonPersonal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonColor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonBienvenido);
            this.Name = "Cuadros_de_Dialogo";
            this.Text = "Cuadros de Dialogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBienvenido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button botonColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonPersonal;
        private System.Windows.Forms.Label label2;
    }
}

