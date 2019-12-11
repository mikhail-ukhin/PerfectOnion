using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PerfectOnion.Core.Configuration;

namespace PerfectOnion.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.local.json")
                .Build();

            await Host
                .CreateDefaultBuilder()
                .ConfigureAppConfiguration(builder => { builder.AddConfiguration(configuration); })
                .ConfigureServices((context, services) =>
                    {
                        services
                            .Configure<UrlsConfig>(context.Configuration.GetSection("Urls"))
                            .Configure<AuthConfig>(context.Configuration.GetSection("Auth"));
                    })
                .Build()
                .StartAsync();
        }
    }
}