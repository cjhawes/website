using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Services.Interfaces
{
    public interface IImageService
    {
        ImageModel GetImageById(int id);
        IEnumerable<ImageModel> GetAllImages();
    }
}
