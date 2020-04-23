using BusinessLogic.Models;
using BusinessLogic.Repositories;
using BusinessLogic.Repositories.Interfaces;
using BusinessLogic.Services.Interfaces;
using System.Collections.Generic;

namespace BusinessLogic.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService()
        {
            _imageRepository = new ImageRepository();
        }

        public ImageModel GetImageById(int id)
        {
            var image = _imageRepository.GetImageById(id);
            return new ImageModel(image);
        }

        public IEnumerable<ImageModel> GetAllImages()
        {
            var images = _imageRepository.GetAllImages();
            List<ImageModel> imageList = new List<ImageModel>();

            foreach (var image in images)
            {
                imageList.Add(new ImageModel(image));
            }

            return imageList;
        }
    }
}
