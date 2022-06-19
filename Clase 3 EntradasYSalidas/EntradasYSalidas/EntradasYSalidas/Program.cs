/*

//Borra el contenido de la consola.
Console.Clear();

//Mostrar por consola.
Console.WriteLine("Hola, Ingrese su nombre: ");

//Ingresar dato por consola.
string nombre = Console.ReadLine();

//Mostrar mensaje
Console.WriteLine("Hola " + nombre + ", Este es mi segundo programa");

Console.WriteLine("Presione una tecla para finalizar");
Console.ReadKey();

*/

Console.Clear();

Console.WriteLine("Programa para calcular superficie de rectángulo");
Console.WriteLine();

Console.WriteLine("Ingrese la base del rectángulo");
double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectángulo");
double alturaRectangulo = double.Parse(Console.ReadLine());


double superficieRectangulo = baseRectangulo * alturaRectangulo;

Console.WriteLine("La superficie es: " + superficieRectangulo);

bool esMayorADiez = superficieRectangulo > 10;

if (esMayorADiez)
{
    Console.WriteLine("Superficie mayor a 10");
}
else
{
    Console.WriteLine("Superficie menor a 10");
}

Console.ReadKey();