using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase14Barajas.Modelos
{
    public class Baraja
    {
        public List<Carta> CartasPorBarajar { get; set; } //Lista de cartas por barajar.
        public List<Carta> CartasBarajadas { get; set; } //Lista de cartas barajadas

        public Baraja()
        {
            //Inicializo las listas.
            CartasPorBarajar = new List<Carta>();
            CartasBarajadas = new List<Carta>();
        }

        //Método para mezclar las cartas de la baraja.
        public void Barajar()
        {
            var random = new Random();
            var cartasBarajadas = CartasPorBarajar.OrderBy(carta => random.Next());
        }

        //Busco la siguiente carta
        public Carta SiguienteCarta()
        {
            for (var i = 0; i < CartasPorBarajar.Capacity; i++)
            {
                if (i < CartasPorBarajar.Capacity)
                {
                    var carta = CartasPorBarajar[i];

                    //Luego de barajar la carta, la guardo en la lista de cartas barajadas y la elimino de la lista de cartas por barajar.

                    CartasBarajadas.Add(carta);
                    CartasPorBarajar.Remove(carta);
                    break;
                }
                else
                {
                    Console.WriteLine("Ya no quedan más cartas por barajar");
                }
            }

            return CartasBarajadas.Last();
        }

        //Mostrar cantidad de cartas disponibles para barajar.
        public int CartasDisponibles()
        {
            return CartasPorBarajar.Count();
        }

        //Método para repartir cartas.
        public void DarCartas(int cantidad)
        {

            for (int i = 0; i < cantidad; i++)
            {
                var carta = CartasPorBarajar[i];
                Console.WriteLine(carta.Palo + " " + carta.NumeroCarta);
                CartasBarajadas.Add(carta);
                //Las cartas repartidas se agregan en la lista de cartas barajadas.
            }

            //Eliminar las cartas repartidas de la lista de cartas disponibles para el juego.
            for(int i = 0; i < cantidad; i++)
            {
                CartasPorBarajar.RemoveAll(carta => carta.Palo == CartasBarajadas[i].Palo && carta.NumeroCarta == CartasBarajadas[i].NumeroCarta);

            }

            Console.WriteLine(CartasPorBarajar.Count);
        }

        //Mostrar cartas barajadas.
        public void CartasMonton()
        {
            if(CartasBarajadas.Count() != 0)
            {
                foreach (var carta in CartasBarajadas)
                {
                    Console.WriteLine(carta.Palo +" "+ carta.NumeroCarta);
                }
            }
            else
            {
                Console.WriteLine("Aún no se han barajado cartas");
            }
        }

        //Mostrar cartas disponibles para el juego.
        public void MostrarBaraja()
        {
            foreach(var carta in CartasPorBarajar)
            {
                Console.WriteLine(carta.NumeroCarta +" "+  carta.Palo);
            }
        }
    }
}
