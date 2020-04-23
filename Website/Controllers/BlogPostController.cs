using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using System.Web.Http;

namespace Website.Controllers
{
    public class BlogPostController : BaseController
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostController()
        {
            _blogPostService = new BlogPostService();
        }

        [HttpGet]
        public IHttpActionResult GetBlogPosts()
        {
            var blogPosts = _blogPostService.GetAllBlogPosts();
            return Json(blogPosts, SerializerSettings);
        }

        [HttpGet]
        public IHttpActionResult GetBlogPost(int id)
        {
            var blogPost = _blogPostService.GetBlogPostById(id);
            return Json(blogPost, SerializerSettings);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
