using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sport7.CMS.EntityFrameworkCore;
using Sport7.Domain.Repositories.EntityFrameworkCore;
using Sport7.EntityFrameworkCore;

namespace Sport7.CMS.Tagging
{
    public class EfCoreTagRepository : EfCoreRepository<CMSDbContext, Tag, Guid>, ITagRepository
    {
        public EfCoreTagRepository(IDbContextProvider<CMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<List<Tag>> GetListAsync(Guid postId)
        {
            return await DbSet.Where(t=>t.PostId == postId).ToListAsync();
        }

        public async Task<Tag> GetByNameAsync(Guid blogId, string name)
        {
            return await DbSet.FirstAsync(t=> t.PostId == blogId && t.Name == name);
        }

        public async Task<Tag> FindByNameAsync(Guid blogId, string name)
        {
            return await DbSet.FirstOrDefaultAsync(t => t.PostId == blogId && t.Name == name);
        }

        public async Task<List<Tag>> GetListAsync(IEnumerable<Guid> ids)
        {
            return await DbSet.Where(t => ids.Contains(t.Id)).ToListAsync();
        }

        public void DecreaseUsageCountOfTags(List<Guid> ids)
        {
            var tags = DbSet.Where(t => ids.Any(id => id == t.Id));

            foreach (var tag in tags)
            {
                tag.DecreaseUsageCount();
            }
        }
    }
}
