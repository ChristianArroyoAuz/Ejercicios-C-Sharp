using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Sistema_de_Evacuacion.DB
{
    [Table(Name = "Usuarios")]
    class Tabla_Usuario
    {
        [Column(IsPrimaryKey = true)]
        public String LoginUser;

        [Column]
        public String Nombre;

        [Column]
        public String Apellido;

        [Column]
        public String Contraseña;

        [Column]
        public String eMail;

        [Column]
        public int Telefono;

        [Column]
        public String Pais;

        [Column]
        public String Fecha;

        [Column]
        public String Sexo;

        [Column]
        public int Id;
    }
}