using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using JetBrains.Annotations;
using Sport7.Domain.Entities.Auditing;

namespace Sport7.CMS.Posts
{
    public class Post : FullAuditedAggregateRoot<Guid>
    {

        [NotNull]
        public virtual string Url { get; protected set; }

        [NotNull]
        public virtual string CoverImage { get; set; }

        [NotNull]
        public virtual string Title { get; protected set; }

        [CanBeNull]
        public virtual string Content { get; set; }

        public virtual int ReadCount { get; protected set; }

        public virtual Collection<PostTag> Tags { get; protected set; }

        protected Post()
        {
            
        }

        public Post(Guid id, [NotNull] string title, [NotNull] string coverImage, [NotNull] string url)
        {
            Id = id;
            Title = Check.NotNullOrWhiteSpace(title, nameof(title));
            Url = Check.NotNullOrWhiteSpace(url, nameof(url));
            CoverImage = Check.NotNullOrWhiteSpace(coverImage, nameof(coverImage));

            Tags = new Collection<PostTag>();
        }

        public virtual Post IncreaseReadCount()
        {
            ReadCount++;
            return this;
        }

        public virtual Post SetTitle([NotNull] string title)
        {
            Title = Check.NotNullOrWhiteSpace(title, nameof(title));
            return this;
        }

        public virtual Post SetUrl([NotNull] string url)
        {
            Url = Check.NotNullOrWhiteSpace(url, nameof(url));
            return this;
        }

        public virtual void AddTag(Guid tagId)
        {
            Tags.Add(new PostTag(Id,tagId));
        }

        public virtual void RemoveTag(Guid tagId)
        {
            Tags.RemoveAll(t => t.TagId == tagId);
        }
    }
}
