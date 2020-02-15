using System;

namespace Sistema_de_Evacuacion.Ruta_Corta
{
    public class UIBoardBox : System.Windows.Forms.Control
    {
        private volatile Ruta_Corta.Matrix m_Matrix = new Ruta_Corta.Matrix(new Ruta_Corta.Point(57, 30));
        private System.Drawing.Size m_CellSize = new System.Drawing.Size(16, 16);
        private System.Drawing.Image m_StyleImage;
        private readonly System.Drawing.Rectangle[] m_SIRectCache = new System.Drawing.Rectangle[3];

        public UIBoardBox()
        {
            SetStyle(
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer |
                System.Windows.Forms.ControlStyles.ResizeRedraw |
                System.Windows.Forms.ControlStyles.SupportsTransparentBackColor |
                System.Windows.Forms.ControlStyles.UserPaint,
                true);
            m_Matrix.CreateBorder();
        }

        public System.Drawing.Image StyleImage
        {
            get { return m_StyleImage; }
            set
            {
                if (m_StyleImage == value) return;

                if (value == null)
                {
                    m_StyleImage = null;
                    Invalidate();
                    return;
                }
                int w = value.Width / 3;
                int h = value.Height;
                if ((w <= 0) || (h <= 0))
                    throw new ArgumentException();
                m_StyleImage = value;
                //Blaco
                //m_SIRectCache[(int)Ruta_Corta.CellType.Blanco] = new System.Drawing.Rectangle(0, 0, w, h);
                //Verde
                //m_SIRectCache[(int)Ruta_Corta.CellType.Verde] = new System.Drawing.Rectangle(w, 0, w, h);
                //Negro
                m_SIRectCache[(int)Ruta_Corta.CellType.Negro] = new System.Drawing.Rectangle(w + w, 0, w, h);
                Invalidate();
            }
        }

        public System.Drawing.Size MatrixSize
        {
            get
            {
                if (m_Matrix == null) return new System.Drawing.Size();
                return new System.Drawing.Size(m_Matrix.m_Size.Column, m_Matrix.m_Size.Row);
            }
            set
            {
                if ((value.Width < 3) || (value.Height < 3) || (value.Width > byte.MaxValue) || (value.Height > byte.MaxValue))
                {
                    m_Matrix = null;
                }
                else if ((m_Matrix == null) || (value.Width != m_Matrix.m_Size.Column) || (value.Height != m_Matrix.m_Size.Row))
                {
                    m_Matrix = new Ruta_Corta.Matrix(new Ruta_Corta.Point((byte)value.Height, (byte)value.Width));
                    m_Matrix.CreateBorder();
                }
                Invalidate();
            }
        }

        public Ruta_Corta.Matrix Matrix
        {
            get { return m_Matrix; }
            set
            {
                if (m_Matrix == value) return;
                m_Matrix = value;
                Invalidate();
            }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            int iCell_H = m_CellSize.Height;
            int iCell_W = m_CellSize.Width;
            var graph = e.Graphics;
            var rectCell = new System.Drawing.Rectangle(0, 0, iCell_W, iCell_H);

            if ((m_StyleImage == null) || (m_Matrix.m_Size.Row <= 0) || (m_Matrix.m_Size.Column <= 0) || (iCell_H <= 0) || (iCell_W <= 0))
            {
                base.OnPaint(e);
                return;
            }

            for (int row = 0; row < m_Matrix.m_Size.Row; ++row)
            {
                rectCell.Y = row * iCell_H;
                for (int col = 0; col < m_Matrix.m_Size.Column; ++col)
                {
                    rectCell.X = col * iCell_W;
                    graph.DrawImage(m_StyleImage, rectCell, m_SIRectCache[(int)m_Matrix.m_Buffer[row, col]], System.Drawing.GraphicsUnit.Pixel);
                }
            }
            base.OnPaint(e);
        }

        protected override void OnMouseClick(System.Windows.Forms.MouseEventArgs e)
        {
            int iCell_H = m_CellSize.Height;
            int iCell_W = m_CellSize.Width;

            if ((m_Matrix.m_Size.Row > 0) && (m_Matrix.m_Size.Column > 0) && (iCell_H > 0) && (iCell_W > 0))
            {
                int row = e.Y / iCell_H;
                int col = e.X / iCell_W;

                if ((row >= 0) && (col >= 0) && (row < m_Matrix.m_Size.Row) && (col < m_Matrix.m_Size.Column))
                {
                    if (m_Matrix.m_Buffer[row, col] == Ruta_Corta.CellType.Verde)
                        m_Matrix.m_Buffer[row, col] = Ruta_Corta.CellType.Blanco;
                    else
                        m_Matrix.m_Buffer[row, col] = Ruta_Corta.CellType.Verde;


                    base.OnMouseClick(e);
                    m_Matrix.ClearWay();
                    Invalidate();
                    return;
                }
            }

            base.OnMouseClick(e);
        }
    }
}