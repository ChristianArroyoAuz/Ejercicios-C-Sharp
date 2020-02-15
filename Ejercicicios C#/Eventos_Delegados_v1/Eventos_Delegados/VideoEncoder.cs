using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Eventos_Delegados
{
    class VideoEncoder
    {
        //1 Definir un delegado -> Firma del metodo que utilizaran los subscriptores
        //2 Definir un Evento basado en el delegado
        //3 publicar el evento
        //Informacion enviada en EventArgs
        
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        
        public void Encode(Video video)
        {
            //Encoding..
            //Code
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);   
            //Si quiero enviar un email para notificar que finalizo la codificacion
            //mailService.Send(new Mail());
            // Si deseo incrementar otro metodo
            //mesageService.Send(new Text());
            // Se requiere compilar toda la clase por un cambio!
            //Uso de eventos
            OnVideoEncoded();
          }
        //protected virtual void OnVideoEncoded()
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}