namespace PerfectOnion.Core.Configuration
{
    public class AppConfig
    {
        public AppConfig(AuthConfig authConfig, UrlsConfig urlsConfig, ConnectionStrings connectionStrings)
        {
            Urls = urlsConfig;
            Auth = authConfig;
            ConnectionStrings = connectionStrings;
        }
        
        public UrlsConfig Urls { get; }
        public AuthConfig Auth { get; }
        public ConnectionStrings ConnectionStrings { get; }
    }
}