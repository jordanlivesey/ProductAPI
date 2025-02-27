using Microsoft.EntityFrameworkCore;
using Products_EF.Entites;

namespace Products_EF.Contexts
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new Configurations.ProductsConfiguration());
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
