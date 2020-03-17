using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Sport7.Application.Dtos;
using Sport7.CMS.Tagging.Dtos;

namespace Sport7.CMS.Posts
{
    public class PostWithDetailsDto : FullAuditedEntityDto<Guid>
    {
        public Guid BlogId { get; set; }

        public string Title { get; set; }

        public string CoverImage { get; set; }

        public string Url { get; set; }

        public string Content { get; set; }

        public int ReadCount { get; set; }

        public int CommentCount { get; set; }

        [CanBeNull]
        public BlogUserDto Writer { get; set; }

        public List<TagDto> Tags { get; set; }
    }
}
