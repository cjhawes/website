using Context.Models;
using System.Collections.Generic;

namespace BusinessLogic.Repositories.Interfaces
{
    public interface IToDoRepository : IGenericBaseRepository<ToDo>
    {
        IEnumerable<ToDo> GetAllToDoes();
    }
}
