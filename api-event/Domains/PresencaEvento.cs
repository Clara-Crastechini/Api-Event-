using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_event.Domains
{
    [Table("PresencaEvento")]
    [Index(nameof(Situacao), IsUnique = true)]
    public class PresencaEvento
    {
        [Key]
        public Guid PresencaEventoId { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public bool? Situacao { get; set; }



        [Required(ErrorMessage = "Usuario Obrigatorio")]
        public Guid UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }


        [Required(ErrorMessage = "Evento Obrigatorio")]
        public Guid EventoId { get; set; }
        [ForeignKey("EventoId")]
        public Evento? Evento { get; set; }
    }
}
