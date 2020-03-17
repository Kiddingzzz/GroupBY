using JetBrains.Annotations;
using Sport7.EntityFrameworkCore.Modeling;

namespace Sport7.CMS.EntityFrameworkCore
{
    public class CMSModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public CMSModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = CMSConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = CMSConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}
