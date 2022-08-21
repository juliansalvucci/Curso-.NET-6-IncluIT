using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelos
{
    internal class Trapecio : Cuadrilatero
    {
        private int _h;

        public Trapecio(int coordenadasX, int coordenadasY, int altura) : base()
        {
            _coordenadasX = coordenadasX;
            _coordenadasY = coordenadasY;
            _h = altura;
        }

        public override int CalcularArea()
        {
            var areaTrapecio = _h*((_coordenadasX + _coordenadasY)/2);

            return areaTrapecio;
        }
    }
}
