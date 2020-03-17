using MongoDB.Driver;
using Sport7.CMS.Comments;
using Sport7.CMS.Posts;
using Sport7.Data;
using Sport7.MongoDB;

namespace Sport7.CMS
{
    [ConnectionStringName("CMS")]
    public class CMSMongoDbContext : Sport7MongoDbContext
    {
        public static string CollectionPrefix { get; set; } = CMSConsts.DefaultDbTablePrefix;

        public IMongoCollection<Post> Posts => Collection<Post>();
       
        public IMongoCollection<Sport7.CMS.Tagging.Tag> Tags => Collection<Sport7.CMS.Tagging.Tag>();
       
        public IMongoCollection<Comment> Comments => Collection<Comment>();
       

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureCMS(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}