using Clase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Repositorio
{
    public class RepositorioPersonas //para guardar personas
    {
        public List<Persona> Personas {get; set;}

        public RepositorioPersonas() //Constructor
        {
            //Al instanciar la clase, creo la lista.
            Personas = new List<Persona>();
        }

        public void insertar(Persona persona)
        {
            Personas.Add(persona);
        }

        public void eliminar(int numeroDoc)
        {
            //Eliminar
        }

        public void actualizar(Persona persona)
        {
            foreach(Persona personaActual in Personas)
            {
                if(personaActual.NroDocumento == persona.NroDocumento)
                {
                    persona.Apellido = personaActual.Apellido;
                    persona.NroDocumento = personaActual.NroDocumento;
                }
            }
        }
    }
}
