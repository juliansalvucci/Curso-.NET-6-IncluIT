using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14Herencia
{
    public class Persona
    {
        public string NombreCompleto { get; set; }

        public Persona()
        {
            NombreCompleto = "Julián Salvucci";
        }

        protected string clave()
        {
            return "LACLAVEESTAENTUORAZÓN JUJU";
        }
    }
}
