using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIG3.APIG3.Modelo
{
    public class Persona
    {
    [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(45)]
        public String Documento { get; set; }

        [Required]
        [StringLength(45)]
        public String Nombres { get; set; }
        
        [StringLength(45)]
        [Display(Name = "Direccion")]
        public String Direccion { get; set; }

        public int CiudadId { get; set; }

       
        [StringLength(45)]
        public String Email { get; set; }

        
        [StringLength(45)]
        [Display(Name = "Telefono")]
        public String Telefono { get; set; }

      
        
        [Display (Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}" , ApplyFormatInEditMode = true)]
        public DateTime Fechanac { get; set; }

        public Ciudad Ciudad { get; set; }
    }
}
