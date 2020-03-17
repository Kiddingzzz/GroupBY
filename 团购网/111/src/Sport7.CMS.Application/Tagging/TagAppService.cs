using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sport7.Application.Services;
using Sport7.CMS.Tagging.Dtos;

namespace Sport7.CMS.Tagging
{
    public class TagAppService : ApplicationService, ITagAppService
    {
        private readonly ITagRepository _tagRepository;

        public TagAppService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<List<TagDto>> GetPopularTags(Guid postId, GetPopularTagsInput input)
        {
            var postTags = (await _tagRepository.GetListAsync(postId)).OrderByDescending(t=>t.UsageCount)
                .WhereIf(input.MinimumPostCount != null, t=>t.UsageCount >= input.MinimumPostCount)
                .Take(input.ResultCount).ToList();

            return new List<TagDto>(
                ObjectMapper.Map<List<Tag>, List<TagDto>>(postTags));
        }
    }
}
