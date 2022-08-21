using Clase20.Clases;

var p = new Persona //Constructor sin parámetros.
{
    Apellido = "Salvucci",
    Nombre = "Julián"
};

var p2 = new Persona("Julián","Salvucci"); //Constructor sobrecargado.



var miArray = new int[] { 1, 2, 3, 4, 5 };


//Objeto anónimo.
//Puedo crear un objeto random con lo que se me de la gana.
var auto = new
{
    p2.Nombre,
    Marca = "Ford",
    Modelo = "Toyota",
    Edad = 23
};

//Expresiones Lamda

int[] numeros = new int[] { 1, 2, 3, 4, 5 };

int numerosImpares = numeros.Count(n => n % 2 == 1);
Console.WriteLine(numerosImpares);
Console.WriteLine(auto);

