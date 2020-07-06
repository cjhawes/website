using System.Data.Entity;

namespace Context.Models.Interfaces
{
    public interface IWebsiteContext
    {
        DbSet<BlogPost> BlogPosts { get; set; }
        DbSet<Research> Research { get; set; }
        DbSet<ToDo> ToDo { get; set; }
        DbSet<Image> Images { get; set; }
        int SaveChanges();
    }
}
