using System;
using JetBrains.Annotations;
using Sport7.Domain.Entities.Auditing;

namespace Sport7.CMS.Tagging
{
    public class Tag : FullAuditedAggregateRoot<Guid>
    {
        public virtual Guid PostId { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual string Description { get; protected set; }

        public virtual int UsageCount { get; protected internal set; }

        protected Tag()
        {

        }

        public Tag(Guid postId, [NotNull] string name, int usageCount = 0, string description = null)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(name));
            PostId = postId;
            Description = description;
            UsageCount = usageCount;
        }

        public virtual void SetName(string name)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(name));
        }

        public virtual void IncreaseUsageCount(int number = 1)
        {
            UsageCount += number;
        }

        public virtual void DecreaseUsageCount(int number = 1)
        {
            if (UsageCount <= 0)
            {
                return;
            }

            if (UsageCount - number <= 0)
            {
                UsageCount = 0;
                return;
            }

            UsageCount -= number;
        }

        public virtual void SetDescription(string description)
        {
            Description = description;
        }
    }
}
