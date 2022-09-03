using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class StateViewModel
    {

        public int Id { get; set; }

        /* {0} se reemplaza por País del Name. El campo País es obligatorio */
        [Required(ErrorMessage = "El campo {0} es Requerido")]
        [Display(Name = "Departamento/Estado")]
        /* {0} país     {1} caracteres */
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener Máximo {1} caracteres")]

        public string Name { get; set; }

        public int CountryId { get; set; }
    }
}
