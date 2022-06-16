using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Modelo
{
    public abstract class Persona //Clase que no puede ser instanciada directamente, sino mediante sus hijos.
    {
        private DateTime _fechaNacimiento; //Encapsulamiento de fecha mediante campo.
        private int _nroDocumento;
        public string Nombre { get; set; }
        public string Apellido  { get; set; }

        public string FechaNacimiento  { //la muestro como un string
            get
            {
                return _fechaNacimiento.ToString("dd/MM/yyyy");
            }
            set
            {
                _fechaNacimiento = Convert.ToDateTime(value);
            }
        }

        public string NroDocumento
        {
            get
            {
                return _nroDocumento.ToString();
            }
            set
            {

                var sePuedeConvertir = int.TryParse(value, out _nroDocumento);

                //Prueba si el string que recibe se puede convertir a int
                //El out o salida se guardar en el campo _numeroDocumento

                if (!sePuedeConvertir)  //Si no puedo convertir el posible doc a int, entonces lo seteo en 0 para que no sea nulo.
                {
                    _nroDocumento = 0;
                }
            }
        }

        public int obtenerEdad()
        {
            var fechaHoraActual = DateTime.Today;

            var edad = fechaHoraActual - _fechaNacimiento;
            //Timespan refiere a un intervalo de tiempo.

            return (int)edad.TotalDays / 365;
        }
    }
}

//¿Para que usamos el modificador de acceso private?