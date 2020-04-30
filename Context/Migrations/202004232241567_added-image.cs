namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedimage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ImageId);
            
            AddColumn("dbo.BlogPosts", "ImageId", c => c.Int(nullable: false));
            CreateIndex("dbo.BlogPosts", "ImageId");
            AddForeignKey("dbo.BlogPosts", "ImageId", "dbo.Images", "ImageId", cascadeDelete: true);
            DropColumn("dbo.BlogPosts", "HeaderImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BlogPosts", "HeaderImage", c => c.String());
            DropForeignKey("dbo.BlogPosts", "ImageId", "dbo.Images");
            DropIndex("dbo.BlogPosts", new[] { "ImageId" });
            DropColumn("dbo.BlogPosts", "ImageId");
            DropTable("dbo.Images");
        }
    }
}
