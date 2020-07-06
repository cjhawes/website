using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Context.Models
{
    public class ToDo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
