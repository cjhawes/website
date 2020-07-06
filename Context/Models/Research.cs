using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Context.Models
{
    public class Research
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string Author { get; set; }
        public DateTime Posted { get; set; }
        public string Url { get; set; }
    }
}
