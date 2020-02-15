using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_View
{
    public partial class Form1 : Form
    {
        List<Estudiante> ingresarNuevo = new List<Estudiante>();
        List<Estudiante> pasarLista = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();
        }

        private void botonCargar_Click(object sender, EventArgs e)
        {
            ListViewItem nuevo = new ListViewItem("1");
            nuevo.SubItems.Add("Christian");
            nuevo.SubItems.Add("Arroyo");
            nuevo.SubItems.Add("Redes");
            ListViewItem nuevo2 = new ListViewItem("2");
            nuevo2.SubItems.Add("Xavier");
            nuevo2.SubItems.Add("Auz");
            nuevo2.SubItems.Add("Redes");
            listView_Estudiantes.Items.Add(nuevo);
            listView_Estudiantes.Items.Add(nuevo2);
        }

        private void botonImprimir_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listView_Estudiantes.SelectedItems[0].SubItems[0].Text);
        }

        private void boton_Ingresar_Click(object sender, EventArgs e)
        {
            Estudiante nuevo = new Estudiante(Convert.ToInt32(txt_Id.Text), txt_Nombre.Text, txt_Apellido.Text, comboBox_Carrera.SelectedItem.ToString());
            ingresarNuevo.Add(nuevo);
            Ingresar();
        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_Estudiantes.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem itemVisual in listView_Estudiantes.SelectedItems)
                    {
                        string nombre = itemVisual.SubItems[1].Text;
                        foreach (Estudiante itemLista in ingresarNuevo)
                        {
                            if (itemLista.Nombre_Estudiante == nombre)
                            {
                                ingresarNuevo.Remove(itemLista);
                                ListViewItem borrarVisual = (ListViewItem)listView_Estudiantes.SelectedItems[0];
                                listView_Estudiantes.Items.Remove(borrarVisual);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Existen Elementos a eliminar.");
                }
            }
            catch (Exception)
            {
            }
        }

        public void Ingresar()
        {
            listView_Estudiantes.Items.Clear();
            foreach(Estudiante item in ingresarNuevo)
            {
                ListViewItem nuevo = new ListViewItem(item.Id_Estudiante.ToString());
                nuevo.SubItems.Add(item.Nombre_Estudiante.ToString());
                nuevo.SubItems.Add(item.Apellido_Estudiante.ToString());
                nuevo.SubItems.Add(item.Carrera_Estudiante.ToString());
                listView_Estudiantes.Items.Add(nuevo);
            }
            txt_Id.Clear();
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            comboBox_Carrera.ResetText();
            txt_Id.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Enabled = false;
            comboBox_Carrera.Items.Add("Redes");
            comboBox_Carrera.Items.Add("Control");
            comboBox_Carrera.Items.Add("Tecomunicaciones");
            comboBox_Carrera.Items.Add("Electrica");
        }

        private void listView_Estudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Estudiantes.SelectedItems)
            {
                listView1.Items.Add((ListViewItem)item.Clone());
                Estudiante nuevo = new Estudiante(Convert.ToInt32(listView_Estudiantes.SelectedItems[0].SubItems[0].Text),
                                              listView_Estudiantes.SelectedItems[0].SubItems[1].Text,
                                              listView_Estudiantes.SelectedItems[0].SubItems[2].Text,
                                              listView_Estudiantes.SelectedItems[0].SubItems[3].Text);
                pasarLista.Add(nuevo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Estudiante nuevo = new Estudiante(Convert.ToInt32(listView_Estudiantes.SelectedItems[0].SubItems[0].Text),
            //                                  listView_Estudiantes.SelectedItems[0].SubItems[1].Text,
            //                                  listView_Estudiantes.SelectedItems[0].SubItems[2].Text,
            //                                  listView_Estudiantes.SelectedItems[0].SubItems[3].Text);
            //pasarLista.Add(nuevo);
            //listView1.Items.Clear();
            //foreach(Estudiante item in pasarLista)
            //{
            //    ListViewItem pasar = new ListViewItem(item.Id_Estudiante.ToString());
            //    pasar.SubItems.Add(item.Nombre_Estudiante.ToString());
            //    pasar.SubItems.Add(item.Apellido_Estudiante.ToString());
            //    pasar.SubItems.Add(item.Carrera_Estudiante.ToString());
            //    listView1.Items.Add(pasar);
            //}
        }
    }
}
