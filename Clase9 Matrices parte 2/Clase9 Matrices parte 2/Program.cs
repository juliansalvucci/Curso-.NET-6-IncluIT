// Array de n nros aleatorios.
//Insertar un valor en una determinada posición.
/*
Console.WriteLine("Ingrese el tamaño deseado para e listado");

//Cantidad de datos que va a tener el array.
int n = int.Parse(Console.ReadLine());

int[] vector = new int[n];

Random aleatorizador = new Random();

for (int i = 0; i < n; i++)
{
    vector[i] = aleatorizador.Next(100); //Next() devuelve un número entero positivo aleatorio, Max 100.
}

int contador = 0;

//Por cada elemento.
foreach (int i in vector)
{
    contador++;
    Console.WriteLine(contador + " : " + i);
}

Console.WriteLine();
Console.WriteLine("Ingrese posición a modificar: ");

int posicionAModificar = int.Parse(Console.ReadLine());

if(posicionAModificar > vector.Length || posicionAModificar < 0)
{
    Console.WriteLine("Índice incorrecto");
}
else
{
    Console.WriteLine("Ingrese nuevo valor");
    vector[posicionAModificar - 1] = int.Parse(Console.ReadLine());

    //Por cada elemento.
    foreach (int i in vector)
    {
        contador++;
        Console.WriteLine(contador + " : " + i);
    }
}
*/

int[] primos = new int[100];

int posicion = 0;
int aux = 0;
int numero = 1;

while(posicion < primos.Length)
{
    aux = 0;
    for(int i = 1; i <= numero; i++)
    {
        if(numero % i == 0) {
            aux++;
        }
    }
    if (aux == 2) //Indica que el número tiene 2 divisores, el 1 y si mismo.
    {
        primos[posicion] = numero;
        posicion++;
    }
    numero++;
}

foreach (int i in primos)
{
    Console.WriteLine(i);   
}

Console.ReadKey();

//¿Cómo le determinado el tipo de datos a las listas? entre comillas angulares <>.