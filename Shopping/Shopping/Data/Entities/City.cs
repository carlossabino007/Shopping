using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class City
    {

        public int Id { get; set; }

        /* {0} se reemplaza por País del Name. El campo Ciudad es obligatorio */
        [Required(ErrorMessage = "El campo {0} es Requerido")]
        [Display(Name = "Ciudad")]
        /* {0} país     {1} caracteres */
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener Máximo {1} caracteres")]

        public string Name { get; set; }

        public State State { get; set; }


    }
}
