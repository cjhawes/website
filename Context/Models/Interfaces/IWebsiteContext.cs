using System.Data.Entity;

namespace Context.Models.Interfaces
{
    public interface IWebsiteContext
    {
        DbSet<BlogPost> BlogPosts { get; set; }
        int SaveChanges();
    }
}
