using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfectOnion.Core.PerfectOnion.Entities;

namespace PerfectOnion.Data.Configuration.EntityConfigurations
{
    public class OrderPositionConfiguration : IEntityTypeConfiguration<OrderPosition>
    {
        public void Configure(EntityTypeBuilder<OrderPosition> builder)
        {
            builder
                .ToTable("OrderPositions");

            builder
                .HasKey(e => e.Id);
            
            builder
                .Property(e => e.Id)
                .HasColumnName("Id")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(e => e.Amount)
                .HasColumnName("Amount")
                .IsRequired();

            builder
                .Property(e => e.Measure)
                .HasColumnName("Measure")
                .IsRequired()
                .HasMaxLength(32);

            builder
                .Property(e => e.OrderId)
                .HasColumnName("OrderId")
                .IsRequired();

            builder
                .Property(e => e.ProductId)
                .HasColumnName("ProductId")
                .IsRequired();

            builder
                .HasOne(e => e.Order)
                .WithMany()
                .HasForeignKey(e => e.OrderId)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasOne(e => e.Product)
                .WithMany()
                .HasForeignKey(e => e.ProductId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}