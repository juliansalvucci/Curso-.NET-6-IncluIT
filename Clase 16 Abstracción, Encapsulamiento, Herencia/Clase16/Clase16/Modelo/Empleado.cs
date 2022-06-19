using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Modelo
{
    public sealed class Empleado : Persona
    {
        private int _salarioBruto;

        public int SalarioBruto 
        { 
            set => _salarioBruto = value;
        }

        public int SalarioNeto 
        {
            get => getSalario();
        }

        private int getSalario()
        {
            var salarioNeto = _salarioBruto*0.85;
            return (int)salarioNeto;
        }
    }
}
