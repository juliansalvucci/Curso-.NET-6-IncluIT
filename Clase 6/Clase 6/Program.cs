//Variable definida de forma explícita.
int numero1;

//Variable definida de forma implécita.
var numero2 = 0;

/*
1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".
*/

/* Alternativa con while.
string opcion = "S"; //Definir la opción como S, para que ingrese al menos una vez al ciclo.

while (opcion.ToUpper() == "S") //Mientras el usuario ingrese S se repetira el item 1.
{
    //Limpiar consola.
    Console.Clear();
    //Solicitar ingresar nombre.
    Console.WriteLine("Ingrese un nombre");
    //Ingresar nombre.
    string nombrePersona = Console.ReadLine();
    //Saludar.
    Console.WriteLine($"¡Hola {nombrePersona}!");
    //Preguntar si desea continuar.
    Console.WriteLine("¿Desea continuar? (S/N)");
    //Ingresar opción.
    opcion = Console.ReadLine();
}
*/

string opcion;

do //Usando do while.
{
    //Limpiar consola.
    Console.Clear();
    //Solicitar ingresar nombre.
    Console.WriteLine("Ingrese un nombre");
    //Ingresar nombre.
    string nombrePersona = Console.ReadLine();
    //Saludar.
    Console.WriteLine($"¡Hola {nombrePersona}!");
    //Preguntar si desea continuar.
    Console.WriteLine("¿Desea continuar? (S/N)");
    //Ingresar opción.
    opcion = Console.ReadLine();
}
while (opcion.ToUpper() == "S");

if (opcion.ToUpper() == "N") //Si el usuario ingresa N, se finaliza el programa.
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    //Notificación en caso de opción inválida.
    Console.WriteLine("Opción no valida");
}





