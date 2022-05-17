//string[] cars = { "Ford", "Fiat","Renault","Peugeot" };

//¿Cuál es el primer elemento de una matriz? 0
//¿Siempre debo inicializarlas o puedo asignarle valores leugo? Si
//Console.WriteLine(cars[0]);

//string[] frutas = new string[4];

//frutas[0] = "Pera";
//frutas[1] = "Manzana";
//frutas[2] = "Kiwi";
//frutas[3] = "Naranja";

//Console.WriteLine(frutas[0]);

int[] numeros = new int[5];

//Ciclo for para asignar valores al array.
for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el número: {i+1}");
    numeros[i] = int.Parse(Console.ReadLine());
}

//Ciclo for para mostrar valores.
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento: {numeros[i]}");
}

//Sumar todos los valores ingresados por el usuario.
int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}

Console.WriteLine($"Sumatoria total es: {suma}");

//Diferencia entre acumulador y contador.