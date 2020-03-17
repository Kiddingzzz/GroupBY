using Microsoft.Extensions.DependencyInjection;
using Sport7.EntityFrameworkCore;
using Sport7.Modularity;

namespace Sport7.CMS.EntityFrameworkCore
{
    [DependsOn(
        typeof(CMSDomainModule),
        typeof(Sport7EntityFrameworkCoreModule)
    )]
    public class CMSEntityFrameworkCoreModule : Sport7Module
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSport7DbContext<CMSDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */

                options.AddDefaultRepositories(includeAllEntities:true);
            });
        }
    }
}
