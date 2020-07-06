using Context.Models;
using System;

namespace BusinessLogic.Models
{
    public class ToDoModel
    {
        public ToDoModel()
        {
        }

        public ToDoModel(ToDo toDo)
        {
            Id = toDo.Id;
            Name = toDo.Name;
            Description = toDo.Description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
