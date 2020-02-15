using System;

namespace Sistema_de_Evacuacion.Ruta_Corta
{
    public interface IMatrixSerializer
    {
        object Parameters { get; }
        System.IServiceProvider HostService { get; set; }

        string[] Extensions { get; }

        bool CanRead { get; }
        bool CanWrite { get; }

        Ruta_Corta.Matrix Deserialize(System.IO.Stream file);
        bool Serialize(System.IO.Stream file, Ruta_Corta.Matrix matrix);
    }
}