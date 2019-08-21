using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfectOnion.Core.Entities;

namespace PerfectOnion.Infrastructure.EntityConfigurations
{
    
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {            


            builder
                .Property(e => e.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

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
                .Property(e => e.Position)
                .HasColumnName("Position")
                .IsRequired()
                .HasMaxLength(64);

            builder
                .Property(e => e.Salary)
                .HasColumnName("Salary")
                .IsRequired();
        }
    }
}