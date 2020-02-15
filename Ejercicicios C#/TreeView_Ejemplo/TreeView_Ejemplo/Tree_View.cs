using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_Ejemplo
{
    public partial class Tree_View : Form
    {
        List<Categoria> listaCategorias = new List<Categoria>();
        List<Pelicula> listaPeliculas = new List<Pelicula>();

        public Tree_View()
        {
            InitializeComponent();
        }

        private void Tree_View_Load(object sender, EventArgs e)
        {
            //Agregando Visualmente como Strings
            arbol_Peliculas.Nodes.Add("Peliculas");
            arbol_Peliculas.Nodes[0].Nodes.Add("Saw");
            arbol_Peliculas.Nodes[0].Nodes[0].Nodes.Add("Saw 1");
            arbol_Peliculas.Nodes[0].Nodes[0].Nodes.Add("Saw 2");
            arbol_Peliculas.Nodes[0].Nodes[0].Nodes.Add("Saw 3");
            arbol_Peliculas.Nodes[0].Nodes.Add("Batman");
            arbol_Peliculas.Nodes[0].Nodes[1].Nodes.Add("Batman Begins");
            arbol_Peliculas.Nodes[0].Nodes[1].Nodes.Add("Batman y Rise Darknight");
            arbol_Peliculas.Nodes[0].Nodes[1].Nodes.Add("Batman Returns");
            
            //Agregar con Clases y Objetos
            Categoria Comedia = new Categoria(1, "Comedia");
            Categoria Accion = new Categoria(2, "Accion");
            Categoria Terror = new Categoria(3, "Terror");
            listaCategorias.Add(Comedia);
            listaCategorias.Add(Accion);
            listaCategorias.Add(Terror);

            Pelicula uno = new Pelicula(1, "Scary Movie", Comedia);
            Pelicula dos = new Pelicula(2, "HangOver", Comedia);
            Pelicula tres = new Pelicula(3, "Rambo", Accion);
            Pelicula cuatro = new Pelicula(4, "Avengers", Accion);
            Pelicula cinco = new Pelicula(5, "Freddy", Terror);
            Pelicula seis = new Pelicula(6, "Jason", Terror);
            listaPeliculas.Add(uno);
            listaPeliculas.Add(dos);
            listaPeliculas.Add(tres);
            listaPeliculas.Add(cuatro);
            listaPeliculas.Add(cinco);
            listaPeliculas.Add(seis);

            arbol_Peliculas_2.Nodes.Add("Peliculas");
            foreach (Categoria item in listaCategorias)
            {
                TreeNode nodo = new TreeNode();
                nodo.Text = item.Nombre_Categoria;
                nodo.Tag = item;
                arbol_Peliculas_2.Nodes[0].Nodes.Add(nodo);
            }
            foreach (Pelicula item in listaPeliculas)
            {
                if (item.Categorias.Nombre_Categoria == "Comedia")
                {
                    TreeNode comedia = new TreeNode();
                    comedia.Text = item.Nombre;
                    comedia.Tag = item;
                    arbol_Peliculas_2.Nodes[0].Nodes[0].Nodes.Add(comedia);
                }
                if (item.Categorias.Nombre_Categoria == "Accion")
                {
                    TreeNode accion = new TreeNode();
                    accion.Text = item.Nombre;
                    accion.Tag = item;
                    arbol_Peliculas_2.Nodes[0].Nodes[1].Nodes.Add(accion);
                }
                if (item.Categorias.Nombre_Categoria == "Terror")
                {
                    TreeNode terror = new TreeNode();
                    terror.Text = item.Nombre;
                    terror.Tag = item;
                    arbol_Peliculas_2.Nodes[0].Nodes[2].Nodes.Add(terror);
                }
            }
        }

        private void arbol_Peliculas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            etiquetaPeliculas.Text = arbol_Peliculas.SelectedNode.Text;
        }
    }
}
