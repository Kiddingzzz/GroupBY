using Sport7.Modularity;

namespace Sport7.CMS
{
    [DependsOn(
        typeof(CMSApplicationModule),
        typeof(CMSDomainTestModule)
        )]
    public class CMSApplicationTestModule : Sport7Module
    {

    }
}

