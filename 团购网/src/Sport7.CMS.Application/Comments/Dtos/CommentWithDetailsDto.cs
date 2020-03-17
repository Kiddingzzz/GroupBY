using System;
using Sport7.Application.Dtos;
using Sport7.CMS.Posts;

namespace Sport7.CMS.Comments.Dtos
{
    public class CommentWithDetailsDto : FullAuditedEntityDto<Guid>
    {
        public Guid? RepliedCommentId { get; set; }

        public string Text { get; set; }

        public BlogUserDto Writer { get; set; }
    }
}
