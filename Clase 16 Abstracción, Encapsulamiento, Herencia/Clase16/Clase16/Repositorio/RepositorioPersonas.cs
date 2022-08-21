﻿using Clase16.Interfaces;
using Clase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Repositorio
{
    public class RepositorioPersonas : IRepository<Persona>
    {
        //Usamos un diccionario para guardar las personas.
        public Dictionary<string, Persona> Personas { get; set; }

        public RepositorioPersonas()
        {
            Personas = new Dictionary<string, Persona>();
        }

        public void Insertar(Persona persona)
        {
            var numeroDocumento = persona.NumeroDeDocumento;

            var personaExiste = Personas.ContainsKey(numeroDocumento);
            if (!personaExiste)
            {
                Personas[numeroDocumento] = persona;
            }
        }

        public void Eliminar(string numeroDocumento)
        {
            Personas[numeroDocumento] = null;
        }

        public void Actualizar(Persona persona)
        {
            var personaAActualizar = Personas[persona.NumeroDeDocumento];

            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = persona.Nombre;
                personaAActualizar.Apellido = persona.Apellido;
                personaAActualizar.FechaNacimiento = persona.FechaNacimiento;
            }
        }

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {
            var personaAActualizar = Personas[numeroDocumento];

            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = nombre;
                personaAActualizar.Apellido = apellido;
            }
        }

        public bool Existe(string numeroDeDocumento)
        {
            return Personas.ContainsKey(numeroDeDocumento);
        }

        public bool Existe(Persona persona)
        {
            return Existe(persona.NumeroDeDocumento);
        }
    }
}

//¿En los diccionarios puedo usar cualquier tipo de dato como clave? 44:00


