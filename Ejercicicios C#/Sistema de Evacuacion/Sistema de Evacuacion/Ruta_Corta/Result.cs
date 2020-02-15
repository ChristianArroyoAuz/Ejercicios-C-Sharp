using System;

namespace Sistema_de_Evacuacion.Ruta_Corta
{
    //________________________________________________________________________

    public delegate void ResultEventHandler(object sender, ResultEventArgs e);
    //________________________________________________________________________

    public class ResultEventArgs
        : EventArgs
    {
        public readonly System.Collections.Generic.IEnumerable<Point> Path;
        public readonly bool IsFinish;

        public ResultEventArgs(System.Collections.Generic.IEnumerable<Point> Path, bool IsFinish)
        {
            this.Path = Path;
            this.IsFinish = IsFinish;
        }
    }
    //________________________________________________________________________
}