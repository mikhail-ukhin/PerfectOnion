using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Infrastructure.Abstractions;
using PerfectOnion.Infrastructure.Implementations;

namespace PerfectOnion.Infrastructure.Configuration
{
    public static class IoC
    {
        public static IServiceCollection ConfigureInfrastructure(this IServiceCollection serviceCollection) =>
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
    }
}