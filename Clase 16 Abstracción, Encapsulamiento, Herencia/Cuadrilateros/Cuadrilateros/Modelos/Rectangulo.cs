using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelos
{
    public class Rectangulo : Cuadrilatero
    {
        public Rectangulo(int coordenadasX, int coordenadasY) : base()
        {
            _coordenadasX = coordenadasX;
            _coordenadasY = coordenadasY;
        }

        public override int CalcularArea()
        {
            var areaRectangulo = _coordenadasX * _coordenadasY;

            return areaRectangulo;
        }
    }
}
