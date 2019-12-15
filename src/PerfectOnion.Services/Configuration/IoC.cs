using Microsoft.Extensions.DependencyInjection;
using PerfectOnion.Services.PerfectOnion.Configuration;

namespace PerfectOnion.Services.Configuration
{
    public static class IoC
    {
        public static IServiceCollection AddServices(this IServiceCollection services) =>
            services
                .AddPerfectOnionServices();

        
    }
}