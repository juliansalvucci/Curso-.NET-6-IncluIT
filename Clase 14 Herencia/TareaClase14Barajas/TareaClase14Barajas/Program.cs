

using TareaClase14Barajas;
using TareaClase14Barajas.Modelos;


var carta1 = new Carta
{
    NumeroCarta = 7,
    Palo = "Basto"
};

var carta2 = new Carta
{
    NumeroCarta = 2,
    Palo = "Espada"
};

var carta3 = new Carta
{
    NumeroCarta = 5,
    Palo = "Copas"
};

var baraja = new Baraja();

baraja.CartasPorBarajar = new List<Carta>();
baraja.CartasBarajadas = new List<Carta>();

baraja.CartasPorBarajar.Add(carta1);
baraja.CartasPorBarajar.Add(carta2);
baraja.CartasPorBarajar.Add(carta3);

/*
Console.WriteLine("SIGUIENTE CARTA");
Console.WriteLine(baraja.SiguienteCarta().Palo);

Console.WriteLine("MEZCLANDO...");
baraja.Barajar();

Console.WriteLine("CARTAS BARAJADAS");
baraja.CartasMonton();

Console.WriteLine("CARTAS DISPONIBLES");
Console.WriteLine(baraja.CartasDisponibles());

Console.WriteLine("MOSTRAR BARAJA");
baraja.MostrarBaraja();
*/

/*
Console.WriteLine(baraja.SiguienteCarta().Palo);

baraja.CartasPorBarajar.Remove(carta1);

Console.WriteLine(baraja.SiguienteCarta().Palo);
*/

baraja.DarCartas(2);


