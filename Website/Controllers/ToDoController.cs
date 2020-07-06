using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using System.Web.Http;

namespace Website.Controllers
{
    public class ToDoController : BaseController
    {
        private readonly IToDoService _toDoService;

        public ToDoController()
        {
            _toDoService = new ToDoService();
        }

        [HttpGet]
        public IHttpActionResult GetToDoes()
        {
            var todos = _toDoService.GetAllToDoes();
            return Json(todos, SerializerSettings);
        }
    }
}
