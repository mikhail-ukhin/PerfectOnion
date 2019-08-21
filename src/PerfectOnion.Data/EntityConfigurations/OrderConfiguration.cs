using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfectOnion.Core.Entities;

namespace PerfectOnion.Infrastructure.EntityConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .ToTable("Orders");

            builder
                .HasKey(e => e.Id);

            builder
                .HasAlternateKey(e => e.Number);

            builder
                .Property(e => e.Id)
                .HasColumnName("Id")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(e => e.Number)
                .HasColumnName("Number")
                .IsRequired()
                .HasMaxLength(64);

            builder
                .Property(e => e.CreatedAt)
                .HasColumnName("CreatedAt")
                .IsRequired();

            builder
                .Property(e => e.CustomerId)
                .HasColumnName("CustomerId")
                .IsRequired();

            builder
                .Property(e => e.EmployeeId)
                .HasColumnName("EmployeeId");

            builder
                .HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(e => e.EmployeeId);

            builder
                .HasOne(e => e.Customer)
                .WithMany()
                .HasForeignKey(e => e.CustomerId);
        }
    }
}