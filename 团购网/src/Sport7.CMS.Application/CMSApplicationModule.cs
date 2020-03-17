using Microsoft.Extensions.DependencyInjection;
using Sport7.AutoMapper;
using Sport7.CMS.Localization;
using Sport7.Localization;
using Sport7.Modularity;
using Sport7.Settings;
using Sport7.VirtualFileSystem;

namespace Sport7.CMS
{
    [DependsOn(
        typeof(CMSDomainModule),
        typeof(Sport7AutoMapperModule)
        )]
    public class CMSApplicationModule : Sport7Module
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<Sport7AutoMapperOptions>(options =>
            {
                options.AddProfile<CMSApplicationAutoMapperProfile>(validate: true);
            });

            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<CMSApplicationModule>();
            });

            Configure<Sport7LocalizationOptions>(options =>
            {
                options.Resources
                    .Get<CMSResource>()
                    .AddVirtualJson("/Localization/ApplicationContracts");
            });
        }
    }
}

