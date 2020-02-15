using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccessMDIparintControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.MdiParent = this;
            button1.Enabled = false;
            form2ToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.MdiParent = this;
            button1.Enabled = false;
            form2ToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.MdiParent = this;
            form3ToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.MdiParent = this;
            form4ToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void form5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.MdiParent = this;
            form5ToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void form6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.MdiParent = this;
            form6ToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
