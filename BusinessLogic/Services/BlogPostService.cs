using BusinessLogic.Models;
using BusinessLogic.Repositories;
using BusinessLogic.Repositories.Interfaces;
using BusinessLogic.Services.Interfaces;
using System.Collections.Generic;

namespace BusinessLogic.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;

        public BlogPostService()
        {
            _blogPostRepository = new BlogPostRepository();
        }

        public BlogPostModel GetBlogPostById(int id)
        {
            var blogPost = _blogPostRepository.GetByPrimaryKey(id);
            return new BlogPostModel(blogPost);
        }

        public IEnumerable<BlogPostModel> GetAllBlogPosts()
        {
            var blogPosts = _blogPostRepository.GetAllBlogPosts();
            List<BlogPostModel> posts = new List<BlogPostModel>();

            foreach (var post in blogPosts)
            {
                posts.Add(new BlogPostModel(post));
            }

            return posts;
        }
    }
}
