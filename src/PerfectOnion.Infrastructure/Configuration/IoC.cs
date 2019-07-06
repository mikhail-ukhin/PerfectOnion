using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Infrastructure.Implementations;
using PerfectOnion.Infrastructure.Interfaces;

namespace PerfectOnion.Infrastructure.Configuration
{
    public static class IoC
    {
        public static IServiceCollection ConfigureInfrastructure(this IServiceCollection serviceCollection) =>
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
    }
}