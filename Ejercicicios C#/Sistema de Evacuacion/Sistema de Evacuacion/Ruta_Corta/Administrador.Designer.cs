namespace Sistema_de_Evacuacion.Ruta_Corta
{
    partial class Administrador
    {
        #region Windows Form Designer generated code.
        //
        // InitializeComponent
        //
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.botonUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.botonRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.botonModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.botonMapas = new System.Windows.Forms.ToolStripMenuItem();
            this.botonNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.botonAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.botonGrabar = new System.Windows.Forms.ToolStripMenuItem();
            this.botonAdmistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.botonModificar_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.botonCerrar_Cuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.botonCambiar_Mapa = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonVolver_Login = new System.Windows.Forms.Button();
            this.botonAyuda = new System.Windows.Forms.Button();
            this.botonSimular = new System.Windows.Forms.Button();
            this.f_BoardBox_2 = new Sistema_de_Evacuacion.Ruta_Corta.UIBoardBox_2();
            this.f_BoardBox = new Sistema_de_Evacuacion.Ruta_Corta.UIBoardBox();
            this.botonModificar_Mapa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botonUsuarios,
            this.botonMapas,
            this.botonAdmistrar});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(684, 24);
            this.MenuBar.TabIndex = 0;
            // 
            // botonUsuarios
            // 
            this.botonUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botonRegistrar,
            this.botonModificar});
            this.botonUsuarios.Name = "botonUsuarios";
            this.botonUsuarios.Size = new System.Drawing.Size(64, 20);
            this.botonUsuarios.Text = "&Usuarios";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(217, 22);
            this.botonRegistrar.Text = "&Registar Nuevo Usuario";
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(217, 22);
            this.botonModificar.Text = "&Modificar Usuario Exixtente";
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonMapas
            // 
            this.botonMapas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botonNuevo,
            this.botonAbrir,
            this.botonGrabar,
            this.botonModificar_Mapa});
            this.botonMapas.Name = "botonMapas";
            this.botonMapas.Size = new System.Drawing.Size(57, 20);
            this.botonMapas.Text = " &Mapas";
            // 
            // botonNuevo
            // 
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.botonNuevo.Size = new System.Drawing.Size(170, 22);
            this.botonNuevo.Text = "&Nuevo";
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonAbrir
            // 
            this.botonAbrir.Name = "botonAbrir";
            this.botonAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.botonAbrir.Size = new System.Drawing.Size(170, 22);
            this.botonAbrir.Text = "&Abrir";
            this.botonAbrir.Click += new System.EventHandler(this.botonAbrir_Click);
            // 
            // botonGrabar
            // 
            this.botonGrabar.Name = "botonGrabar";
            this.botonGrabar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.botonGrabar.Size = new System.Drawing.Size(170, 22);
            this.botonGrabar.Text = "&Grabar";
            this.botonGrabar.Click += new System.EventHandler(this.botonGrabar_Click);
            // 
            // botonAdmistrar
            // 
            this.botonAdmistrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botonModificar_Usuario,
            this.botonCerrar_Cuenta});
            this.botonAdmistrar.Name = "botonAdmistrar";
            this.botonAdmistrar.Size = new System.Drawing.Size(78, 20);
            this.botonAdmistrar.Text = "&Adminstrar";
            // 
            // botonModificar_Usuario
            // 
            this.botonModificar_Usuario.Name = "botonModificar_Usuario";
            this.botonModificar_Usuario.Size = new System.Drawing.Size(180, 22);
            this.botonModificar_Usuario.Text = "&Modificar mis Datos";
            this.botonModificar_Usuario.Click += new System.EventHandler(this.botonModificar_Usuario_Click);
            // 
            // botonCerrar_Cuenta
            // 
            this.botonCerrar_Cuenta.Name = "botonCerrar_Cuenta";
            this.botonCerrar_Cuenta.Size = new System.Drawing.Size(180, 22);
            this.botonCerrar_Cuenta.Text = "&Cerra Cuenta";
            this.botonCerrar_Cuenta.Click += new System.EventHandler(this.botonCerrar_Cuenta_Click);
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaNombre.Location = new System.Drawing.Point(24, 44);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(152, 34);
            this.etiquetaNombre.TabIndex = 1;
            this.etiquetaNombre.Text = "NOMBRE";
            // 
            // botonCambiar_Mapa
            // 
            this.botonCambiar_Mapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonCambiar_Mapa.BackgroundImage = global::Sistema_de_Evacuacion.Properties.Resources.cambiar;
            this.botonCambiar_Mapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCambiar_Mapa.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.botonCambiar_Mapa.FlatAppearance.BorderSize = 0;
            this.botonCambiar_Mapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.botonCambiar_Mapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.botonCambiar_Mapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCambiar_Mapa.Location = new System.Drawing.Point(166, 201);
            this.botonCambiar_Mapa.Name = "botonCambiar_Mapa";
            this.botonCambiar_Mapa.Size = new System.Drawing.Size(97, 97);
            this.botonCambiar_Mapa.TabIndex = 7;
            this.botonCambiar_Mapa.UseVisualStyleBackColor = true;
            this.botonCambiar_Mapa.Click += new System.EventHandler(this.botonCambiar_Mapa_Click);
            this.botonCambiar_Mapa.MouseHover += new System.EventHandler(this.botonCambiar_Mapa_MouseHover);
            // 
            // botonSalir
            // 
            this.botonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonSalir.BackgroundImage = global::Sistema_de_Evacuacion.Properties.Resources.Salir;
            this.botonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSalir.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.botonSalir.FlatAppearance.BorderSize = 0;
            this.botonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.botonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.Location = new System.Drawing.Point(561, 44);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(97, 97);
            this.botonSalir.TabIndex = 5;
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            this.botonSalir.MouseHover += new System.EventHandler(this.botonSalir_MouseHover);
            // 
            // botonVolver_Login
            // 
            this.botonVolver_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonVolver_Login.BackgroundImage = global::Sistema_de_Evacuacion.Properties.Resources.Login;
            this.botonVolver_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonVolver_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver_Login.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.botonVolver_Login.FlatAppearance.BorderSize = 0;
            this.botonVolver_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.botonVolver_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.botonVolver_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver_Login.Location = new System.Drawing.Point(445, 44);
            this.botonVolver_Login.Name = "botonVolver_Login";
            this.botonVolver_Login.Size = new System.Drawing.Size(97, 97);
            this.botonVolver_Login.TabIndex = 4;
            this.botonVolver_Login.UseVisualStyleBackColor = true;
            this.botonVolver_Login.Click += new System.EventHandler(this.botonVolver_Login_Click);
            this.botonVolver_Login.MouseHover += new System.EventHandler(this.botonVolver_Login_MouseHover);
            // 
            // botonAyuda
            // 
            this.botonAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAyuda.BackgroundImage = global::Sistema_de_Evacuacion.Properties.Resources.Ayudar;
            this.botonAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAyuda.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.botonAyuda.FlatAppearance.BorderSize = 0;
            this.botonAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.botonAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.botonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAyuda.Location = new System.Drawing.Point(327, 44);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Size = new System.Drawing.Size(97, 97);
            this.botonAyuda.TabIndex = 3;
            this.botonAyuda.UseVisualStyleBackColor = true;
            this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);
            this.botonAyuda.MouseHover += new System.EventHandler(this.botonAyuda_MouseHover);
            // 
            // botonSimular
            // 
            this.botonSimular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonSimular.BackgroundImage = global::Sistema_de_Evacuacion.Properties.Resources.Ruta;
            this.botonSimular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSimular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSimular.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonSimular.FlatAppearance.BorderSize = 2;
            this.botonSimular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.botonSimular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.botonSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSimular.Location = new System.Drawing.Point(166, 325);
            this.botonSimular.Name = "botonSimular";
            this.botonSimular.Size = new System.Drawing.Size(97, 97);
            this.botonSimular.TabIndex = 0;
            this.botonSimular.UseVisualStyleBackColor = true;
            this.botonSimular.Click += new System.EventHandler(this.botonSimular_Click);
            this.botonSimular.MouseHover += new System.EventHandler(this.botonSimular_MouseHover);
            // 
            // f_BoardBox_2
            // 
            this.f_BoardBox_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f_BoardBox_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f_BoardBox_2.Location = new System.Drawing.Point(316, 201);
            this.f_BoardBox_2.MatrixSize_2 = new System.Drawing.Size(57, 30);
            this.f_BoardBox_2.Name = "f_BoardBox_2";
            this.f_BoardBox_2.Size = new System.Drawing.Size(230, 225);
            this.f_BoardBox_2.StyleImage = global::Sistema_de_Evacuacion.Properties.Resources.Style2;
            this.f_BoardBox_2.TabIndex = 9;
            // 
            // f_BoardBox
            // 
            this.f_BoardBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f_BoardBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f_BoardBox.Location = new System.Drawing.Point(316, 201);
            this.f_BoardBox.MatrixSize = new System.Drawing.Size(57, 30);
            this.f_BoardBox.Name = "f_BoardBox";
            this.f_BoardBox.Size = new System.Drawing.Size(230, 225);
            this.f_BoardBox.StyleImage = global::Sistema_de_Evacuacion.Properties.Resources.Style2;
            this.f_BoardBox.TabIndex = 0;
            // 
            // botonModificar_Mapa
            // 
            this.botonModificar_Mapa.Name = "botonModificar_Mapa";
            this.botonModificar_Mapa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.botonModificar_Mapa.Size = new System.Drawing.Size(170, 22);
            this.botonModificar_Mapa.Text = "&Modificar";
            this.botonModificar_Mapa.Click += new System.EventHandler(this.botonModificar_Mapa_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(684, 451);
            this.Controls.Add(this.f_BoardBox_2);
            this.Controls.Add(this.botonCambiar_Mapa);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonVolver_Login);
            this.Controls.Add(this.botonAyuda);
            this.Controls.Add(this.etiquetaNombre);
            this.Controls.Add(this.botonSimular);
            this.Controls.Add(this.f_BoardBox);
            this.Controls.Add(this.MenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuBar;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrador_FormClosing);
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem botonMapas;
        private System.Windows.Forms.ToolStripMenuItem botonNuevo;
        private System.Windows.Forms.ToolStripMenuItem botonAbrir;
        private System.Windows.Forms.ToolStripMenuItem botonGrabar;
        private System.Windows.Forms.ToolStripMenuItem botonUsuarios;
        private System.Windows.Forms.ToolStripMenuItem botonRegistrar;
        private System.Windows.Forms.ToolStripMenuItem botonModificar;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.Button botonSimular;
        private UIBoardBox f_BoardBox;
        private System.Windows.Forms.ToolStripMenuItem botonAdmistrar;
        private System.Windows.Forms.ToolStripMenuItem botonModificar_Usuario;
        private System.Windows.Forms.ToolStripMenuItem botonCerrar_Cuenta;
        private System.Windows.Forms.Button botonAyuda;
        private System.Windows.Forms.Button botonVolver_Login;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonCambiar_Mapa;
        private UIBoardBox_2 f_BoardBox_2;
        private System.Windows.Forms.ToolStripMenuItem botonModificar_Mapa;
    }
}