using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace PerfectOnion.Data.PerfectOnion
{
    public class PerfectOnionContext : DbContext
    {
        public PerfectOnionContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}