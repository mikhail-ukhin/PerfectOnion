using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PerfectOnion.Data.Data
{
    public class PerfectOnionContextFactory : IDesignTimeDbContextFactory<PerfectOnionContext>
    {
        public PerfectOnionContext CreateDbContext(string[] args)
        {
            var configuration =
                new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

            var builder = new DbContextOptionsBuilder<PerfectOnionContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);
            
            return new PerfectOnionContext(builder.Options);
        }
    }
}