namespace Clase11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia 1
            Perro Firulais = new Perro(); //Creo una instancia de la clase perro llamada firulais.
            Firulais.Color = "Negro";
            Firulais.Edad = 4;
            Firulais.Tamanio = "Grande";
            Firulais.Raza = "Mastín napolitano";

            //Instancia 2
            var Fatiga= new Perro();
            Fatiga.Color = "Blanco";
            Fatiga.Edad = 2;
            Fatiga.Tamanio = "Chico";
            Fatiga.Raza = "Pequinés";

            //Instancia 3
            var Cartucho = new Perro();
            Cartucho.Color = "Negro";
            Cartucho.Edad = 3;
            Cartucho.Tamanio = "Mediano";
            Cartucho.Raza = "Chow-Chow";


            //Creo una lista de perros.
            var ListaPerros = new List<Perro>();

            ListaPerros.Add(Firulais);
            ListaPerros.Add(Fatiga);
            ListaPerros.Add(Cartucho);



            //Recorro la lista y por cada pichicho muetro la raza.

            Console.WriteLine($"Hay {ListaPerros.Count()} Perritos");

            foreach(var item in ListaPerros)
            {
                Console.WriteLine(item.Raza.ToUpper());
                item.Ladrar();
            }

            
        }
    }
}

//¿Cuáles son las 3 secuencias lógicas que plantea la progranación estructurada?
//secuencia.
//selección.
//iteración.

//¿Cuál es la diferencia entre instancia y clase?