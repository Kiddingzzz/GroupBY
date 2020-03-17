
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Sport7.CMS.Posts;

namespace Sport7.CMS
{
    public static class EntityFrameworkCoreQueryableExtensions
    {
        public static IQueryable<Post> IncludeDetails(this IQueryable<Post> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                .Include(x => x.Tags);
        }
    }
}
