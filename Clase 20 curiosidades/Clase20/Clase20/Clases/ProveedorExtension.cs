using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20.Clases
{
    public static class ProveedorExtension
    {
        public static int CalcularCredito(this Proveedor p)
        {
            if(p.Nombre == null)
            {
                return 100;
            }

            return 0;
        }
    }
}
