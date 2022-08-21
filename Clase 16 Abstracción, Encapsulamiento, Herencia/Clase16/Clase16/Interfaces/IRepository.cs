using Clase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Interfaces
{
    public interface IRepository<P> where P : Persona //GENERICS
    {
        void Insertar(P persona);
        void Eliminar(string numeroDocumento);
        void Actualizar(P persona);
        void Actualizar(string numeroDocumento, string apellido, string nombre);
        bool Existe(string numeroDocumento);
        bool Existe(P persona);
    }
}
