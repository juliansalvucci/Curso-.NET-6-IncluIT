
using Cuadrilateros.Modelos;

Console.WriteLine("Ingrese coordenadaX");
var coordenadaX = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese coordenadaY");
var coordenadaY = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese altura");
var h = int.Parse(Console.ReadLine());

var cuadrado = new Cuadrado(coordenadaX,coordenadaY);
var areaCuadrado = cuadrado.CalcularArea();
Console.WriteLine($"Area de cuadrado: {areaCuadrado}");

var rectangulo = new Rectangulo(coordenadaX, coordenadaY);
var areaRectangulo = rectangulo.CalcularArea();
Console.WriteLine($"Area de rectángulo: {areaRectangulo}");

var trapecio = new Trapecio(coordenadaX, coordenadaY, h);
var areaTrapecio = trapecio.CalcularArea();
Console.WriteLine($"Area de trapecio: {areaTrapecio}");

