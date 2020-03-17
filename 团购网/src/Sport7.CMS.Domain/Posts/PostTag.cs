using System;
using Sport7.Domain.Entities.Auditing;

namespace Sport7.CMS.Posts
{
    public class PostTag : CreationAuditedEntity<Guid>
    {
        public virtual Guid PostId { get; protected set; }

        public virtual Guid TagId { get; protected set; }

        protected PostTag()
        {

        }

        public PostTag(Guid postId, Guid tagId)
        {
            PostId = postId;
            TagId = tagId;
        }

        public override object[] GetKeys()
        {
            return new object[] { PostId, TagId };
        }
    }
}
