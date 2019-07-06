using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Service.Abstractions;
using PerfectOnion.Service.Implementations;

namespace PerfectOnion.Service.Configuration
{
    public static class IoC
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services) =>
            services
                .AddScoped<IOrderService, OrderService>();

        
    }
}