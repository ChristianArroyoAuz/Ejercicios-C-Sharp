using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traspaso_de_Datos_Formularios
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Usuario> lista_inicial_Ingreso = new List<Usuario>();
            List<Usuario> lista_inicial_Actualizar = new List<Usuario>();
            List<Usuario> lista_inicial_Eliminar = new List<Usuario>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Recepcion_de_Datos(lista_inicial_Ingreso, lista_inicial_Actualizar, lista_inicial_Eliminar));
        }
    }
}
