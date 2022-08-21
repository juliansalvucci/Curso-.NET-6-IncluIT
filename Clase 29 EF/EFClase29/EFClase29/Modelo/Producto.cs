using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFClase29.Modelo
{
    public class Producto : EntidadBase
    {
        public int Codigo { get; set; }

        [MaxLength(50)]
        public string Descripcion { get; set; }
        public int Peso { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public Marca Marca { get; set; }
    }
}
