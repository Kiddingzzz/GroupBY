using System;

namespace Sport7.CMS.Comments.Dtos
{
    public class CreateCommentDto
    {
        public Guid? RepliedCommentId { get; set; }

        public Guid PostId { get; set; }

        public string Text { get; set; }
    }
}