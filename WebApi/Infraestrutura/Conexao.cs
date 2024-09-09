using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Infraestrutura
{
    public class Conexao : DbContext
    {
        public Conexao(DbContextOptions<Conexao> options) : base(options){}

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cotacoes> Cotacoes { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;Database=postgres" +
            "User Id=postgres;" +
            "Password=Internet*123;"
            );
        */
    }
}
