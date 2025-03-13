using api_event.Domains;
using Microsoft.EntityFrameworkCore;

namespace api_event.Context
{
    public class EventContext : DbContext
    {


        public EventContext() { }

        public EventContext(DbContextOptions<EventContext> options) : base(options)
        {
        }


        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Evento> Evento { get; set; }

        public DbSet<Instituicao> Instiuicao { get; set; }

        public DbSet<PresencaEvento> PresencaEventos { get; set; }

        public DbSet<TipoEvento> TipoEvento { get; set; }

        public DbSet<ComentarioEvento> ComentarioEvento { get; set; }

        public DbSet<TipoUsuario> TipoUsuario { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE12-S28\\SQLEXPRESS; DataBase=EventPlus; User Id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
            }

        }
    }
}
