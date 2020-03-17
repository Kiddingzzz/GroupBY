using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sport7.Domain.Repositories;

namespace Sport7.CMS.Tagging
{
    public interface ITagRepository : IBasicRepository<Tag, Guid>
    {
        Task<List<Tag>> GetListAsync(Guid postId);

        Task<Tag> GetByNameAsync(Guid blogId, string name);

        Task<Tag> FindByNameAsync(Guid blogId, string name);

        Task<List<Tag>> GetListAsync(IEnumerable<Guid> ids);

        void DecreaseUsageCountOfTags(List<Guid> id);
    }
}
