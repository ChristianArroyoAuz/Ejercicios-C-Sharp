using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Genealogico
{
    public partial class Registro_Genealogico : Form
    {
        List<Persona> agregarDescendencia = new List<Persona>();
        Persona familiaRaiz = new Persona();
        DateTime fecha_Padre;
        DateTime fecha_Hijo;

        public Registro_Genealogico()
        {
            InitializeComponent();
        }

        private void Registro_Genealogico_Load(object sender, EventArgs e)
        {
            llenarDatos();
        }

        public void llenarDatos()
        {
            DateTime fechaCero = new DateTime(1900, 01, 01);
            familiaRaiz.Id = 0;
            familiaRaiz.Nombre = "Arbol Genealogio Familia X";
            familiaRaiz.Apellido = "Arbol Genealogio Familia X";
            familiaRaiz.FechaNacimiento = fechaCero;
            agregarDescendencia.Add(familiaRaiz);
            foreach (Persona item in agregarDescendencia)
            {
                TreeNode raiz = new TreeNode();
                raiz.Tag = item.Nombre;
                raiz.Text = item.ToString();
                trv_Genealogico.Nodes.Add(raiz);
            }
            trv_Genealogico.ExpandAll();
            trv_Genealogico.HideSelection = false;
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text == "" || txt_Nombre.Text == "" || txt_Apellido.Text == "")
            {
                MessageBox.Show("Debe Llenar todos los campos.");
            }
            else
            {
                if (trv_Genealogico.SelectedNode == null)
                {
                    MessageBox.Show("Debe Seleccionar un Nodo Padre.");
                }
                else
                {
                    fecha_Padre = new DateTime(1900, 01 , 01);
                    fecha_Hijo = dtp_Fecha.Value;
                    if (fecha_Padre.Year < fecha_Hijo.Year)
                    {
                        Persona nuevaPersona = new Persona(Convert.ToInt32(txt_Id.Text), txt_Nombre.Text, txt_Apellido.Text, fecha_Hijo, agregarDescendencia);
                        agregarDescendencia.Add(nuevaPersona);
                        foreach (Persona item in agregarDescendencia)
                        {
                            TreeNode nuevo = new TreeNode();
                            nuevo.Tag = item.Nombre;
                            nuevo.Text = item.ToString();
                            trv_Genealogico.SelectedNode.Nodes.Add(nuevo);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La edad del Padre debe ser mayor a la del hijo");
                    }
                }
            }
        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            trv_Genealogico.SelectedNode.Remove();
        }

        private void boton_Imprimir_Click(object sender, EventArgs e)
        {
            foreach (Persona item in agregarDescendencia)
            {
                Console.WriteLine(item);   
            }
        }
    }
}