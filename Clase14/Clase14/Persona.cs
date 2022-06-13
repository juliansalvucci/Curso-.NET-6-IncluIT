using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        //ctor + tab y crea el constructor.
        public Persona()
        {
            Nombre = "Julián";
            Apellido = "Salvucci";
        }
    }
}
