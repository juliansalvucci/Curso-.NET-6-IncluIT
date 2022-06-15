/*
using Clase15.Modelos;

var miPrimerClase = new MiClase
{
    Id = 1,
    Name = "Julián"
};


Console.WriteLine(miPrimerClase.Name);

var miSegundaClase = miPrimerClase; //Se guarda la referencia a miPrimerClase.  No se crea una nueva clase.

Console.WriteLine(miSegundaClase.Name);

miPrimerClase.Name = "otroNombre";

Console.WriteLine(miPrimerClase.Name);
Console.WriteLine(miSegundaClase.Name);

//Las instancias de clases se asignan por referencia.
*/
//////////////////OTRA PARTE////////////////////////////
/*
using Clase15.Modelos;

var miPrimerClase = new MiClase
{
    Id = 1,
    Name = "Julián"
};

var miSegundaClase = new MiClase
{
    Id = 2,
    Name = "Gato"
};

var miLista = new List<MiClase>();
miLista.Add(miPrimerClase);
miLista.Add(miSegundaClase);

foreach(var miClase in miLista)
{
    Console.WriteLine(miClase.Name);
    if(miClase.Id == 1)
    {
        miClase.Name = "Perro";
    }
}

//¿Si creo una referencia de una instancia y modifico el valor de un taributo de su referencias, que sucede con los atributos de la instancia original?

*/

using Clase15.Modelos;

var primerPersona = new Persona
{
    Apellido = "Salvucci",
    Nombre = "Julián"
};

var primerDocente = new Docente
{
    Nombre = "NDoc",
    Apellido = "ADoc",
    Salario = 70000
};


var primerAlumno = new Alumno
{
    Nombre = "NAlumno",
    Apellido = "AAlumno",
    Legajo = 13456
};

var personas = new List<Persona>();

personas.Add(primerPersona);
personas.Add(primerDocente);
personas.Add(primerAlumno);

foreach(Persona persona in personas)
{
    //Imprimir el salario de una persona si es docente.
    if(persona.GetType() == typeof(Docente)) //Pregun ta si la persona es del tipo docente.
    {
        var docente = (Docente)persona; //Castear clase
        Console.WriteLine(docente.Salario);
    }
}

//¿Qué sucede si intentamos castear un tipo al cuál no hereda?