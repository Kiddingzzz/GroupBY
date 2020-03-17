using System;
using Sport7.MongoDB;

namespace Sport7.CMS
{
    public static class CMSMongoDbContextExtensions
    {
        public static void ConfigureCMS(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new CMSMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}