using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace User_Activo_Inactivo
{
    public partial class Form1 : Form
    {
        List<Usuario> listaActivos = new List<Usuario>();
        List<Usuario> listaInactivos = new List<Usuario>();
        List<Pais> listaPaises = new List<Pais>();
                
        
        
        public Form1()
        {
            InitializeComponent();
            Formulario_en_Modo("Boton Nuevo");
        }




        private void Form1_Load(object sender, EventArgs e)
        {
        }





        public void Formulario_en_Modo(string modo)
        {
            if (modo == "Boton Nuevo")
            {
                grpBox_IngresoDatos.Enabled = false;
                grpBox_Intereses.Enabled = false;
                grpBox_Sexo.Enabled = false;
                grpBox_Estado.Enabled = false;
                btn_Guardar.Enabled = false;
                btn_Eliminar.Enabled = false;
                btn_Cancelar.Enabled = false;
                btn_Nuevo.Enabled = true;
            }
            else if (modo == "Ingresando Datos")
            {
                grpBox_IngresoDatos.Enabled = true;
                grpBox_Intereses.Enabled = true;
                grpBox_Sexo.Enabled = true;
                grpBox_Estado.Enabled = true;
                btn_Nuevo.Enabled = false;
                btn_Cancelar.Enabled = true;
                btn_Guardar.Enabled = true;
            }
        }




        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Formulario_en_Modo("Ingresando Datos");            
        }




        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cancelar cancelar=new Cancelar();
            cancelar.Show();            
        }

        
         private void lstBox_Intereses_SelectedIndexChanged(object sender, EventArgs e)
         {
         }

         private void cmbBox_Pais_SelectedIndexChanged(object sender, EventArgs e)
         {            
         }





         private void btn_Guardar_Click(object sender, EventArgs e)
         {
             if (txt_Login.Text == "" || txt_Nombre.Text == "" || cmbBox_Pais.Text == "" || msk_Fecha.Text == "" || txt_Contrasenia.Text == "" || mskBox_Telefono.Text == "")
             {
                 MessageBox.Show("Incompleto", "Aviso");
             }
             else if (radBtn_Masculino.Checked)
             {
                 if (radBtn_Activo.Checked)
                 {
                     Usuario activo = new Usuario(lbl_IdAutomarcado.Text, txt_Login.Text, txt_Nombre.Text,cmbBox_Pais.Text,msk_Fecha.Text,txt_Contrasenia.Text,mskBox_Telefono.Text,lstBox_Intereses.Text,"M","Activo");
                     listaActivos.Add(activo);
                     lstBox_Activos.Items.Clear();
                     RefrescarActivos();
                     Formulario_en_Modo("Boton Nuevo");
                 }
                 else if(radBtn_Inactivo.Checked)
                 {
                     Usuario inactivo = new Usuario(lbl_IdAutomarcado.Text, txt_Login.Text, txt_Nombre.Text, cmbBox_Pais.Text, msk_Fecha.Text, txt_Contrasenia.Text, mskBox_Telefono.Text, lstBox_Intereses.Text, "M", "Inactivo");
                     listaInactivos.Add(inactivo);
                     lstBox_Inactivos.Items.Clear();
                     RefrescarInactivos();
                     Formulario_en_Modo("Boton Nuevo");
                 }
             }
             else if (radBtn_femenino.Checked)
             {
                 if (radBtn_Activo.Checked)
                 {
                     Usuario activo = new Usuario(lbl_IdAutomarcado.Text, txt_Login.Text, txt_Nombre.Text, cmbBox_Pais.Text, msk_Fecha.Text, txt_Contrasenia.Text, mskBox_Telefono.Text, lstBox_Intereses.Text, "F", "Activo");
                     listaActivos.Add(activo);
                     lstBox_Activos.Items.Clear();
                     RefrescarActivos();
                     Formulario_en_Modo("Boton Nuevo");
                 }
                 else if (radBtn_Inactivo.Checked)
                 {
                     Usuario inactivo = new Usuario(lbl_IdAutomarcado.Text, txt_Login.Text, txt_Nombre.Text, cmbBox_Pais.Text, msk_Fecha.Text, txt_Contrasenia.Text, mskBox_Telefono.Text, lstBox_Intereses.Text, "F", "Inactivo");
                     listaInactivos.Add(inactivo);
                     lstBox_Inactivos.Items.Clear();
                     RefrescarInactivos();
                     Formulario_en_Modo("Boton Nuevo");
                 }
             }
             else 
             {
                 MessageBox.Show("Incompleto","Aviso");
             }             
         }





         public void RefrescarActivos()
         {
             foreach (var userActivo in listaActivos)
             {
                 lstBox_Activos.Items.Add(userActivo);
             }
         }






         public void RefrescarInactivos()
         {
             foreach (var userInactivo in listaInactivos)
             {
                 lstBox_Inactivos.Items.Add(userInactivo);
             }
         }



         private void btn_Eliminar_Click(object sender, EventArgs e)
         {
             Formulario_en_Modo("Boton Nuevo");
             lstBox_Activos.Items.Remove(lstBox_Activos.SelectedItem);
             lstBox_Inactivos.Items.Remove(lstBox_Inactivos.SelectedItem);
         }



         private void lstBox_Activos_SelectedIndexChanged(object sender, EventArgs e)
         {
             Formulario_en_Modo("Boton Nuevo");
             btn_Eliminar.Enabled = true;
         }



         private void lstBox_Inactivos_SelectedIndexChanged(object sender, EventArgs e)
         {
             Formulario_en_Modo("Boton Nuevo");
             btn_Eliminar.Enabled = true;
         }
    }
}
