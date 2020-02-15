using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;


namespace ListView
{
    public partial class Form1 : Form
    {
        List<Archivo> cargarArchivos = new List<Archivo>();
        List<Archivo> listaArchivos = new List<Archivo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            argregar();
            mostrar();
            mostraArchivos();
        }

        public void argregar()
        {
            Archivo archivos1 = new Archivo(1, "\\", listaArchivos, 'a');
            Archivo archivos2 = new Archivo(2, "\\etc", listaArchivos, 'b');
            cargarArchivos.Add(archivos1);
            cargarArchivos.Add(archivos2);
            Archivo ar1 = new Archivo(3, "exe", null, 'a');
            Archivo ar2 = new Archivo(4, "word", null, 'a');
            Archivo ar3 = new Archivo(5, "bin", null, 'b');
            listaArchivos.Add(ar1);
            listaArchivos.Add(ar2);
            listaArchivos.Add(ar3);
        }

        public void mostrar()
        {
            listView1.View = View.Details;
            ColumnHeader col0 = new ColumnHeader(0);
            col0.Text = "ID";
            listView1.Columns.Add(col0);
            ColumnHeader col1 = new ColumnHeader(1);
            col1.Text = "Nombre";
            listView1.Columns.Add(col1);
            foreach (Archivo item in cargarArchivos)
            {
                ListViewItem itVL = new ListViewItem();
                itVL.Text = Convert.ToString(item.Id);
                itVL.Tag = item;
                listView1.Items.Add(itVL);
                itVL.SubItems.Add(item.Nombre);
            }
        }

        private void mostraArchivos()
        {
            //listView2.View = View.LargeIcon;

            //ImageList img = new ImageList();
            //img.Images.Add(new Bitmap(""));

            //listView2.LargeImageList = img;

            //foreach (var item in cargarArchivos)
            //{
            //    ListViewItem itVL = new ListViewItem(Convert.ToString(item.Nombre), 0);
            //    itVL.Tag = item;
            //    listView2.Items.Add(itVL);

            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                lbid.Text = item.Text;
                lbnombre.Text = item.SubItems[1].Text;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (Archivo item in cargarArchivos)
            {
                foreach (Archivo item_2 in listaArchivos)
                {
                    if (item.Subindice ==  item_2.Subindice)
                    {
                        listView2.Items.Add(item_2.Nombre);
                    }
                }
            }
        }
    }
}