using Sport7.AspNetCore.Mvc;
using Sport7.Modularity;

namespace Sport7.CMS
{
    [DependsOn(
        typeof(CMSApplicationModule),
        typeof(Sport7AspNetCoreMvcModule))]
    public class CMSHttpApiModule : Sport7Module
    {
        
    }
}

