using Context.Models;
using System;

namespace BusinessLogic.Models
{
    public class BlogPostModel
    {
        public BlogPostModel()
        {
        }

        public BlogPostModel(BlogPost blogPost)
        {
            Id = blogPost.Id;
            Title = blogPost.Title;
            Body = blogPost.Body;
            Author = blogPost.Author;
            Image = blogPost.Image;
            Posted = blogPost.Posted;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public Image Image { get; set; }
        public DateTime Posted { get; set; }
    }
}
