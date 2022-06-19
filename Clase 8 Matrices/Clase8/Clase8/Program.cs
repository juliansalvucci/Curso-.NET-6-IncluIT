// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Ingrese las notas");

int[] notas = new int[5];

for(int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Notas del alumno N° {i + 1}: ");
    notas[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"La nota del alumno N° {i + 1}: {notas[i]}");
}
Console.WriteLine("Ingrese las notas");

int[] notas = new int[5];

for(int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Notas del alumno N° {i + 1}: ");
    notas[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"La nota del alumno N° {i + 1}: {notas[i]}");
}
*/

//¿Cuál es la diferencia entre un vector y una matriz?

Console.WriteLine("Ingrese las notas de los exámenes");

Console.WriteLine("Ingrese la cantidad de alumnos");

int cantidadAlumnos = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de notas por alumnos");

int cantidadNotas = int.Parse(Console.ReadLine());

int[,] notas = new int[cantidadNotas,cantidadAlumnos];   

int[] prueba = new int[5];

//Obtener dimensión de matriz.
int lengthFilas= notas.GetUpperBound(0)+1;
int lengthColumnas = notas.GetUpperBound(1)+1;

//¿De que forma recorremos una matriz?. Con un for anidado.


//
for (int columnas = 0; columnas < lengthColumnas; columnas++)
{
    Console.WriteLine($"Notas del alumno N°: {columnas + 1}: ");

    for(int filas = 0; filas < lengthFilas; filas++)
    {
        Console.WriteLine($"Cargue la nota N° {filas +1}: ");
        notas[filas,columnas] = int.Parse(Console.ReadLine());
    }
}

for (int columnas = 0; columnas < lengthColumnas; columnas++)
{
    Console.WriteLine("======================================");
    Console.WriteLine($"Notas del alumno N°: {columnas + 1}: ");

    for (int filas = 0; filas < lengthFilas; filas++)
    {
        Console.Write($"la nota N° {filas + 1}: ");
        Console.WriteLine(notas[filas,columnas]);
    }
}