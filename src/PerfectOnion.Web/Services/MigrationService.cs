using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PerfectOnion.Data.Data;

namespace PerfectOnion.Web.Services
{
    public class MigrationService : IHostedService
    {
        private readonly PerfectOnionContext _perfectOnionContext;
        private readonly ILogger<MigrationService> _logger;

        public MigrationService(
            PerfectOnionContext perfectOnionContext,
            ILogger<MigrationService> logger)
        {
            _perfectOnionContext = perfectOnionContext;
            _logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                await _perfectOnionContext.Database.MigrateAsync(cancellationToken);
            }
            catch (Exception e)
            {
                _logger.LogError("error on applying db migrations", e);
                throw;
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}