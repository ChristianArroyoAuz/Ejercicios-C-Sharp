using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Sistema_de_Evacuacion.DB
{
    class MyDB : DataContext
    {
        private const String cadenaConexion = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\usuario\\Desktop\\Sistema de Evacuacion\\Sistema de Evacuacion\\DB\\SE_DataBase.mdf;Integrated Security=True;Connect Timeout=30";        
        public Table<Tabla_Usuario> Usuarios;
        public MyDB() : base(cadenaConexion) { }
    }
}