using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIG3.APIG3.Modelo
{
    public class Depto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }


    }
}
