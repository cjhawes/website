using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Services.Interfaces
{
    public interface IResearchService
    {
        ResearchModel GetResearchById(int id);
        IEnumerable<ResearchModel> GetAllResearch();
    }
}
