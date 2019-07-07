using Microsoft.EntityFrameworkCore;
using PerfectOnion.Infrastructure.EntityConfigurations;

namespace PerfectOnion.Infrastructure.Data
{
    public class PerfectOnionContext : DbContext
    {
        public PerfectOnionContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderPositionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}