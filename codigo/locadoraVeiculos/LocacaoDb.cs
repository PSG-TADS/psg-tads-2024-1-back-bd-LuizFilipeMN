using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace locadoraVeiculos
{
    public class LocacaoDb : DbContext
    {
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Reserva> Reserva { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ORN;Trusted_Connection=True;TrustServerCertificate=true;");
        }

    }
}