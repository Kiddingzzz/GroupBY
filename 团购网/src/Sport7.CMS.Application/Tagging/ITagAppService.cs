using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sport7.Application.Services;
using Sport7.CMS.Tagging.Dtos;

namespace Sport7.CMS.Tagging
{
    public interface ITagAppService : IApplicationService
    {
        Task<List<TagDto>> GetPopularTags(Guid postId, GetPopularTagsInput input);

    }
}
