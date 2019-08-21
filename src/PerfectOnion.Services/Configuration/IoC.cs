using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Services.Shopping.Abstractions;
using PerfectOnion.Services.Shopping.Implementations;

namespace PerfectOnion.Services.Configuration
{
    public static class IoC
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services) =>
            services
                .AddScoped<IOrderService, OrderService>();

        
    }
}