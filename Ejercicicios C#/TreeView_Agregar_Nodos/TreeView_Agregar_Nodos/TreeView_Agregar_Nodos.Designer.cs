namespace TreeView_Agregar_Nodos
{
    partial class TreeView
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
            this.arbolDirectorios = new System.Windows.Forms.TreeView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonLimpiarTodo = new System.Windows.Forms.Button();
            this.txtRenombrar = new System.Windows.Forms.TextBox();
            this.botonRenobrar = new System.Windows.Forms.Button();
            this.groupoAgregar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupoAgregar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // arbolDirectorios
            // 
            this.arbolDirectorios.Location = new System.Drawing.Point(18, 12);
            this.arbolDirectorios.Name = "arbolDirectorios";
            this.arbolDirectorios.Size = new System.Drawing.Size(435, 168);
            this.arbolDirectorios.TabIndex = 3;
            this.arbolDirectorios.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.arbolDirectorios_AfterSelect);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(118, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(6, 46);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(118, 24);
            this.botonAgregar.TabIndex = 1;
            this.botonAgregar.Text = "Agregar Elemento";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(6, 18);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(126, 23);
            this.botonEliminar.TabIndex = 0;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonLimpiarTodo
            // 
            this.botonLimpiarTodo.Location = new System.Drawing.Point(6, 47);
            this.botonLimpiarTodo.Name = "botonLimpiarTodo";
            this.botonLimpiarTodo.Size = new System.Drawing.Size(126, 23);
            this.botonLimpiarTodo.TabIndex = 1;
            this.botonLimpiarTodo.Text = "Limpiar Todo";
            this.botonLimpiarTodo.UseVisualStyleBackColor = true;
            this.botonLimpiarTodo.Click += new System.EventHandler(this.botonLimpiarTodo_Click);
            // 
            // txtRenombrar
            // 
            this.txtRenombrar.Location = new System.Drawing.Point(6, 20);
            this.txtRenombrar.Name = "txtRenombrar";
            this.txtRenombrar.Size = new System.Drawing.Size(141, 20);
            this.txtRenombrar.TabIndex = 0;
            // 
            // botonRenobrar
            // 
            this.botonRenobrar.Location = new System.Drawing.Point(6, 46);
            this.botonRenobrar.Name = "botonRenobrar";
            this.botonRenobrar.Size = new System.Drawing.Size(141, 23);
            this.botonRenobrar.TabIndex = 1;
            this.botonRenobrar.Text = "Renombrar";
            this.botonRenobrar.UseVisualStyleBackColor = true;
            this.botonRenobrar.Click += new System.EventHandler(this.botonRenobrar_Click);
            // 
            // groupoAgregar
            // 
            this.groupoAgregar.Controls.Add(this.botonAgregar);
            this.groupoAgregar.Controls.Add(this.txtNombre);
            this.groupoAgregar.Location = new System.Drawing.Point(12, 186);
            this.groupoAgregar.Name = "groupoAgregar";
            this.groupoAgregar.Size = new System.Drawing.Size(138, 76);
            this.groupoAgregar.TabIndex = 0;
            this.groupoAgregar.TabStop = false;
            this.groupoAgregar.Text = "Agregar Nodo/SubNodo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonRenobrar);
            this.groupBox1.Controls.Add(this.txtRenombrar);
            this.groupBox1.Location = new System.Drawing.Point(156, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renombra Nodo/SubNodo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonEliminar);
            this.groupBox2.Controls.Add(this.botonLimpiarTodo);
            this.groupBox2.Location = new System.Drawing.Point(315, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Nodo/SubNodo";
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 274);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupoAgregar);
            this.Controls.Add(this.arbolDirectorios);
            this.Name = "TreeView";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.TreeView_Load);
            this.groupoAgregar.ResumeLayout(false);
            this.groupoAgregar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView arbolDirectorios;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonLimpiarTodo;
        private System.Windows.Forms.TextBox txtRenombrar;
        private System.Windows.Forms.Button botonRenobrar;
        private System.Windows.Forms.GroupBox groupoAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

