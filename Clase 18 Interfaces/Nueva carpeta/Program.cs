/* Instrucciones de nivel superior, son las primeras en ejecutarse en el programa.


¿Las interfaces tiene capacidad de herencia múltiple de otras interfaces? SI.
¿ la herencia sirver para reutilizar el codigo ?

var Quilmes = new Cerveza();

public interface IBebida
{
    decimal Volumen { get; set; }
    bool Gasificada {get; set;}
    string color { get; set; }
    decimal Calorias { get; set; }

}

public interface IBebidaAlcoholica : IBebida
{
    decimal Graduacion { get; set; }
}

public interface ICerveza : IBebidaAlcoholica
{
    int IBU { get; set; }
}

public class Gaseosa : IBebida
{
    public decimal Volumen { get; set; }
    public bool Gasificada { get; set; }
    public string color { get; set; }
    public decimal Calorias { get; set; }
}

public class Cerveza : ICerveza
{
    public int IBU { get; set; }
    public decimal Graduacion { get; set; }
    public decimal Volumen { get; set; }
    public bool Gasificada { get; set; }
    public string color { get; set; }
    public decimal Calorias { get; set; }
}
*/
using name;
internal class Program
{
    private static void Main(string[] args)
    {
        var alumno = new Alumno(){
            Nombre = "Juan",
            Apellido = "Perez",
            DNI = "12345678",
            Legajo = "123"
        };

        var docente = new Docente(){
            Nombre = "Juan",
            Apellido = "Perez",
            DNI = "12345678",
            Horas = 10
        };
        
        System.Console.WriteLine(ObtenerDatos(alumno));
  
        var listado = new List<IPersona>();
        listado.Add(alumno);
        listado.Add(docente);

        var nuevoListado = ObtenerPersonasByNombre(listado, "Juan");


        List<IPersona> ObtenerPersonasByNombre(List<IPersona> personas, string nombre)
        {
            var nuevaLista = new List<IPersona>();
            foreach (var persona in personas)
            {
                if (persona.Nombre == nombre)
                {
                    nuevaLista.Add(persona);
                }
            }
            return nuevaLista;

        }
        
        

        string ObtenerDatos(IPersona persona)
        {
            return $"{persona.Nombre} {persona.Apellido} {persona.DNI}";
        }
    }
}