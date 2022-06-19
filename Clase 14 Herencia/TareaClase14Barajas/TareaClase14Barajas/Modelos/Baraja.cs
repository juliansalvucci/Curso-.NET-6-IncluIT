using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase14Barajas.Modelos
{
    public class Baraja
    {
        public List<Carta> Cartas { get; set; }

        public void Barajar()
        {

        }

        public Carta SiguienteCarta()
        {
            return new Carta();
        }

        public int CartasDisponibles()
        {
            return Cartas.Capacity;
        }

        public void DarCartas(int cantidad)
        {

        }

        public void CartasMonton()
        {

        }

        public void MostrarBaraja()
        {

        }
    }

}
