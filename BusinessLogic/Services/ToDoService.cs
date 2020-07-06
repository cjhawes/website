using BusinessLogic.Models;
using BusinessLogic.Repositories;
using BusinessLogic.Repositories.Interfaces;
using BusinessLogic.Services.Interfaces;
using System.Collections.Generic;

namespace BusinessLogic.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoService()
        {
            _toDoRepository = new ToDoRepository();
        }

        public IEnumerable<ToDoModel> GetAllToDoes()
        {
            var todos = _toDoRepository.GetAllToDoes();
            List<ToDoModel> posts = new List<ToDoModel>();

            foreach (var post in todos)
            {
                posts.Add(new ToDoModel(post));
            }

            return posts;
        }
    }
}
