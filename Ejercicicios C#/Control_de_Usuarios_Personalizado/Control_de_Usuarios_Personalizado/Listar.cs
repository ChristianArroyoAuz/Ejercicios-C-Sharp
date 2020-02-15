using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Usuarios_Personalizado
{
    public partial class Listar : UserControl
    {
        List<String> items = new List<string>();
        public event EventHandler Lista_Click;

        public List<String> Items
        {
            get { return items; }
            set { items = value; }
        }

        public Listar()
        {
            InitializeComponent();
        }

        private void OnClick(object sender)
        {
            if (Lista_Click != null)
            {
                Lista_Click(this, EventArgs.Empty);
                //Lista_Click(sender, new EventArgs());
            }
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {
            items.Add(txt_Nombre.Text);
            OnClick(sender);
        }
    }
}
