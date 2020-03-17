using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sport7.Domain.Repositories;

namespace Sport7.CMS.Posts
{
    public interface IPostRepository : IBasicRepository<Post, Guid>
    {

        Task<Post> GetPostByUrl(string url);
    }
}
