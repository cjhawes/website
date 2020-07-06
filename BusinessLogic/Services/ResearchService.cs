using BusinessLogic.Models;
using BusinessLogic.Repositories;
using BusinessLogic.Repositories.Interfaces;
using BusinessLogic.Services.Interfaces;
using System.Collections.Generic;

namespace BusinessLogic.Services
{
    public class ResearchService : IResearchService
    {
        private readonly IResearchRepository _researchRepository;

        public ResearchService()
        {
            _researchRepository = new ResearchRepository();
        }

        public ResearchModel GetResearchById(int id)
        {
            var research = _researchRepository.GetByPrimaryKey(id);
            return new ResearchModel(research);
        }

        public IEnumerable<ResearchModel> GetAllResearch()
        {
            var research = _researchRepository.GetAllResearch();
            List<ResearchModel> posts = new List<ResearchModel>();

            foreach (var post in research)
            {
                posts.Add(new ResearchModel(post));
            }

            return posts;
        }
    }
}
