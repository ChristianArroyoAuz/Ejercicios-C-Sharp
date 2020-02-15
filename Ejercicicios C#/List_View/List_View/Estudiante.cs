using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_View
{
    class Estudiante
    {
        int id_Estudiante;
        string nombre_Estudiante;
        string apellido_Estudiante;
        string carrera_Estudiante;
        
        public int Id_Estudiante
        {
            get { return id_Estudiante; }
            set { id_Estudiante = value; }
        }
        public string Nombre_Estudiante
        {
            get { return nombre_Estudiante; }
            set { nombre_Estudiante = value; }
        }
        public string Apellido_Estudiante
        {
            get { return apellido_Estudiante; }
            set { apellido_Estudiante = value; }
        }
        public string Carrera_Estudiante
        {
            get { return carrera_Estudiante; }
            set { carrera_Estudiante = value; }
        }

        public Estudiante(int ini_id_Estudiante, string ini_nombre_Estudiante, string ini_apellido_Estudiante, string ini_carrera_Estuadiante)
        {
            id_Estudiante = ini_id_Estudiante;
            nombre_Estudiante = ini_nombre_Estudiante;
            apellido_Estudiante = ini_apellido_Estudiante;
            carrera_Estudiante = ini_carrera_Estuadiante;
        }

        public override string ToString()
        {
            return id_Estudiante + nombre_Estudiante +
                   apellido_Estudiante + carrera_Estudiante;
        }
    }
}