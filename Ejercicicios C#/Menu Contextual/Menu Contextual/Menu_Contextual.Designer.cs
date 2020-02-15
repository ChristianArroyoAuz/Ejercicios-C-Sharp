namespace Menu_Contextual
{
    partial class Menu_Contextual
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
            this.listaIntereses = new System.Windows.Forms.ListBox();
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbSinEspecificar = new System.Windows.Forms.RadioButton();
            this.groupBox_Sexo = new System.Windows.Forms.GroupBox();
            this.groupBox_Intereses = new System.Windows.Forms.GroupBox();
            this.InteresTecnologia = new System.Windows.Forms.CheckBox();
            this.InteresLectura = new System.Windows.Forms.CheckBox();
            this.InteresDeportes = new System.Windows.Forms.CheckBox();
            this.InteresMusica = new System.Windows.Forms.CheckBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Sexo.SuspendLayout();
            this.groupBox_Intereses.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaIntereses
            // 
            this.listaIntereses.FormattingEnabled = true;
            this.listaIntereses.Location = new System.Drawing.Point(12, 12);
            this.listaIntereses.Name = "listaIntereses";
            this.listaIntereses.Size = new System.Drawing.Size(276, 173);
            this.listaIntereses.TabIndex = 0;
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Location = new System.Drawing.Point(11, 198);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(47, 13);
            this.etiquetaNombre.TabIndex = 1;
            this.etiquetaNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 191);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 42);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 3;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(6, 19);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 4;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbSinEspecificar
            // 
            this.rbSinEspecificar.AutoSize = true;
            this.rbSinEspecificar.Location = new System.Drawing.Point(6, 65);
            this.rbSinEspecificar.Name = "rbSinEspecificar";
            this.rbSinEspecificar.Size = new System.Drawing.Size(95, 17);
            this.rbSinEspecificar.TabIndex = 5;
            this.rbSinEspecificar.TabStop = true;
            this.rbSinEspecificar.Text = "Sin Especificar";
            this.rbSinEspecificar.UseVisualStyleBackColor = true;
            // 
            // groupBox_Sexo
            // 
            this.groupBox_Sexo.Controls.Add(this.rbMasculino);
            this.groupBox_Sexo.Controls.Add(this.rbSinEspecificar);
            this.groupBox_Sexo.Controls.Add(this.rbFemenino);
            this.groupBox_Sexo.Location = new System.Drawing.Point(178, 223);
            this.groupBox_Sexo.Name = "groupBox_Sexo";
            this.groupBox_Sexo.Size = new System.Drawing.Size(110, 88);
            this.groupBox_Sexo.TabIndex = 6;
            this.groupBox_Sexo.TabStop = false;
            this.groupBox_Sexo.Text = "Sexo.";
            // 
            // groupBox_Intereses
            // 
            this.groupBox_Intereses.Controls.Add(this.InteresTecnologia);
            this.groupBox_Intereses.Controls.Add(this.InteresLectura);
            this.groupBox_Intereses.Controls.Add(this.InteresDeportes);
            this.groupBox_Intereses.Controls.Add(this.InteresMusica);
            this.groupBox_Intereses.Location = new System.Drawing.Point(14, 223);
            this.groupBox_Intereses.Name = "groupBox_Intereses";
            this.groupBox_Intereses.Size = new System.Drawing.Size(146, 114);
            this.groupBox_Intereses.TabIndex = 9;
            this.groupBox_Intereses.TabStop = false;
            this.groupBox_Intereses.Text = "Lista de Intereses";
            // 
            // InteresTecnologia
            // 
            this.InteresTecnologia.AutoSize = true;
            this.InteresTecnologia.Location = new System.Drawing.Point(35, 19);
            this.InteresTecnologia.Name = "InteresTecnologia";
            this.InteresTecnologia.Size = new System.Drawing.Size(79, 17);
            this.InteresTecnologia.TabIndex = 2;
            this.InteresTecnologia.Text = "Tegnologia";
            this.InteresTecnologia.UseVisualStyleBackColor = true;
            // 
            // InteresLectura
            // 
            this.InteresLectura.AutoSize = true;
            this.InteresLectura.Location = new System.Drawing.Point(35, 88);
            this.InteresLectura.Name = "InteresLectura";
            this.InteresLectura.Size = new System.Drawing.Size(62, 17);
            this.InteresLectura.TabIndex = 5;
            this.InteresLectura.Text = "Lectura";
            this.InteresLectura.UseVisualStyleBackColor = true;
            // 
            // InteresDeportes
            // 
            this.InteresDeportes.AutoSize = true;
            this.InteresDeportes.Location = new System.Drawing.Point(35, 42);
            this.InteresDeportes.Name = "InteresDeportes";
            this.InteresDeportes.Size = new System.Drawing.Size(69, 17);
            this.InteresDeportes.TabIndex = 3;
            this.InteresDeportes.Text = "Deportes";
            this.InteresDeportes.UseVisualStyleBackColor = true;
            // 
            // InteresMusica
            // 
            this.InteresMusica.AutoSize = true;
            this.InteresMusica.Location = new System.Drawing.Point(35, 65);
            this.InteresMusica.Name = "InteresMusica";
            this.InteresMusica.Size = new System.Drawing.Size(60, 17);
            this.InteresMusica.TabIndex = 4;
            this.InteresMusica.Text = "Musica";
            this.InteresMusica.UseVisualStyleBackColor = true;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(178, 317);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(110, 23);
            this.botonAgregar.TabIndex = 10;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.limpiarToolStripMenuItem});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.Size = new System.Drawing.Size(115, 48);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // Menu_Contextual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 353);
            this.ContextMenuStrip = this.Menu;
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.groupBox_Intereses);
            this.Controls.Add(this.groupBox_Sexo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.etiquetaNombre);
            this.Controls.Add(this.listaIntereses);
            this.Name = "Menu_Contextual";
            this.Text = "Agregar Intereses";
            this.groupBox_Sexo.ResumeLayout(false);
            this.groupBox_Sexo.PerformLayout();
            this.groupBox_Intereses.ResumeLayout(false);
            this.groupBox_Intereses.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaIntereses;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbSinEspecificar;
        private System.Windows.Forms.GroupBox groupBox_Sexo;
        private System.Windows.Forms.GroupBox groupBox_Intereses;
        private System.Windows.Forms.CheckBox InteresTecnologia;
        private System.Windows.Forms.CheckBox InteresLectura;
        private System.Windows.Forms.CheckBox InteresDeportes;
        private System.Windows.Forms.CheckBox InteresMusica;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;

    }
}

