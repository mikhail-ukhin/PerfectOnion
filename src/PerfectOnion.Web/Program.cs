using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PerfectOnion.Core.Common.Exceptions;
using PerfectOnion.Core.Configuration;
using PerfectOnion.Data.Configuration;
using PerfectOnion.Data.PerfectOnion;
using PerfectOnion.Services.Configuration;
using PerfectOnion.Web.Services;

namespace PerfectOnion.Web
{
    public class Program
    {
        public const string AppId = "PerfectOnion";
        
        public static async Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.local.json")
                .Build();
            var appConfig = GetAppConfig(configuration);

            await Host
                .CreateDefaultBuilder()
                .ConfigureAppConfiguration(builder => { builder.AddConfiguration(configuration); })
                .ConfigureServices((context, services) =>
                    {
                        services
                            .AddSingleton(appConfig)
                            .Configure<UrlsConfig>(context.Configuration.GetSection("Urls"))
                            .Configure<AuthConfig>(context.Configuration.GetSection("Auth"))
                            .Configure<ConnectionStrings>(context.Configuration.GetSection("ConnectionStrings"))
                            .AddEntityFrameworkNpgsql()
                            .AddDbContext<PerfectOnionContext>(c => c.UseNpgsql(appConfig.ConnectionStrings.DefaultConnection))
                            .AddHostedService<MigrationService>()
                            .AddDataServices()
                            .AddServices();
                    })
                .Build()
                .StartAsync();
        }

        private static AppConfig GetAppConfig(IConfiguration configuration)
        {
            var connectionStrings = configuration.GetSection("ConnectionStrings").Get<ConnectionStrings>();
            
            if (string.IsNullOrEmpty(connectionStrings.DefaultConnection)) throw new ConfigurationException("db connection string is null or empty");

            var authConfig = configuration.GetSection("Auth").Get<AuthConfig>();
            var urlsConfig = configuration.GetSection("Urls").Get<UrlsConfig>();
            
            if (string.IsNullOrEmpty(urlsConfig.AuthUrl)) throw new ConfigurationException("auth url is null or empty");

            return new AppConfig(authConfig, urlsConfig, connectionStrings);
        }
    }
}