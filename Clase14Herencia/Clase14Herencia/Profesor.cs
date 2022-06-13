using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14Herencia
{
    public class Profesor : Persona
    {
        public int CantidadAlumnos { get; set; }

        public string Materia { get; set; }
    }
}
