namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatteadSponsered : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sponsores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SponsoreTeams",
                c => new
                    {
                        Sponsore_Id = c.Int(nullable: false),
                        Team_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sponsore_Id, t.Team_id })
                .ForeignKey("dbo.Sponsores", t => t.Sponsore_Id, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_id, cascadeDelete: true)
                .Index(t => t.Sponsore_Id)
                .Index(t => t.Team_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SponsoreTeams", "Team_id", "dbo.Teams");
            DropForeignKey("dbo.SponsoreTeams", "Sponsore_Id", "dbo.Sponsores");
            DropIndex("dbo.SponsoreTeams", new[] { "Team_id" });
            DropIndex("dbo.SponsoreTeams", new[] { "Sponsore_Id" });
            DropTable("dbo.SponsoreTeams");
            DropTable("dbo.Sponsores");
        }
    }
}
