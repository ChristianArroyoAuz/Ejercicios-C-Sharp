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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if the control is on the parent Form Direct Like button1 I can access it by one single line code
            ((Form)this.MdiParent).Controls["button1"].Enabled = true;
            //but if the control is owned by onther control on the parent Form I must Access parent Form then Access The Control that Holed the Control I wanna to access like a tree system
            Form frm = (Form)this.MdiParent;
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
            ToolStripMenuItem ti = (ToolStripMenuItem)ms.Items["fileToolStripMenuItem"];
            ti.DropDownItems["form2ToolStripMenuItem"].Enabled = true;
        }
    }
}
