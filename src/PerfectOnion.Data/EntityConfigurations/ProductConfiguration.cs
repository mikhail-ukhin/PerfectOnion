using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfectOnion.Core.Entities;

namespace PerfectOnion.Infrastructure.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .ToTable("Products");

            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder
                .Property(e => e.Description)
                .HasColumnName("Description")
                .HasMaxLength(512);

            builder
                .Property(e => e.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(128);

            builder
                .Property(e => e.Price)
                .HasColumnName("Price")
                .IsRequired();
        }
    }
}