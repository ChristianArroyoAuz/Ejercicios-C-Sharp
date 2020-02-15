using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramdon_Button
{
    public partial class Form1 : Form
    {
        public Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = r.Next(0,445);
            int y = r.Next(0,445);
            button1.Top = y;
            button1.Left = x;
            label1.Text = Convert.ToString(x
                
                );
        }
    }
}
