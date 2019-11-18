using Microsoft.EntityFrameworkCore;

namespace restaurante.repository.Data
{
    public class DataContext
    {
        public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base (options)
        {
        }

        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
        
    }
    }
}