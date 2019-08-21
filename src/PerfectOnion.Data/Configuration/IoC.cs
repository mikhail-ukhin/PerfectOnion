using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Core.Abstractions;
using PerfectOnion.Data.Implementations;

namespace PerfectOnion.Data.Configuration
{
    public static class IoC
    {
        public static IServiceCollection AddDataServices(this IServiceCollection serviceCollection) =>
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
    }
}