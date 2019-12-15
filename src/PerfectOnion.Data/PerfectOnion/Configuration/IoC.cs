using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Core.PerfectOnion.Interfaces;
using PerfectOnion.Data.PerfectOnion.Repositories;

namespace PerfectOnion.Data.PerfectOnion.Configuration
{
    public static class IoC
    {
        public static IServiceCollection AddPerfectOnionDataServices(this IServiceCollection serviceCollection) =>
            serviceCollection
                .AddScoped<IPerfectOnionUnitOfWork, PerfectOnionUnitOfWork>()
                .AddScoped<IOrderRepository, OrderRepository>();
    }
}