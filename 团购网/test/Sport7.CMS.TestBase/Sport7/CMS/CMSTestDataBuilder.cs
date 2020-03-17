using Sport7.DependencyInjection;
using Sport7.Guids;

namespace Sport7.CMS
{
    public class CMSTestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private CMSTestData _testData;

        public CMSTestDataBuilder(
            IGuidGenerator guidGenerator,
            CMSTestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}
