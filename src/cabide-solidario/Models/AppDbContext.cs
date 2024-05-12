using Microsoft.EntityFrameworkCore;

namespace cabide_solidario.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<RoupaDoada> RoupasDoadas { get; set;}

        public DbSet<Candidato> Candidatos { get; set;}

        public DbSet<Usuario> Usuarios { get; set;}

        public DbSet<Parceiro> Parceiros { get; set; }

    }
}
