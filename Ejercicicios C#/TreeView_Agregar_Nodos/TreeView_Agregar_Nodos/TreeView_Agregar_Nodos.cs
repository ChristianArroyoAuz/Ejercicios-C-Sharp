using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_Agregar_Nodos
{
    public partial class TreeView : Form
    {
        //listaDirectorios------>Lista para consulta de Datos
        //listaParcial---------->Lista para impresion visual treeView
        List<Directorios> listaDirectorio = new List<Directorios>();
        List<Directorios> listaParcial = new List<Directorios>();
        TreeNode numero;

        public TreeView()
        {
            InitializeComponent();
        }

        private void TreeView_Load(object sender, EventArgs e)
        {
            agregarDatos();
            arbolDirectorios.ExpandAll();
            arbolDirectorios.HideSelection = false;
        }

        private void agregarDatos()
        {
            #region Formas de TreeView
            //Forma 1
            //arbolDirectorios.Nodes.Add("/");
            //arbolDirectorios.Nodes[0].Nodes.Add("Nodo 1");
            //arbolDirectorios.Nodes[0].Nodes.Add("Nodo 2");
            //arbolDirectorios.Nodes[0].Nodes[0].Nodes.Add("Nodo 1_1");
            //arbolDirectorios.Nodes[0].Nodes[1].Nodes.Add("Nodo 2_1");

            //Forma 2
            //TreeNode Nodo = new TreeNode("Windows");
            //arbolDirectorios.Nodes.Add(Nodo);
            //Nodo = new TreeNode("Linux");
            //arbolDirectorios.Nodes.Add(Nodo);
            //TreeNode node2 = new TreeNode("C#");
            //TreeNode node3 = new TreeNode("VB.NET");
            //TreeNode[] array = new TreeNode[] { node2, node3 };
            //Nodo = new TreeNode("VB", array);
            //arbolDirectorios.Nodes.Add(Nodo);

            //Forma 3
            //Se debe quitar comentario arriba
            //Directorios directorioRaiz = new Directorios(1, "/");
            //Directorios d2 = new Directorios(2, "Archivos de Programa/");
            //Directorios d3 = new Directorios(3, "Usuarios/");
            //Directorios d4 = new Directorios(4, "Windows/");
            //List<Directorios> directoriosPrimerN = new List<Directorios>();
            //directoriosPrimerN.Add(d2);
            //directoriosPrimerN.Add(d3);
            //directoriosPrimerN.Add(d4);
            //directorioRaiz.DirectoriosListas = directoriosPrimerN;
            //TreeNode nodoRaiz = new TreeNode();
            //nodoRaiz.Tag = directorioRaiz;
            //nodoRaiz.Text = directorioRaiz.Nombre;
            //arbolDirectorios.Nodes.Add(nodoRaiz);
            //foreach (var dir in directorioRaiz.DirectoriosListas)
            //{
            //    TreeNode nodo = new TreeNode();
            //    nodo.Tag = dir;
            //    nodo.Text = dir.Nombre;
            //    arbolDirectorios.Nodes[0].Nodes.Add(nodo);
            //}
            #endregion

            arbolDirectorios.TabIndex = 0;
            Directorios dir0 = new Directorios(arbolDirectorios.TabIndex, "/");
            listaDirectorio.Add(dir0);
            listaParcial.Add(dir0);
            foreach (Directorios agregarDirectorioRaiz in listaParcial)
            {
                TreeNode nodoPadre = new TreeNode();
                nodoPadre.Tag = agregarDirectorioRaiz;
                nodoPadre.Text = agregarDirectorioRaiz.Nombre;
                arbolDirectorios.Nodes.Add(nodoPadre);
            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un texto.");
                txtNombre.Focus();
            }
            else
            {
                if (arbolDirectorios.Nodes.Count == 0)
                {
                    arbolDirectorios.TabIndex = 0;
                    Directorios dir0 = new Directorios(arbolDirectorios.TabIndex, txtNombre.Text);
                    listaDirectorio.Add(dir0);
                    listaParcial.Add(dir0);
                    foreach (Directorios agregarDirectorioRaiz in listaParcial)
                    {
                        TreeNode nodoPadre = new TreeNode();
                        nodoPadre.Tag = agregarDirectorioRaiz;
                        nodoPadre.Text = agregarDirectorioRaiz.Nombre;
                        arbolDirectorios.Nodes.Add(nodoPadre);
                        txtNombre.Clear();
                    }
                }
                else
                {
                    try
                    {
                        if (arbolDirectorios.Nodes.Count > 0)
                        {
                            listaParcial.Clear();
                            arbolDirectorios.TabIndex = arbolDirectorios.TabIndex + 1;
                            Directorios nuevo = new Directorios(arbolDirectorios.TabIndex, txtNombre.Text);
                            listaDirectorio.Add(nuevo);
                            listaParcial.Add(nuevo);
                            foreach (var agregarDirectorioX in listaParcial)
                            {
                                TreeNode nodoHijo = new TreeNode();
                                nodoHijo.Tag = agregarDirectorioX;
                                nodoHijo.Text = agregarDirectorioX.Nombre;
                                arbolDirectorios.SelectedNode.Nodes.Add(nodoHijo);
                                arbolDirectorios.SelectedNode.Expand();
                                txtNombre.Clear();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Debe seleccionar un nodo");
                    }
                }
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (arbolDirectorios.Nodes.Count > 0)
            {
                try
                {
                    Directorios borrar = (Directorios)arbolDirectorios.SelectedNode.Tag;
                    listaDirectorio.Remove(borrar);
                    listaParcial.Remove(borrar);
                    arbolDirectorios.SelectedNode.Remove();
                    txtNombre.Clear();
                    txtRenombrar.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo Borrar.");
                }
            }
            else
            {
                if (arbolDirectorios.Nodes.Count == 0)
                {
                    MessageBox.Show("No exiten elementos para eliminar.");
                }
                else
                {
                    MessageBox.Show("Selecione para Eliminar.");
                }
            }
        }

        private void botonLimpiarTodo_Click(object sender, EventArgs e)
        {
            if (arbolDirectorios.Nodes.Count == 0)
            {
                MessageBox.Show("No exiten elementos para eliminar.");
            }
            else
            {
                arbolDirectorios.Nodes.Clear();
                listaDirectorio.Clear();
                listaParcial.Clear();
                txtNombre.Clear();
                txtRenombrar.Clear();
            }
        }

        private void botonRenobrar_Click(object sender, EventArgs e)
        {
            if (arbolDirectorios.SelectedNode == null)
            {
                MessageBox.Show("No existen elementos a renombrar.");
            }
            else
            {
                if (txtRenombrar.Text == "")
                {
                    MessageBox.Show("Debe ingresar un texto.");
                    txtRenombrar.Focus();
                }
                else
                {
                    listaParcial.Clear();
                    Directorios datos = (Directorios)arbolDirectorios.SelectedNode.Tag;
                    Directorios actualizar = new Directorios(datos.Id, txtRenombrar.Text);
                    listaDirectorio.Add(actualizar);
                    listaParcial.Add(actualizar);
                    foreach (Directorios item in listaParcial)
                    {
                        TreeNode nodoActualizado = new TreeNode();
                        nodoActualizado.Tag = item;
                        nodoActualizado.Text = item.Nombre;
                        numero.Nodes.Add(nodoActualizado);
                        arbolDirectorios.SelectedNode.Expand();
                        txtNombre.Clear();
                        txtRenombrar.Clear();

                    }
                    botonEliminar_Click(sender, e);
                }
            }
        }

        private void arbolDirectorios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Directorios actulizar = (Directorios)arbolDirectorios.SelectedNode.Tag;
            txtRenombrar.Text = actulizar.Nombre;
            if (e.Node.Parent != null && e.Node.Parent.GetType() == typeof(TreeNode))
            {
                numero = e.Node.Parent;
            }
        }
    }
}