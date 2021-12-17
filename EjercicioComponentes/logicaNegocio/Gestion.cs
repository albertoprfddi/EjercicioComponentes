using System;
using System.Collections.Generic;
using System.Text;
using EjercicioComponentes.datos;
using System.Windows.Controls;
using EjercicioComponentes.ControlesPropios;

namespace EjercicioComponentes.logicaNegocio
{
   public class Gestion
    {
        public Clase Clase;
        public Clase cargarClase(string nombreClase, int codigoClase) {
            Clase = new Clase(nombreClase, codigoClase);

            return Clase;
        }

        public Gestion()
        {
            Clase = cargarClase("2º DAM", 1);
        }
        public void MuestraAlumnos(StackPanel StPnAlumnos) {
            foreach (Alumno alumno in Clase.ListadoAlumnos)
            {//para cada alumno de la clase
                foreach (Nota nota in alumno.Expediente)
                {//Para cada nota de cada alumno...
                    //Creamos un objeto creado adhoc para usar Binding con nuestro control personalizado
                    BloqueInfoAlumno bloqueInfoAlumno = new BloqueInfoAlumno(alumno.Nombre, nota.Asignatura, nota.Estado);
                    //Una vez creado el objeto con los datos a mostrar creamos el nuevo control
                    InfoAlumno infoAlumno = new InfoAlumno();
                    //lo enlazamos con el bloque de información creado
                    infoAlumno.DataContext = bloqueInfoAlumno;
                    //Lo añadimos al stackPanel
                    StPnAlumnos.Children.Add(infoAlumno);
                }
            }
        }
    }
}
