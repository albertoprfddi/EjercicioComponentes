using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioComponentes.datos
{
    public class BloqueInfoAlumno
    {
        public string Nombre { get; set; }
        public string Asignatura { get; set; }
        public string Estado { get; set; }

        public BloqueInfoAlumno(string nombre, string asignatura, string estado)
        {
            Nombre = nombre;
            Asignatura = asignatura;
            Estado = estado;
        }
    }
}
