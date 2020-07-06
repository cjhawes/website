using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using System.Web.Http;

namespace Website.Controllers
{
    public class ResearchController : BaseController
    {
        private readonly IResearchService _researchService;

        public ResearchController()
        {
            _researchService = new ResearchService();
        }

        [HttpGet]
        public IHttpActionResult GetResearch()
        {
            var research = _researchService.GetAllResearch();
            return Json(research, SerializerSettings);
        }

        [HttpGet]
        public IHttpActionResult GetResearchPost(int id)
        {
            var research = _researchService.GetResearchById(id);
            return Json(research, SerializerSettings);
        }

        //public void Post([FromBody]string value)
        //{
        //}

        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //public void Delete(int id)
        //{
        //}
    }
}
