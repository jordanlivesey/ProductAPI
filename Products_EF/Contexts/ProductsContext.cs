using Microsoft.EntityFrameworkCore;
using Products_EF.Entites;

namespace Products_EF.Contexts
{
    public class ProductsContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new Configurations.ProductsConfiguration());
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
