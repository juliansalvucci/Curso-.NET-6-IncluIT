using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelos
{
    public class Cuadrado : Cuadrilatero
    {
        public Cuadrado(int coordenadasX, int coordenadasY) : base()
        {
           _coordenadasX = coordenadasX;
           _coordenadasY = coordenadasY;
        }

        public override int CalcularArea()
        {
            var areaCuadrado = _coordenadasX * _coordenadasY;

            return areaCuadrado;
        }
    }
}
