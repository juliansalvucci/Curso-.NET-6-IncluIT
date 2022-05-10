
int contador = 0;
string respuesta = "S";

while (respuesta.ToUpper() != "N")
{
    contador++;
    Console.WriteLine("N° vuelta: " + contador);

    Console.WriteLine("¿Quiere seguir? (S/N)");
    respuesta = Console.ReadLine();
}

for (int cantCaramelos = 0; cantCaramelos < 12; cantCaramelos++)
{
    Console.WriteLine($"Mi bolsa tiene {cantCaramelos} Caramelos");
    //El incremento lo hace al finalizar la ejecución.
}

int cantidadCaramelos = 0;
while(cantidadCaramelos < 12)
{
    Console.WriteLine("Mi bolsa tiene " + cantidadCaramelos + "caramelos");
    cantidadCaramelos++;
}