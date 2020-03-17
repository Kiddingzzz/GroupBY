using Sport7;
using Sport7.Modularity;

namespace Sport7.CMS
{
    public abstract class CMSTestBase<TStartupModule> : Sport7IntegratedTest<TStartupModule> 
        where TStartupModule : ISport7Module
    {
        protected override void SetSport7ApplicationCreationOptions(Sport7ApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}

