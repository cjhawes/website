using BusinessLogic.Repositories.Interfaces;
using Context.Models;
using System.Collections.Generic;

namespace BusinessLogic.Repositories
{
    public class BlogPostRepository : BaseRepository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository() : base()
        {
        }

        public BlogPost GetBlogPostById(int id)
        {
            var blogPost = GetByPrimaryKey(id);
            return blogPost;
        }

        public IEnumerable<BlogPost> GetAllBlogPosts()
        {
            return GetAll();
        }
    }
}
