using System;
using System.Collections.Generic;

namespace Context.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageTitle { get; set; }
        public string ImageDescription { get; set; }
        public DateTime ImageUploaded { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
