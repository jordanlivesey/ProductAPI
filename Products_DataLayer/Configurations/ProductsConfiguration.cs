using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Products_EF.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Entites.Product>
    {
        public void Configure(EntityTypeBuilder<Entites.Product> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName("PK__Products");

            builder.ToTable("Product", "dbo");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Price)
           .IsRequired();
        }
    }
}
