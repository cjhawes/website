using Context.Models;
using System;

namespace BusinessLogic.Models
{
    public class ResearchModel
    {
        public ResearchModel()
        {
        }

        public ResearchModel(Research research)
        {
            Id = research.Id;
            Title = research.Title;
            Synopsis = research.Synopsis;
            Author = research.Author;
            Posted = research.Posted;
            Url = research.Url;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string Author { get; set; }
        public DateTime Posted { get; set; }
        public string Url { get; set; }
    }
}
