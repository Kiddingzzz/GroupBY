using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sport7.Application.Services;
using Sport7.CMS.Comments.Dtos;

namespace Sport7.CMS.Comments
{
    public interface ICommentAppService : IApplicationService
    {
        Task<List<CommentWithRepliesDto>> GetHierarchicalListOfPostAsync(Guid postId);

        Task<CommentWithDetailsDto> CreateAsync(CreateCommentDto input);

        Task<CommentWithDetailsDto> UpdateAsync(Guid id, UpdateCommentDto input);

        Task DeleteAsync(Guid id);
    }
}
