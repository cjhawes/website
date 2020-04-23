using BusinessLogic.Repositories.Interfaces;
using Context.Models;
using System.Collections.Generic;

namespace BusinessLogic.Repositories
{
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        public ImageRepository() : base()
        {
        }

        public Image GetImageById(int id)
        {
            var image = GetByPrimaryKey(id);
            return image;
        }

        public IEnumerable<Image> GetAllImages()
        {
            var images = GetAll();
            return images;
        }
    }
}
