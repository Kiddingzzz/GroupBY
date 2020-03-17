using Sport7.CMS.Localization;
using Sport7.Localization;
using Sport7.Localization.ExceptionHandling;
using Sport7.Modularity;
using Sport7.VirtualFileSystem;

namespace Sport7.CMS
{
    [DependsOn(
        typeof(Sport7LocalizationModule)
    )]
    public class CMSDomainModule : Sport7Module
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<Sport7LocalizationOptions>(options =>
            {
                options.Resources.Add<CMSResource>("en");
            });

            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<CMSDomainModule>();
            });

            Configure<Sport7LocalizationOptions>(options =>
            {
                options.Resources.Get<CMSResource>().AddVirtualJson("/Sport7/CMS/Localization/Domain");
            });

            Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("CMS", typeof(CMSResource));
            });
        }
    }
}