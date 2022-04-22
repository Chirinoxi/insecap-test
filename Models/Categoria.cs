using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGC.Models
{
    [Table("Categoria")]

    public class Categoria
    {
        [Key]
        public int idCategoria { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre categoria")]
        public string nombre { get; set; }

    }
}