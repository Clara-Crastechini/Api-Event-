using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_event.Domains
{
    [Table("Usuario")]
    [Index(nameof(EmailUsuario), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid UsuarioId { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do usuario é obrigatório")]
        public string? NomeUsuario { get; set; }



        [Column(TypeName = "VARCHAR(120")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string? EmailUsuario { get; set; }


        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A senha é obrigatório")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "a senha deve ter entre 5 e 30 caracteres")]
        public string? SenhaUsuario { get; set; }



        [Required(ErrorMessage = "Usuario Obrigatorio")]
        public Guid TipoUsuarioId { get; set; }
        [ForeignKey("TipoUsuarioId")]
        public TipoUsuario? TiposUsuario { get; set; }


    }
    
}
