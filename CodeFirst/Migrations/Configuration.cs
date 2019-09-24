namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.FutboldbConrext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.FutboldbConrext context)
        {

            /*context.Teams.AddOrUpdate(
               new Team { id = 1, Ad = "Fenerbahce", BaslamaYili = 1907 },
               new Team { id = 1, Ad = "Fenerbahce", BaslamaYili = 1907 },
               new Team { id = 1, Ad = "Fenerbahce", BaslamaYili = 1907 },
               new Team { id = 1, Ad = "Fenerbahce", BaslamaYili = 1907 },
               new Team { id = 1, Ad = "Fenerbahce", BaslamaYili = 1907 }
             



                );  */
           
        }
    }
}
