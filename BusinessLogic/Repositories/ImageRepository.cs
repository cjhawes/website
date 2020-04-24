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

        public IEnumerable<Image> GetThreeMostRecentImages()
        {
            var allImages = GetAll();
            List<Image> images = new List<Image>();
            List<Image> mostRecent = new List<Image>();
           
            foreach (var image in allImages)
            {
                images.Add(image);
                
            }

            images.Reverse();

            int count = 0;
            foreach (var image in images)
            {
                mostRecent.Add(image);
                count++;
                if (count == 3)
                {
                    break;
                }
            }

            return mostRecent;
        }
    }
}
