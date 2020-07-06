namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedResearchModelTry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Researches",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Title = c.String(),
                        Synopsis = c.String(),
                        Author = c.String(),
                        Posted = c.DateTime(nullable: false),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Researches");
        }
    }
}
