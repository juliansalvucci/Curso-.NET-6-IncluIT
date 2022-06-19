// Destrctor vacia el espacio de memoria que ocupa el objeto.

using Clase14;

var personas = new List<Persona>();

for(int i = 0; i < 100000000; i++)
{
    var P = new Persona(); //la ultima persona creada queda en el heap, desplazando el resto al stack.
    personas.Add(P);
}
  


//2 Secciones de memoria
//En heap(montón) viven los objetos.
// El garbage colector toma los objetos no referenciados y llama a su destructor.

//Pregunta 1 ¿Qué es el garbage collector?