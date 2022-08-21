
using Clase21;

int[] numeros = new int[] { 1, 2, 3, 4, 5 };

int numerosImpares = numeros.Count(n => n % 2 == 1);
Console.WriteLine(numerosImpares);

//IEnumerable: tiene los métodos necesarios para iterar de inicio a fin.
// I, indica que es una interface.
//Terminación "able" me indica que puede hacer.

var misClientes = new List<Cliente>();

misClientes.Add(new Cliente { Nombre = "Juan", Apellido="Perez" });
misClientes.Add(new Cliente { Nombre = "Juan", Apellido="Aerez" });

IEnumerable<Cliente> juanes = misClientes.Where(cadaCliente => cadaCliente.Nombre == "Juan");

foreach (Cliente cliente in juanes)
{
    string n = cliente.Nombre;
    Console.WriteLine(n);
}


//Query expresions

int[] puntajes = new int[] { 91, 22, 300, 45, 15 };

IEnumerable<int> resultados =
    from puntaje in puntajes 
    where puntaje > 80
    orderby puntaje descending
    select puntaje;

foreach (int resultado in resultados)
{
    Console.WriteLine(resultado);
}

IEnumerable<Cliente> resultados2 =
    from Cliente in misClientes
    where Cliente.Nombre == "Juan"
    orderby Cliente.Nombre descending
    select Cliente;

var resultados3 =
    from cliente in misClientes
    where cliente.Nombre == "Juan"
    orderby cliente.Nombre descending
    select new { cliente.Nombre };

foreach(var cliente in resultados3)
{
    Console.WriteLine(cliente);
}

//¿Cuál es la interface más común que devuelve los métodos de linq al devolver multiples resultados? IEnumerable
//¿Qué es un tipo anónimo?