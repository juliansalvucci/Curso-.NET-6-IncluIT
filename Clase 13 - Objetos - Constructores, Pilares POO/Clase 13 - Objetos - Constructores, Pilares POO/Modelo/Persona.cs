using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13___Objetos___Constructores__Pilares_POO 
{
    internal class Persona
    {
        public string NombreCompleto { get; set; }

        public string NumeroDocumento { get; set; }

        public int Edad { get; set; }

        public bool EstaCasado { get; set; }

        //Constructor sin parámetros.
        public Persona()
        {
            Console.WriteLine("Se ha instanciado una nueva persona");
        }

        //Constructor con parámetros.
        public Persona(string nombreCompleto, string numeroDocumento, int edad, bool estaCasado)
        {
            NombreCompleto = nombreCompleto;
            NumeroDocumento = numeroDocumento;
            Edad = edad;
            EstaCasado = estaCasado;
        }

        public string saludar()
        {
            return $"Hola Soy {NombreCompleto}";
        }

        public string saludar(string nombrePersonaAQuienSaludar)
        {
            return $"Hola {nombrePersonaAQuienSaludar}, soy {NombreCompleto}";
        }
    }
}

//¿Es necesario inicializar todos lo atributos en el método construtor?
//​Es necesario inicializar todos los atributos de la clase en el método constructor
