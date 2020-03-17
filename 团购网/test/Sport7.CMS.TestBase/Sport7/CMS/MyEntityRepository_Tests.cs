using System.Threading.Tasks;
using Sport7.Modularity;
using Xunit;

namespace Sport7.CMS
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : CMSTestBase<TStartupModule>
        where TStartupModule : ISport7Module
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}

