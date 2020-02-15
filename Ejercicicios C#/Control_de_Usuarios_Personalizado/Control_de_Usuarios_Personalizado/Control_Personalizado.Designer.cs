namespace Control_de_Usuarios_Personalizado
{
    partial class Control_Personalizado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Personalizado));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listar1 = new Control_de_Usuarios_Personalizado.Listar();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 134);
            this.listBox1.TabIndex = 1;
            // 
            // listar1
            // 
            this.listar1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("listar1.Items")));
            this.listar1.Location = new System.Drawing.Point(12, 12);
            this.listar1.Name = "listar1";
            this.listar1.Size = new System.Drawing.Size(377, 61);
            this.listar1.TabIndex = 0;
            // 
            // Control_Personalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 216);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listar1);
            this.Name = "Control_Personalizado";
            this.Text = "Control de Usuario";
            this.Load += new System.EventHandler(this.Control_Personalizado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Listar listar1;
        private System.Windows.Forms.ListBox listBox1;


    }
}

