using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_Directorio
{
    public partial class Tree_View_Actualizado : Form
    {
        Directorio listaDirectorio;

        internal Directorio ListaDirectorio
        {
            get { return listaDirectorio; }
            set { listaDirectorio = value; }
        }

        public Tree_View_Actualizado()
        {
            InitializeComponent();
        }

        private void Tree_View_Actualizado_Load(object sender, EventArgs e)
        {
            this.listaDirectorio = new Directorio();
            this.listaDirectorio.Id = 1;
            this.listaDirectorio.Nombre = listaDirectorio.Id.ToString() + ") " + "Directorio";
            llenarArbol();
            trvDirectorio.ExpandAll();
            trvDirectorio.HideSelection = false;
        }

        private void llenarArbol()
        {
            trvDirectorio.Nodes.Clear();
            TreeNode nodo = new TreeNode();
            nodo.Text = this.listaDirectorio.Nombre;
            nodo.Tag = this.listaDirectorio;
            trvDirectorio.Nodes.Add(nodo);
            ImprimirRamas(this.listaDirectorio.Directorios, trvDirectorio.Nodes[0]);
            trvDirectorio.ExpandAll();
            trvDirectorio.HideSelection = false;
        }

        private void ImprimirRamas(List<Directorio> directorios, TreeNode nodoPadre)
        {
            int i = 0;
            foreach (Directorio iter in directorios)
            {
                TreeNode nodoHijo = new TreeNode();
                nodoHijo.Text = iter.Id + ") " + iter.Nombre;
                nodoHijo.Tag = iter;
                nodoPadre.Nodes.Add(nodoHijo);

                if (iter.Directorios.Count > 0)
                {
                    ImprimirRamas(iter.Directorios, nodoPadre.Nodes[i]);
                }
                i++;
            }
        }

        private void ImprimirRamas(List<Directorio> directorios)
        {
            foreach (Directorio iter in directorios)
            {
                Console.WriteLine(iter.Id + "-" + iter.Nombre);
                MessageBox.Show(iter.Id + "-" + iter.Nombre);
                if (iter.Directorios.Count > 0)
                {
                    ImprimirRamas(iter.Directorios);
                }
            }
        }

        private void buscarPadre(List<Directorio> directorios, Directorio directorioPadre, Directorio directorioHijo)
        {
            foreach (Directorio iter in directorios)
            {
                if (iter.Id == directorioPadre.Id)
                {
                    iter.Directorios.Add(directorioHijo);
                    break;
                }

                if (iter.Directorios.Count > 0)
                {
                    buscarPadre(iter.Directorios, directorioPadre, directorioHijo);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtNombre.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                }
                else
                {
                    Directorio directorio = new Directorio();
                    directorio.Id = Convert.ToInt32(txtId.Text);
                    directorio.Nombre = txtNombre.Text;
                    Directorio directorioPadre = (Directorio)trvDirectorio.SelectedNode.Tag;
                    if (this.listaDirectorio.Id == directorioPadre.Id)
                    {
                        listaDirectorio.Directorios.Add(directorio);
                    }
                    else
                    {
                        buscarPadre(listaDirectorio.Directorios, directorioPadre, directorio);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un nodo padre.");
            }
            llenarArbol();
            txtId.Clear();
            txtNombre.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Directorio directorioPrincipal = this.listaDirectorio;
            Console.WriteLine(directorioPrincipal.Id + " " + directorioPrincipal.Nombre + " Num de Nodos:" + directorioPrincipal.Directorios.Count);
            MessageBox.Show(directorioPrincipal.Id + " " + directorioPrincipal.Nombre + " Num de Nodos:" + directorioPrincipal.Directorios.Count);
            ImprimirRamas(directorioPrincipal.Directorios);
        }

        private void boton_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtNombre.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                }
                else
                {
                    Directorio directorio = new Directorio();
                    directorio.Id = Convert.ToInt32(txtId.Text);
                    directorio.Nombre = txtNombre.Text;
                    listaDirectorio.Directorios.Add(directorio);
                    boton_Eliminar_Click(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un nodo padre.");
            }
            llenarArbol();
            txtId.Clear();
            txtNombre.Clear();
        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Directorio borrar = (Directorio)trvDirectorio.SelectedNode.Tag;
                listaDirectorio.Directorios.Remove(borrar);
                trvDirectorio.SelectedNode.Remove();
            }
            catch (Exception)
            {
            }
        }

        private void trvDirectorio_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Mediante esta forma se llenan los txtbox pedendiendo del tipo de clase a la cual pertenece
            Directorio comparar = new Directorio();
            if (trvDirectorio.SelectedNode.Tag != null  && Object.ReferenceEquals(trvDirectorio.SelectedNode.GetType(), comparar.GetType()))
            {
                Directorio directorioSeleccionado = ((Directorio)trvDirectorio.SelectedNode.Tag);
                txtId.Text = directorioSeleccionado.Id.ToString();
                txtNombre.Text = directorioSeleccionado.Nombre;   
            }
        }
    }
}