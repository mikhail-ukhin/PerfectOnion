using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfectOnion.Core.Entities;

namespace PerfectOnion.Data.Configuration.EntityConfigurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .ToTable("Persons");
            
            builder
                .HasKey(e => e.Id);

            builder
                .HasDiscriminator<string>("PersonType");
            
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

            builder
                .Property(e => e.Gender)
                .HasColumnName("Gender")
                .IsRequired();
        }
    }
}