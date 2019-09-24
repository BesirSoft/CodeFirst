namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TemmKurulsudegisti : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "BaslamaYili", c => c.Short(nullable: false));
            Sql("Update Teams set KurulusYili=BaslamaYili");
            DropColumn("dbo.Teams", "KurulusYili");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "KurulusYili", c => c.Short(nullable: false));
            Sql("Update Team set BaslamaYili=KurulusYili");
            DropColumn("dbo.Teams", "BaslamaYili");
        }
    }
}
