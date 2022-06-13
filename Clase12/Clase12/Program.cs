using Clase12;

var alumno1 = new Alumno();

alumno1.Apellido = "Mateos";
alumno1.Nombre = "Joaquin";
alumno1.Legajo = 24265;
alumno1.DNI = 23456789;
alumno1.FechaNacimiento = new DateTime(1986, 11, 4);
alumno1.Calificaciones = new List<int>(); //Debo crear la lista para que funcione.


var alumno2 = new Alumno()
{
    Apellido = "apellito",
    Nombre = "nombre",
    Legajo = 1,
    DNI = 45876890,
    FechaNacimiento = new DateTime(1234, 11, 1)
};

alumno1.CargarCalificacion(7,DateTime.Now);
alumno1.CargarCalificacion(3, DateTime.Now);
alumno1.CargarCalificacion(4, DateTime.Now);

Console.WriteLine(alumno1.getPromedio());