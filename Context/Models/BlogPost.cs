using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Context.Models
{
    public class BlogPost
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        [ForeignKey("Image")]
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public DateTime Posted { get; set; }
    }
}
