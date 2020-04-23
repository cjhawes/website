using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using System.Web.Http;

namespace Website.Controllers
{
    public class ImageController : BaseController
    {
        private readonly IImageService _imageService;

        public ImageController()
        {
            _imageService = new ImageService();
        }

        [HttpGet]
        public IHttpActionResult GetImages()
        {
            var images = _imageService.GetAllImages();
            return Json(images, SerializerSettings);
        }

        [HttpGet]
        public IHttpActionResult GetImage(int id)
        {
            var image = _imageService.GetImageById(id);
            return Json(image, SerializerSettings);
        }
    }
}