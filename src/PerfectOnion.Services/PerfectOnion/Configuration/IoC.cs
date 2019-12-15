using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Core.PerfectOnion.Interfaces;

namespace PerfectOnion.Services.PerfectOnion.Configuration
{
    public static class IoC
    {
        public static IServiceCollection AddPerfectOnionServices(this IServiceCollection services) =>
            services
                .AddScoped<IOrderService, OrderService>();
    }
}