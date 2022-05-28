
Console.WriteLine("Ingrese tamaño del vector");

int tamanio = int.Parse(Console.ReadLine());

int[] vector = new int[tamanio];


//Completar posiciones del vector con valores aleatorios.
for(int i = 0; i < vector.Length; i++)
{
    vector[i] = new Random().Next();
}

//Mostrar por consola el vector completado.
Console.WriteLine();    
Console.WriteLine("================== VECTOR ====================");
Console.WriteLine();
for(int i = 0; i < vector.Length; i++)
{
    Console.WriteLine(vector[i]);
}

Console.WriteLine();
Console.WriteLine("============= VECTOR INVERTIDO ===============");
Console.WriteLine();
//Mostrar por consola el vector invertido.
for (int i = vector.Length-1; i >= 0; i--)
{
    Console.WriteLine(vector[i]);
}
