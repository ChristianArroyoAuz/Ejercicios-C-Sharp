using System;

namespace Sistema_de_Evacuacion.Ruta_Corta
{
    partial class Matrix
    {
        private static Ruta_Corta.TxtMatrixSerializer m_StringHelper;

        private static Ruta_Corta.TxtMatrixSerializer StringHelper
        {
            get
            {
                if (Matrix.m_StringHelper == null)
                    Matrix.m_StringHelper = new Ruta_Corta.TxtMatrixSerializer();

                return Matrix.m_StringHelper;
            }
        }

        public static bool TryParse(string s, out Matrix result)
        {
            result = null;
            try
            {
                result = Matrix.Parse(s);
            }
            catch { }
            return (result != null);
        }

        public static Matrix Parse(string s)
        {
            if (((object)s == null) || (s.Length <= 10)) return null;

            using (var reader = new System.IO.StringReader(s))
            {
                return Matrix.StringHelper.Deserialize(reader);
            }
        }

        public override string ToString()
        {
            if ((this.m_Size.Row <= 0) || (this.m_Size.Column <= 0)) return string.Empty;
            var ret = new System.Text.StringBuilder(this.m_Size.Row * (this.m_Size.Column + 2) + 5);
            return ret.ToString();
        }
    }
}