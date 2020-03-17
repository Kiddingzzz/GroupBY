using Microsoft.Extensions.DependencyInjection;
using Sport7.Modularity;
using Sport7.MongoDB;

namespace Sport7.CMS
{
    [DependsOn(
        typeof(CMSDomainModule),
        typeof(Sport7MongoDbModule)
    )]
    public class CMSMongoDbModule : Sport7Module
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<CMSMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}