using Context.Models;
using System.Collections.Generic;

namespace BusinessLogic.Repositories.Interfaces
{
    public interface IImageRepository : IGenericBaseRepository<Image>
    {
        Image GetImageById(int id);
        IEnumerable<Image> GetAllImages();
        IEnumerable<Image> GetThreeMostRecentImages();
    }
}
