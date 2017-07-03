namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VoteCounter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InsultVotes",
                c => new
                    {
                        InsultVoteId = c.Int(nullable: false, identity: true),
                        VoterId = c.String(),
                        Vote = c.Int(nullable: false),
                        Insult_InsultId = c.Int(),
                    })
                .PrimaryKey(t => t.InsultVoteId)
                .ForeignKey("dbo.Insults", t => t.Insult_InsultId)
                .Index(t => t.Insult_InsultId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InsultVotes", "Insult_InsultId", "dbo.Insults");
            DropIndex("dbo.InsultVotes", new[] { "Insult_InsultId" });
            DropTable("dbo.InsultVotes");
        }
    }
}
