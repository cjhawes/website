using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Services.Interfaces
{
    public interface IToDoService
    {
        IEnumerable<ToDoModel> GetAllToDoes();
    }
}
