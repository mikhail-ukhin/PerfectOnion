using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Service.Implementations;
using PerfectOnion.Service.Interfaces;

namespace PerfectOnion.Service.Configuration
{
    public static class IoC
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services) =>
            services
                .AddScoped<IOrderService, OrderService>();

        
    }
}