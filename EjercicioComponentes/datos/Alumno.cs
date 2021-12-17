using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioComponentes.datos
{
    public class Alumno
    {
        public List<Nota> Expediente;
        public string Nombre;
        public int Codigo;

        public Alumno(string nombre, int codigo)
        {
            Nombre = nombre;
            Codigo = codigo;
            Expediente = new List<Nota>();
            ////Cargamos las notas del alumno usando su código
            Nota nota1 = new Nota("DDI", "Suspenso", true, 1);
            Nota nota2 = new Nota("MME", "Suspenso", false,2);
            Nota nota3 = new Nota("ISO", "Aprobado", false,3);
            Expediente.Add(nota1);
            Expediente.Add(nota2);
            Expediente.Add(nota3);
        }

        public Alumno()
        {
        }
    }
}
