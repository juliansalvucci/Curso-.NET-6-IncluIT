//Generar número aleatorio del 1 al 21.
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

//Definir variables.

int numeroIngresado = 0;
int intentos = 0;

//Si ambos número son diferentes, repetir intento.
while(numeroIngresado != numeroSecreto)
{
    //Ingreso de valor por teclado.
    Console.WriteLine("Ingrese número");
    numeroIngresado = int.Parse(Console.ReadLine());
   
    //Contador de intentos.
    intentos++;

    if (numeroIngresado > numeroSecreto)
    {
        Console.WriteLine("Número ingresado demasiado grande, intente nuevamente");
    }
    else 
    {
        Console.WriteLine("Número demasiado pequeño, intente nuevamente");
    }

    if(numeroIngresado == numeroSecreto)
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto} Lo has logrado en {intentos} intentos!!");
    }
}



