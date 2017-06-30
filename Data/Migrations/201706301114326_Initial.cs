namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insults",
                c => new
                    {
                        InsultId = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InsultId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Insults");
        }
    }
}
