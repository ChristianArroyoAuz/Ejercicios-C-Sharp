using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos_Delegados
{
    class Message_Service
    {
        //public void OnVideoEncoded(object source, EventArgs e)
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MessageService: Enviando Mensaje de Texto...");
        }
    }
}
