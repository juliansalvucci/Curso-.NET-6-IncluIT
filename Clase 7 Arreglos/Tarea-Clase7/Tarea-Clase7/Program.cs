//Definir arreglo de 10 posiciones.
int[] numeros = new int[10];

//Completar arreglo.
Console.WriteLine("Ingrese los valores");
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}

//Sumar todos los números.
double suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}

//Obtener el valor mayor.
int valorMayor = numeros[0];
for (int i = 0; i < numeros.Length; i++)
{
    if (valorMayor < numeros[i])
    {
        valorMayor = numeros[i];
    }
}

//Obtener el valor menor.
int valorMenor = numeros[0];
for (int i = 0; i < numeros.Length; i++)
{
    if (valorMenor > numeros[i])
    {
        valorMenor = numeros[i];
    }
}


//Mostrar número ingresados.
Console.WriteLine("Elementos ingresados");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

//Calcular promedio.
double promedio = (suma / numeros.Length);

//Mostrar resultados.
Console.WriteLine("");
Console.WriteLine($"Suma total = {suma}");
Console.WriteLine($"Promedio = {promedio}");
Console.WriteLine($"Mayor valor = {valorMayor}");
Console.WriteLine($"Menor valor = {valorMenor}");
