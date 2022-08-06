using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

            /* {0} se reemplaza por País del Name. El campo País es obligatorio */ 
        [Required(ErrorMessage ="El campo {0} es Requerido")]
        [Display(Name ="País")]
            /* {0} país     {1} caracteres */
        [MaxLength(50, ErrorMessage ="El campo {0} debe tener Máximo {1} caracteres") ]

        public string Name { get; set; }

    }
}
