using Almacen.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Almacen.API.Data
    
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        public DbSet<Producto>Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Producto>().HasIndex(p => p.Name).IsUnique();
        }

            
        
        
        
        
            
        

    }
}
