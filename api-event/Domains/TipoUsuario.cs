using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_event.Domains
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {

        [Key]
        public Guid TipoUsuarioId {get; set;}

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O tipo de usuario é obrigatório")]
        public string? TituloTipoUsuario {get; set;}
    }
}
