using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Tab_Control : Form
    {
        List<TabPage> listaPestañas = new List<TabPage>();
        int contadorPestañas = 0;

        public Tab_Control()
        {
            InitializeComponent();
        }

        public void Crear_Pestaña()
        {
            contadorPestañas = contadorPestañas + 1;
            TabPage nuevo = new TabPage("Pestaña" + " " + contadorPestañas);
            listaPestañas.Add(nuevo);
            tabControl1.TabPages.Add(nuevo);
        }

        public void Eliminar_Pestañas()
        {
            //if (tabControl1.TabCount > 0)
            //{
            //    TabPage seleccionado = tabControl1.SelectedTab;
            //    listaPestañas.Remove(seleccionado);
            //    tabControl1.TabPages.Remove(seleccionado);
            //}
            //else
            //{
            //    MessageBox.Show("No Hay Pestañas a Borrar...");
            //}

            try
            {
                TabPage seleccionado = tabControl1.SelectedTab;
                listaPestañas.Remove(seleccionado);
                tabControl1.TabPages.Remove(seleccionado);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Hay Pestañas a Borrar...");
            }
            
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Crear_Pestaña();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Pestañas();
        }
    }
}
