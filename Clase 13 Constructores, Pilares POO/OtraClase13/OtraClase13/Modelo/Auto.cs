using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtraClase13.Modelo
{
    internal class Auto
    {
        //Campos: Sirven para contener la información de forma protegida.
        private string _tipoDeMotor;
        private string _anioFabricacion;


        public string TipoMotor 
        {
            get { return _tipoDeMotor; }
            set
            {
                if(value == null || value == "")
                {
                    _tipoDeMotor = "nafta";
                }
                else
                {
                    _tipoDeMotor = value;
                }
            }
        } 
        public bool EstaEncendido { get; set; } //Propiedad autoimplementada
        public string AnioFabricacion 
        { 
            get { return _anioFabricacion; }
            set { _anioFabricacion = value; }
        }
        public string Marca { get; set; }
    }
}

//¿Qué sucede si no defino el cuerpo de un get y un set para una propiedad?
