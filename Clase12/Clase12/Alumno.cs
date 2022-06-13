using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    internal class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int DNI { get; set; }
        public List<int> Calificaciones { get; set; }

        public void CargarCalificacion(int calificacion, DateTime fecha)
        {
            Calificaciones.Add(calificacion);
            //Muestro la fecha con un formato.
            Console.WriteLine(fecha.ToString("dddd dd-MM-yy HH:mm") + $" Se asignó la calificación {calificacion} al {Legajo}");
        }

        //Sobrecarga
        public void CargarCalificacion(int calificacion)
        {
            Calificaciones.Add(calificacion);
            var fecha = DateTime.Now;
            Console.WriteLine(fecha.ToString("dddd dd-MM-yy HH:mm") + $" Se asignó la calificación {calificacion} al {Legajo}");
        }

    
        public decimal getPromedio()
        {
            decimal acumulador = 0;
            foreach(var calificacion in Calificaciones)
            {
                acumulador += calificacion;
            }

            decimal promedio = acumulador / Calificaciones.Count();

            return promedio;
        }
    }
}



//¿Es posible tener 2 funciones con el mismo nombre? Sobrecarga.
