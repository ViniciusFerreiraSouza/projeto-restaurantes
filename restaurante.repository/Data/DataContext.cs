using Microsoft.EntityFrameworkCore;
using restaurante.domain;

namespace restaurante.repository.Data
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