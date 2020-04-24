namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedimagetable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "ImageTitle", c => c.String());
            AddColumn("dbo.Images", "ImageDescription", c => c.String());
            AddColumn("dbo.Images", "ImageUploaded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "ImageUploaded");
            DropColumn("dbo.Images", "ImageDescription");
            DropColumn("dbo.Images", "ImageTitle");
        }
    }
}
