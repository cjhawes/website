using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Services.Interfaces
{
    public interface IBlogPostService
    {
        BlogPostModel GetBlogPostById(int id);
        IEnumerable<BlogPostModel> GetAllBlogPosts();
    }
}
