using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Core.Abstractions;
using PerfectOnion.Infrastructure.Implementations;

namespace PerfectOnion.Infrastructure.Configuration
{
    public static class IoC
    {
        public static IServiceCollection AddDataServices(this IServiceCollection serviceCollection) =>
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
    }
}