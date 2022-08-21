using Clase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Interfaces
{
    public class RepositorioPersonasEnDiccionario<P> : IRepository<P> where P : Persona
    {
        public Dictionary<string, P> Personas { get; set; }

        public RepositorioPersonasEnDiccionario()
        {
            Personas = new Dictionary<string, P>();
        }

        public void Insertar(P persona)
        {
            var numeroDocumento = persona.NumeroDeDocumento;
        }
    }
}
