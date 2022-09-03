using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class State
    {
        public int Id { get; set; }

        /* {0} se reemplaza por País del Name. El campo País es obligatorio */
        [Required(ErrorMessage = "El campo {0} es Requerido")]
        [Display(Name = "Departamento/Estado")]
        /* {0} país     {1} caracteres */
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener Máximo {1} caracteres")]

        public string Name { get; set; }

        public Country Country { get; set; }

        public ICollection<City> Cities  { get; set; }

        [Display(Name = "Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

    }
}
