using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsuarioAvanzado
{
    public partial class Form1 : Form
    {
        int c = 0;
        List<Usuario> listaActivos = new List<Usuario>();
        List<Usuario> listainactivos = new List<Usuario>();
        


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
            contador.Text = "0";
            grp_datos.Enabled = false;
            grp_usuarios.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar.Enabled = false;

        }
        public void Set(string opcion)
        {

            if (opcion == "nuevo")
            {

                grp_datos.Enabled = true;
                grp_usuarios.Enabled = true;
                btn_guardar.Enabled = true;
                txt_contraseña.Clear();
                txt_fecha.Clear();
                txt_login.Clear();
                txt_nombre.Clear();
                txt_telefono.Clear();
            }
            if(opcion == "guardar"){

                grp_datos.Enabled = true;
                grp_usuarios.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_nuevo.Enabled = true;

            
            }

        }
        public void Contador(string inciar)
        {

            if (inciar == "iniciar")
            {

                int c = 0;

                this.contador.Text = " " + (c + 1);

            }
        }

        public void Combo()
        {

            //string[] ciudades = new string[10] { "Guayaquil", "Quito", "Cuenca",  };

        }
       

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            c = c + 1;
            Set("nuevo");
            contador.Text = c.ToString();

        }

        private void combo_pais_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Set("guardar");
            if(rdb_activo.Checked){

                Usuario activo = new Usuario(contador.Text, txt_login.Text, txt_nombre.Text, combo_pais.Text, txt_fecha.Text, txt_telefono.Text, "activo");
                listaActivos.Add(activo);
                lst_activos.Items.Clear();
                RefrescarActivos();
            }
            else if (rdb_inactivo.Checked)
            {

                Usuario inactivo = new Usuario(contador.Text, txt_login.Text, txt_nombre.Text, combo_pais.Text, txt_fecha.Text, txt_telefono.Text, "inactivo");
                listainactivos.Add(inactivo);
                lst_inactivos.Items.Clear();
                RefrescarInactivos();
            }
        }
        public void RefrescarActivos()
        {
            foreach (Usuario userActivo in listaActivos)
            {
                lst_activos.Items.Add(userActivo);
            }
        }

        public void RefrescarInactivos()
        {
            foreach (Usuario userInactivo in listainactivos)
            {
                lst_inactivos.Items.Add(userInactivo);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            lst_activos.Items.Remove(lst_activos.SelectedItem);
            listaActivos.Remove((Usuario)lst_activos.SelectedItem);
        }

    }
}