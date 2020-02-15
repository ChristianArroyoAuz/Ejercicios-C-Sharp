using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime uno = DateTime.Parse(dateTimePicker1.Text);
            DateTime dos = DateTime.Parse(dateTimePicker2.Text);
            int com = DateTime.Compare(uno, dos);
            if (com < 0 )
            {
                label1.Text = "siga";
            }
            else
            {
                label1.Text = "mal";
            }
        }
    }
}
