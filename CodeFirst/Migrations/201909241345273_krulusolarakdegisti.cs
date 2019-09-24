namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class krulusolarakdegisti : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "KurulusYili", c => c.Short(nullable: false));
   
            DropColumn("dbo.Teams", "BaslamaYili");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "BaslamaYili", c => c.Short(nullable: false));
        
            DropColumn("dbo.Teams", "KurulusYili");
        }
    }
}
