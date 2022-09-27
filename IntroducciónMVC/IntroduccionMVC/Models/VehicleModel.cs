using System.ComponentModel.DataAnnotations;

namespace IntroduccionMVC.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Dominio { get; set; }
        public string NumeroChasis { get; set; }
        public string Propietario { get; set; }
        public int AnioFabricacion { get; set; }
    }
}
