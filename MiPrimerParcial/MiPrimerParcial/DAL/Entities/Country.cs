using System.ComponentModel.DataAnnotations;

namespace MiPrimerParcial.DAL.Entities
{
    public class Country : AuditBase
    {
        [Display(Name = "Pais")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo de {1} caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }
    }
}
