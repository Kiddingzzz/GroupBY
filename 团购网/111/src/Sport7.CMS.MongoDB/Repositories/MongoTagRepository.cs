using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using Sport7.CMS.Tagging;
using Sport7.Domain.Repositories.MongoDB;
using Sport7.MongoDB;

namespace Sport7.CMS.Repositories
{
    public class MongoTagRepository : MongoDbRepository<CMSMongoDbContext, Tag, Guid>, ITagRepository
    {
        public MongoTagRepository(IMongoDbContextProvider<CMSMongoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<List<Tag>> GetListAsync(Guid postId)
        {
            return await GetMongoQueryable().Where(t => t.PostId == postId).ToDynamicListAsync<Tag>();
        }

        public async Task<Tag> GetByNameAsync(Guid blogId, string name)
        {
            return await GetMongoQueryable().Where(t => t.PostId == blogId && t.Name == name).FirstAsync();
        }

        public async Task<Tag> FindByNameAsync(Guid blogId, string name)
        {
            return await GetMongoQueryable().Where(t => t.PostId == blogId && t.Name == name).FirstOrDefaultAsync();
        }

        public async Task<List<Tag>> GetListAsync(IEnumerable<Guid> ids)
        {
            return await GetMongoQueryable().Where(t => ids.Contains(t.Id)).ToDynamicListAsync<Tag>();
        }

        public void DecreaseUsageCountOfTags(List<Guid> ids)
        {
            var tags = GetMongoQueryable().Where(t => ids.Contains(t.Id));

            foreach (var tag in tags)
            {
                tag.DecreaseUsageCount();
                Update(tag);
            }
        }
    }
}
