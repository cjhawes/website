using Context.Models;
using System.Collections.Generic;

namespace BusinessLogic.Repositories.Interfaces
{
    public interface IResearchRepository : IGenericBaseRepository<Research>
    {
        Research GetResearchById(int id);

        IEnumerable<Research> GetAllResearch();
    }
}
