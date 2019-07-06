using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Services.Abstractions;
using PerfectOnion.Services.Implementations;

namespace PerfectOnion.Services.Configuration
{
    public static class IoC
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services) =>
            services
                .AddScoped<IOrderService, OrderService>();

        
    }
}