namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creatteadrestable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayersAdresses",
                c => new
                    {
                        PlayersAdressid = c.Int(nullable: false),
                        City = c.String(),
                        Street = c.Int(nullable: false),
                        PostCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayersAdressid)
                .ForeignKey("dbo.Players", t => t.PlayersAdressid)
                .Index(t => t.PlayersAdressid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayersAdresses", "PlayersAdressid", "dbo.Players");
            DropIndex("dbo.PlayersAdresses", new[] { "PlayersAdressid" });
            DropTable("dbo.PlayersAdresses");
        }
    }
}
