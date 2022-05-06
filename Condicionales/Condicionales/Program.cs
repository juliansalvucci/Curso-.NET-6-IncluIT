// Ejemplo de condicional IF

////Cartel,
//Console.WriteLine("Ingrese su edad: ");

////Ingresar valor por teclado,
//int edad = int.Parse(Console.ReadLine());

////Ingrese equipo de futbol.
//Console.WriteLine("Ingrese su edad: ");
//string equipo = Console.ReadLine();

//Console.WriteLine("La edad es: " + edad);

//if(edad >= 18 && equipo == "River")
//{
//    Console.WriteLine("Es mayor de edad");
//}
//else
//{
//    Console.WriteLine("Es menor de edad");
//}

//// && AND
//// || OR
//// == IGUALDAD
//// != DIFERENTE


////Ejemplo else if.

//if(edad < 0 || edad > 100)
//{
//    Console.WriteLine("Edad inválida");
//}
//else if(edad > 6 && edad < 12)
//{
//    Console.WriteLine("va a la primaria");
//}
//else if(edad < 18)
//{
//    Console.WriteLine("va al secundario");
//}
//else if(edad < 28)
//{
//    Console.WriteLine("va a la facultad");
//}
//else
//{
//    Console.WriteLine("Trabajando");
//}


//Ejemplo switch

Console.WriteLine("Ingrese los valores");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine("1-suma");
Console.WriteLine("2-resta");
Console.WriteLine("3-multiplicación");
Console.WriteLine("4-división");

Console.WriteLine("Ingrese operación");

string operacion = Console.ReadLine();

int resultado;

switch (operacion)
{
    case "1":
        Console.WriteLine("sumando");
        resultado = a + b;
        break;
    case "2":
        Console.WriteLine("Restando");
        resultado = a - b;
        break;
    case "3":
        Console.WriteLine("Multiplicando");
        resultado = a * b;
        break;
    case "4" when b > 0:  //solo si el divisor es mayor a 0.
        Console.WriteLine("Dividiendo");
        resultado = a / b;
        break;
    default:
        Console.WriteLine("Valor inválido");
        break;
}