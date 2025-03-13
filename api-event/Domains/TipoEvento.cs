using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_event.Domains
{
    [Table("TipoEvento")]
    public class TipoEvento
    {
        [Key]
        public Guid TipoEventoId { get; set; }



        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do tipo do evento é obrigatório")]
        public string? TituloTipoEvento { get; set; }


       
    }
}
