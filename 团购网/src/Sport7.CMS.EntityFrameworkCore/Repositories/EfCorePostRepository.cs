using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sport7.AuditLogging;
using Sport7.CMS.EntityFrameworkCore;
using Sport7.Domain.Entities;
using Sport7.Domain.Repositories.EntityFrameworkCore;
using Sport7.EntityFrameworkCore;

namespace Sport7.CMS.Posts
{
    public class EfCorePostRepository : EfCoreRepository<CMSDbContext, Post, Guid>, IPostRepository
    {
        public EfCorePostRepository(IDbContextProvider<CMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }


        public async Task<Post> GetPostByUrl(string url)
        {
            var post = await DbSet.FirstOrDefaultAsync(p => p.Url == url);

            if (post == null)
            {
                throw new EntityNotFoundException(typeof(Post), nameof(post));
            }

            return post;
        }

        public override IQueryable<Post> WithDetails()
        {
            return GetQueryable().IncludeDetails();
        }
    }
}
