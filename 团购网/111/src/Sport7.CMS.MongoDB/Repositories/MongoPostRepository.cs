using System;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using Sport7.CMS.Posts;
using Sport7.Domain.Entities;
using Sport7.Domain.Repositories.MongoDB;
using Sport7.MongoDB;

namespace Sport7.CMS.Repositories
{
    public class MongoPostRepository : MongoDbRepository<CMSMongoDbContext, Post, Guid>, IPostRepository
    {
        public MongoPostRepository(IMongoDbContextProvider<CMSMongoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Post> GetPostByUrl(string url)
        {
            var post = await GetMongoQueryable().FirstOrDefaultAsync(p => p.Url == url);

            if (post == null)
            {
                throw new EntityNotFoundException(typeof(Post), nameof(post));
            }

            return post;
        }
    }
}
