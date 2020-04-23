using Context.Models;
using System.Collections.Generic;

namespace BusinessLogic.Repositories.Interfaces
{
    public interface IBlogPostRepository : IGenericBaseRepository<BlogPost>
    {
        BlogPost GetBlogPostById(int id);

        IEnumerable<BlogPost> GetAllBlogPosts();
    }
}
