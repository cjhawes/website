using BusinessLogic.Repositories.Interfaces;
using Context.Models;
using System.Collections.Generic;

namespace BusinessLogic.Repositories
{
    public class ResearchRepository : BaseRepository<Research>, IResearchRepository
    {
        public ResearchRepository() : base()
        {
        }

        public Research GetResearchById(int id)
        {
            var research = GetByPrimaryKey(id);
            return research;
        }

        public IEnumerable<Research> GetAllResearch()
        {
            return GetAll();
        }
    }
}
