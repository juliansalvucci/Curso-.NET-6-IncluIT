using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14Herencia
{
    public class Alumno : Persona //Herencia 
    {
        public string Curso { get; set; }
        public string Division { get; set; }

        public string recuperarClave()
        {
            return clave();
        }
    }
}
