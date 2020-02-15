namespace ProgressBar
{
    partial class Barra_de_Progreso
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.botonIniciar = new System.Windows.Forms.Button();
            this.botonPausar = new System.Windows.Forms.Button();
            this.botonReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // botonIniciar
            // 
            this.botonIniciar.Location = new System.Drawing.Point(12, 12);
            this.botonIniciar.Name = "botonIniciar";
            this.botonIniciar.Size = new System.Drawing.Size(75, 23);
            this.botonIniciar.TabIndex = 1;
            this.botonIniciar.Text = "Iniciar";
            this.botonIniciar.UseVisualStyleBackColor = true;
            this.botonIniciar.Click += new System.EventHandler(this.botonIniciar_Click);
            // 
            // botonPausar
            // 
            this.botonPausar.Location = new System.Drawing.Point(105, 12);
            this.botonPausar.Name = "botonPausar";
            this.botonPausar.Size = new System.Drawing.Size(75, 23);
            this.botonPausar.TabIndex = 2;
            this.botonPausar.Text = "Pausar";
            this.botonPausar.UseVisualStyleBackColor = true;
            this.botonPausar.Click += new System.EventHandler(this.botonPausar_Click);
            // 
            // botonReiniciar
            // 
            this.botonReiniciar.Location = new System.Drawing.Point(197, 12);
            this.botonReiniciar.Name = "botonReiniciar";
            this.botonReiniciar.Size = new System.Drawing.Size(75, 23);
            this.botonReiniciar.TabIndex = 3;
            this.botonReiniciar.Text = "Reiniciar";
            this.botonReiniciar.UseVisualStyleBackColor = true;
            this.botonReiniciar.Click += new System.EventHandler(this.botonReiniciar_Click);
            // 
            // Barra_de_Progreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 77);
            this.Controls.Add(this.botonReiniciar);
            this.Controls.Add(this.botonPausar);
            this.Controls.Add(this.botonIniciar);
            this.Controls.Add(this.progressBar1);
            this.Name = "Barra_de_Progreso";
            this.Text = "Barra de Progreso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button botonIniciar;
        private System.Windows.Forms.Button botonPausar;
        private System.Windows.Forms.Button botonReiniciar;
    }
}

