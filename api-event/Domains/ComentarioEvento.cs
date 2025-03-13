using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_event.Domains
{
    [Table("ComentarioEvento")]
    [Index(nameof(Exibe), IsUnique =true)]
    public class ComentarioEvento
    {
        [Key]
        public Guid ComentarioEventoId  { get; set; }

        [Column(TypeName = "Text")]
        [Required(ErrorMessage = "A descrição é obrigatório")]
        public string? Comentario {  get; set; }



        [Column(TypeName = "Bit")]
        [Required(ErrorMessage = "A resposta é necessario")]
        public bool? Exibe { get; set; }



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
