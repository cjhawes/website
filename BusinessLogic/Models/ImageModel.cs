using Context.Models;
using System;

namespace BusinessLogic.Models
{
    public class ImageModel
    {
        public ImageModel()
        {
        }

        public ImageModel(Image image)
        {
            ImageId = image.ImageId;
            ImageUrl = image.ImageUrl;
            ImageTitle = image.ImageTitle;
            ImageDescription = image.ImageDescription;
            ImageUploaded = image.ImageUploaded;
        }

        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageTitle { get; set; }
        public string ImageDescription { get; set; }
        public DateTime ImageUploaded { get; set; }
    }
}
