namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameguncellmesioldum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Ad", c => c.String());
           

            DropColumn("dbo.Teams", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Name", c => c.String());
           

            DropColumn("dbo.Teams", "Ad");
        }
    }
}
