using Clase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Interfaces
{
    public class RepositoryPersonasEnArchivos<P> : IRepository<P> where P : Persona
    {
        private string _pathArchivo = "c:\\persona.txt";


        public void Actualizar(P persona)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(string numeroDocumento, string apellido, string nombre)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(string numeroDocumento)
        {
            throw new NotImplementedException();
        }

        public bool Existe(string numeroDocumento)
        {
            throw new NotImplementedException();
        }

        public bool Existe(P persona)
        {
            throw new NotImplementedException();
        }

        public void Insertar(P persona)
        {
            throw new NotImplementedException();
        }
    }
}
