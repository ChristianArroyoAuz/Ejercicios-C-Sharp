using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Usuarios_Personalizado
{
    public partial class Control_Personalizado : Form
    {
        public Control_Personalizado()
        {
            InitializeComponent();
        }

        private void Control_Personalizado_Load(object sender, EventArgs e)
        {
            listar1.Lista_Click += ListarClick;
        }

        public void ListarClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in listar1.Items)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
