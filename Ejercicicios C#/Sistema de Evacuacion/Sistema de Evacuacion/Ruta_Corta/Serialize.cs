using System;

namespace Sistema_de_Evacuacion.Ruta_Corta
{
    partial class TxtMatrixSerializer
    {
        //________________________________________________________________________

        private const char FRECHAR = ' ';
        private const char FIXCHAR = '#';
        private const char WAYCHAR = '+';
        //________________________________________________________________________

        public virtual bool Serialize(System.IO.TextWriter writer, Ruta_Corta.Matrix matrix)
        {
            if ((matrix.m_Size.Column < 3) || (matrix.m_Size.Row < 3)) return false;

            writer.WriteLine();
            writer.WriteLine(";" + System.Windows.Forms.Application.ProductName);
            writer.WriteLine(";Version: " + System.Windows.Forms.Application.ProductVersion);
            writer.WriteLine(";Matrix ({0}, {1})", matrix.m_Size.Row, matrix.m_Size.Column);
            writer.WriteLine();

            writer.WriteLine(";Matrix is:");
            this.WriteMatrix(writer, matrix, 0x3);
            writer.WriteLine();
            writer.WriteLine();

            if (!matrix.Contains(Ruta_Corta.CellType.Negro)) return true;

            writer.WriteLine(";Way is:");
            this.WriteMatrix(writer, matrix, 0x5);
            writer.WriteLine();
            writer.WriteLine();


            writer.WriteLine(";Matrix and Way is:");
            this.WriteMatrix(writer, matrix, 0x7);
            writer.WriteLine();
            writer.WriteLine();

            return true;
        }
        //________________________________________________________________________

        internal void WriteMatrix(System.IO.TextWriter writer, Ruta_Corta.Matrix matrix, int flags)
        {
            for (byte r = byte.MinValue; r < matrix.m_Size.Row; ++r)
            {
                for (byte c = byte.MinValue; c < matrix.m_Size.Column; ++c)
                {
                    switch (matrix.m_Buffer[r, c])
                    {
                        case Ruta_Corta.CellType.Verde:
                            writer.Write(((flags & 2) > 0) ? FIXCHAR : FRECHAR);
                            break;

                        case Ruta_Corta.CellType.Negro:
                            writer.Write(((flags & 4) > 0) ? WAYCHAR : FRECHAR);
                            break;

                        default:
                            writer.Write(FRECHAR);
                            break;
                    }
                }
                writer.WriteLine();
            }
        }
        //________________________________________________________________________

        public bool Serialize(System.IO.Stream stream, Ruta_Corta.Matrix matrix)
        {                                                   
            using (var writer = new System.IO.StreamWriter(stream, System.Text.Encoding.UTF8))
            {
                return this.Serialize(writer, matrix);
            }
        }
        //________________________________________________________________________

        public bool Serialize(string file, Ruta_Corta.Matrix matrix)
        {
            if (string.IsNullOrEmpty(file)) return false;
            if (System.IO.File.Exists(file))
            {
                System.IO.File.SetAttributes(file, System.IO.FileAttributes.Normal);
                System.IO.File.Delete(file);
            }
            //-----
            using (var writer = new System.IO.StreamWriter(file, false, System.Text.Encoding.UTF8))
            {
                return this.Serialize(writer, matrix);
            }
        }
        //________________________________________________________________________
    }
}