using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioComponentes.datos
{
    
    public class Nota
    {
        public string Asignatura { set; get; }
        public string Estado { set; get; }
        public Boolean Recuperado { set; get; }
        public int CodigoAsign { set; get; }

        public Nota(string asignatura, string estado, bool recuperado, int codigoAsign)
        {
            Asignatura = asignatura;
            Estado = estado;
            Recuperado = recuperado;
            CodigoAsign = codigoAsign;
        }

        public Nota()
        {
        }
    }
}
