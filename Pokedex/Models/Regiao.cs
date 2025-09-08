using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{   
    
    [Table("Tipo")]
    public class Regiao
    {
        [Key]
        public uint Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Por favor, informe on nome")]
        public string Nome { get; set; }
    }
}