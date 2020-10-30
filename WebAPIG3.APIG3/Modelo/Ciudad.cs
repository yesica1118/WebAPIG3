using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIG3.APIG3.Modelo
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        public int DeptoID { get; set; }

        public Depto Depto { get; set; }

        public ICollection<Persona> Personas { get; set; }

    }
}
