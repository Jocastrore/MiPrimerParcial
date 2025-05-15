using System.ComponentModel.DataAnnotations;

namespace MiPrimerParcial.DAL.Entities
{
    public class Country : AuditBase
    {
        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo de {1} caracter")]
        [Display(Name = "Pais")]
        public string Name { get; set; }
    }
}
