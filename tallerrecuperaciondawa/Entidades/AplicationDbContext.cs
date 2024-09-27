using Microsoft.EntityFrameworkCore;

namespace tallerrecuperaciondawa.Entidades
{
    public class AplicationDbContext : DbContext
    {/*  

        public AplicationDbContext(DbContextOptions options) : base(options)
        {
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=tallerdawa;Integrated Security=True; TrustServerCertificate=True;");
        }


        public DbSet<Usuario> Usuarios { get; set; }
    }
}
