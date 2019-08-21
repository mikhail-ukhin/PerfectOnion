using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfectOnion.Core.Entities;

namespace PerfectOnion.Data.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();
            
            builder
                .Property(e => e.Address)
                .HasColumnName("Address")
                .HasMaxLength(512);

            builder
                .Property(e => e.Email)
                .HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(128);

            builder
                .Property(e => e.Phone)
                .HasColumnName("Phone")
                .IsRequired()
                .HasMaxLength(64);

            builder
                .Property(e => e.FirstName)
                .HasColumnName("FirstName")
                .IsRequired()
                .HasMaxLength(64);

            builder
                .Property(e => e.MiddleName)
                .HasColumnName("MiddleName")
                .HasMaxLength(64);

            builder
                .Property(e => e.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(64);          
        }
    }
}