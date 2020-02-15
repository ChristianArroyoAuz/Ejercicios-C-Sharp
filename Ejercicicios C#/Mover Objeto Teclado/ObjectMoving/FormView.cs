using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObjectMoving
{
    public partial class FormView : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }

        private int _x;
        private int _y;
        private Position _objPosition;


        public FormView()
        {
            InitializeComponent();

            _x = 50;
            _y = 50;
            _objPosition = Position.Down;

            //zquanghoangz@gmail.com
        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 100, 100);
            e.Graphics.DrawImage(new Bitmap("mushroom.png"), _x, _y, 64, 64);
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            if (_objPosition == Position.Right)
            {
                _x += 10;
            }
            else if (_objPosition == Position.Left)
            {
                _x -= 10;
            }
            else if (_objPosition == Position.Up)
            {
                _y -= 10;
            }
            else if (_objPosition == Position.Down)
            {
                _y += 10;
            }

            Invalidate();
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _objPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;
            }
            else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;
            }
        }
    }
}
