using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_escuela
{
  public  class Alumno
    {

      public Int64 Id { get; set; }
      public String Nombre { get; set; }
      public String Apellido { get; set; }
      public String Direccion { get; set; }
      public String Fecha_Nac { get; set; }

      public Alumno() { }

      public Alumno(Int64 pId, String pNombre, String pApellido, String pDireccion, String pFecha_Nac)

      {
          this.Id = pId;
          this.Nombre = pNombre;
          this.Apellido = pApellido;
          this.Direccion = pDireccion;
          this.Fecha_Nac = pFecha_Nac;
      }
    }
}
