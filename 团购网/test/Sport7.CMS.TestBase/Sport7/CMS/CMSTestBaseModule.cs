using Microsoft.Extensions.DependencyInjection;
using Sport7;
using Sport7.Authorization;
using Sport7.Autofac;
using Sport7.Modularity;

namespace Sport7.CMS
{
    [DependsOn(
        typeof(Sport7AutofacModule),
        typeof(Sport7TestBaseModule),
        typeof(Sport7AuthorizationModule),
        typeof(CMSDomainModule)
        )]
    public class CMSTestBaseModule : Sport7Module
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAlwaysAllowAuthorization();
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            SeedTestData(context);
        }

        private static void SeedTestData(ApplicationInitializationContext context)
        {
            using (var scope = context.ServiceProvider.CreateScope())
            {
                scope.ServiceProvider
                    .GetRequiredService<CMSTestDataBuilder>()
                    .Build();
            }
        }
    }
}

