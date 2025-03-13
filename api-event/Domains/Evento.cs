using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_event.Domains
{
    [Table("Evento")]
    public class Evento
    {
        [Key]

        public Guid EventoId { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do evento é obrigatório")]
        public string? NomeEvento { get; set;}


        [Column(TypeName = "DATATIME")]
        [Required(ErrorMessage = "A data é obrigatório")]
        public DateTime DataEvento { get; set;}


        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrição é obrigatório")]
        public string? DescricaoEvento { get; set;}


        public Guid TipoEventoId {  get; set; }
        [ForeignKey("TipoEventoId")]
        public TipoEvento? TipoEvento { get; set;}


        public Guid InstituicaoId { get; set; }
        [ForeignKey("Instituicao")]
        public Instituicao? Instituicao { get; set;}

        public PresencaEvento? PresencaEvento { get; set;}
    }
}
