namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Createplayertoteamiliski : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Team_id", c => c.Int());
            CreateIndex("dbo.Players", "Team_id");
            AddForeignKey("dbo.Players", "Team_id", "dbo.Teams", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_id", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Team_id" });
            DropColumn("dbo.Players", "Team_id");
        }
    }
}
