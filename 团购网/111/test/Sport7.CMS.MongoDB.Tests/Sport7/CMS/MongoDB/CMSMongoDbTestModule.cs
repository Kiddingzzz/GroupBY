using Microsoft.Extensions.DependencyInjection;
using Mongo2Go;
using Sport7;
using Sport7.Data;
using Sport7.Modularity;

namespace Sport7.CMS.MongoDB
{
    [DependsOn(
        typeof(CMSTestBaseModule),
        typeof(CMSMongoDbModule)
        )]
    public class CMSMongoDbTestModule : Sport7Module
    {
        private MongoDbRunner _mongoDbRunner;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            _mongoDbRunner = MongoDbRunner.Start();

            Configure<DbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = _mongoDbRunner.ConnectionString;
            });
        }

        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {
            _mongoDbRunner.Dispose();
        }
    }
}
