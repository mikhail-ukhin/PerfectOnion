using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Core.Abstractions;
using PerfectOnion.Data.PerfectOnion.Repositories;

namespace PerfectOnion.Data.Configuration
{
    public static class IoC
    {
        public static IServiceCollection AddDataServices(this IServiceCollection serviceCollection) =>
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
    }
}