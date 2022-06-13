using Clase_13___Objetos___Constructores__Pilares_POO;
using Clase_13___Objetos___Constructores__Pilares_POO.Modelo;

Persona p1 = new Persona()
{
    NombreCompleto = "Salvucci Julián",
    NumeroDocumento = "4363790",
    Edad = 40,
    EstaCasado = true
};

Console.WriteLine(p1.saludar());
Console.WriteLine(p1.saludar("Daniela"));



Ocupacion o1 = new Ocupacion();

//Instancio una persona mediante el constructor con parámetros para inicializar los atributos.
Persona p2 = new Persona("Salvucci Julián", "4363789",40,true);
