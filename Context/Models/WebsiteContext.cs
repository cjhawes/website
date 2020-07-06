using Context.Models.Interfaces;
using System.Data.Entity;

namespace Context.Models
{
    public partial class WebsiteContext : DbContext, IWebsiteContext
    {
        public WebsiteContext() : base("name=WebsiteDatabase")
        {
        }
        public DbSet<Research> Research { get; set; }
        public DbSet<ToDo> ToDo { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
