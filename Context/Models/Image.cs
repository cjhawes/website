using System.Collections.Generic;

namespace Context.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
