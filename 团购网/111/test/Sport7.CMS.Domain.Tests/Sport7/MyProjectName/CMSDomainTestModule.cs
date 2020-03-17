using Sport7.CMS.EntityFrameworkCore;
using Sport7.Modularity;

namespace Sport7.CMS
{
    [DependsOn(
        typeof(CMSEntityFrameworkCoreTestModule)
        )]
    public class CMSDomainTestModule : Sport7Module
    {
        
    }
}

