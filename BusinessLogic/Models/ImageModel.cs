using Context.Models;

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
        }

        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
    }
}
