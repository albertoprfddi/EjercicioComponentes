using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioComponentes.datos
{
    public class Clase
    {
        public List<Alumno> ListadoAlumnos;
        public String NombreClase;
        public int CodigoClase;

        public Clase(string nombreClase, int codigoClase)
        {
            ////Carga los alumnos a partir del nombre de la clase
            ListadoAlumnos = new List<Alumno>();
            Alumno alumno1 = new Alumno("Pepe", 1);
            Alumno alumno2 = new Alumno("Mónica", 2);
            ListadoAlumnos.Add(alumno1);
            ListadoAlumnos.Add(alumno2);

            NombreClase = nombreClase;
            CodigoClase = codigoClase;
        }
    }
}
