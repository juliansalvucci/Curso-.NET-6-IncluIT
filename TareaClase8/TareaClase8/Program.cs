Console.WriteLine("Ingrese la cantidad de filas");

int nroFilas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de columnas");

int nroColumnas = int.Parse(Console.ReadLine());

//Matríz de numeros.
int[,] numeros = new int[nroFilas, nroColumnas];

//Matriz unidimensional o Vector de promedios.
double[] promedios = new double[nroColumnas];

//Definición de dimensiones de la matriz bidimensional para utilizar en los ciclos.
int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;

//Ciclo para cargar datos en matriz.
for (int columnas = 0; columnas < lengthColumnas; columnas++)
{
    for (int filas = 0; filas < lengthFilas; filas++)
    {
        Console.WriteLine($"Cargue el valor {filas + 1}: ");
        numeros[filas, columnas] = int.Parse(Console.ReadLine());
    }
}

//Ciclo para mostrar datos de la matriz.
for (int columnas = 0; columnas < lengthColumnas; columnas++)
{ 
    for (int filas = 0; filas < lengthFilas; filas++)
    {
        Console.Write(numeros[filas, columnas]);
    }
}

int suma = 0;

for (int columnas = 0; columnas < lengthColumnas; columnas++)
{
    for (int filas = 0; filas < lengthFilas; filas++)
    {
        suma = suma + numeros[filas, columnas];
    }
    Console.Write(suma);
}



