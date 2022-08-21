using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Modelo
{
    public sealed class Desempleado : Persona
    {
        public string UltimaOcupacion { get; set; }
        public string UltimaEmpresa { get; set; }
        public bool EsDiscapacitado { get; set; }

        public int ObtenerValorDePension()
        {
            if (EsDiscapacitado)
            {
                return 13000;
            }
            else
            {
                return 10000;
            }
        }
    }
}

//¿Para que sirven los modificadores de clase abstract y sealed?
//abstract es como un molde para reciclar código.
//sealed define que esa clase no puede ser heredada.