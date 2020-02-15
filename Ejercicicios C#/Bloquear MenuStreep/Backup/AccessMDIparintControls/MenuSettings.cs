using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccessMDIparintControls
{
    class MenuSettings
    {
        public static void EnableMenuItem(string MenuName, string MenuItemName)
        {
            //Access the Parent Form
            Form frm = (Form)Application.OpenForms["Form1"];
            //Access The MenuStrip Control
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
            //Access The First Level Menu Items
            ToolStripMenuItem ti = (ToolStripMenuItem)ms.Items[MenuName];
            //Then I use This control As my needs
            ti.DropDownItems[MenuItemName].Enabled = true;
        }


        public static void EnableMenuItem(string L1MenuItem, string L2MenuItem, string MenuItemName)
        {
            //Access the Parent Form
            Form frm = (Form)Application.OpenForms["Form1"];
            //Access The MenuStrip Control
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
            //Access The First Level Menu Items
            ToolStripMenuItem ti1 = (ToolStripMenuItem)ms.Items[L1MenuItem];
            //Access The Sconed Level Menu Items
            ToolStripMenuItem ti2 = (ToolStripMenuItem)ti1.DropDownItems[L2MenuItem];
            //Then I use This control As my needs
            ti2.DropDownItems[MenuItemName].Enabled = true;

        }
    }
}
