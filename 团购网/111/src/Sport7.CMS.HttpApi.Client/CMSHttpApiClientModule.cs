using Microsoft.Extensions.DependencyInjection;
using Sport7.Http.Client;
using Sport7.Modularity;

namespace Sport7.CMS
{
    [DependsOn(
        typeof(CMSApplicationModule),
        typeof(Sport7HttpClientModule))]
    public class CMSHttpApiClientModule : Sport7Module
    {
        public const string RemoteServiceName = "CMS";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(CMSApplicationModule).Assembly,
                RemoteServiceName
            );
        }
    }
}

