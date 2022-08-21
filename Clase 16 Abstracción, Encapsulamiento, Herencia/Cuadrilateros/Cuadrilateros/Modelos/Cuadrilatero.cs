using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelos
{
    public abstract class Cuadrilatero
    {
        protected int _coordenadasX;
        protected int _coordenadasY;

        public Cuadrilatero()
        {
        }

        public abstract int CalcularArea();
               
    }
}
