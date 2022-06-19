// control + c + k
//control rr, cambiar variable en varias lineas.

//var personas = new List<string>();

//personas.Add("persona1");
//personas.Add("persona2");
//personas.Add("persona3");

//foreach(var persona in personas)
//{
//    Console.WriteLine(persona);
//}

var listaNombres = new List<string>();

string entradaUsuario;

do
{
    Console.WriteLine("Bienvenido a lista");
    Console.WriteLine("Selecciona una de las opciones");
    Console.WriteLine("1-Agregar un elemento");
    Console.WriteLine("2-Quitar un elemento");
    Console.WriteLine("3-Ubicar un elemento");
    Console.WriteLine("4-Invertir un elemento");
    Console.WriteLine("5-Ver el contenido de la lista");
    Console.WriteLine("Presiona 0 para salir");

    entradaUsuario = Console.ReadLine();


    switch (entradaUsuario)
    {
        case "1":
            Console.WriteLine("Ingrese el elemento");
            var nuevoElemento = Console.ReadLine();

            Console.WriteLine("¿Dónde desea agregar el elemento?");
            Console.WriteLine("1-Al final");
            Console.WriteLine("2-En una posición");

            var opcionIngresar = Console.ReadLine();
            switch (opcionIngresar)
            {
                case "1":
                    listaNombres.Add(nuevoElemento);
                    break;

                case "2":
                    Console.WriteLine("Ingrese una posición");
                    var posicionArray = int.Parse(Console.ReadLine());
                    listaNombres.Insert(posicionArray, nuevoElemento);
                    break;
            }
            break;

        case "2":
            Console.WriteLine("Ingrese el elemento que desea quitar");
            var elementoARemover = Console.ReadLine();
            listaNombres.Remove(elementoARemover);

            break;

        case "3":
            Console.WriteLine("Ingrese el elemento que desea ubicar");
            var elementoAUbicar = Console.ReadLine();
            var posicion = listaNombres.IndexOf(elementoAUbicar);
            if (posicion >= 0)
            {
                Console.WriteLine($"El elemtno se encuentra en la posición {posicion}");
            }
            else
            {
                Console.WriteLine("El elemento no existe");
            }

            break;

        case "4":
            listaNombres.Reverse();
            Console.WriteLine("La lista se ha invertido");
            break;

        case "5":

            if (listaNombres.Count == 0)
            {
                Console.WriteLine("La lista esta vacía");
            }
            else
            {
                foreach (var item in listaNombres)
                {
                    Console.WriteLine(item);
                }
            }
            break;

    }
}
while (entradaUsuario != "0");

//var pila = new Stack<int>();

//pila.Push(1);
//pila.Push(2);
//pila.Push(3);

//Console.WriteLine(pila.Pop());

////Colas

//var cola = new Queue<int>();

//cola.Enqueue(1);
//cola.Enqueue(2);

//Console.WriteLine(cola.Dequeue());

//¿Qué significa count y capacity en una lista?
//¿Qué son las estructura de datos lifo y fifo? Ejemplo de cada una.

