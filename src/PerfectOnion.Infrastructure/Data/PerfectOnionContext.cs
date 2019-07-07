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
        }
    }
}