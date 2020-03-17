using JetBrains.Annotations;
using Sport7.MongoDB;

namespace Sport7.CMS
{
    public class CMSMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public CMSMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = CMSConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}