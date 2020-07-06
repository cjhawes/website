using BusinessLogic.Repositories.Interfaces;
using Context.Models;
using System.Collections.Generic;

namespace BusinessLogic.Repositories
{
    public class ToDoRepository : BaseRepository<ToDo>, IToDoRepository
    {
        public ToDoRepository() : base()
        {
        }

        public IEnumerable<ToDo> GetAllToDoes()
        {
            return GetAll();
        }
    }
}
