using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class FutboldbConrext : DbContext
    {

        public FutboldbConrext() : base("FutbolDbConStr")
        {


         }



        public DbSet<Player> Players { get; set; }




        public DbSet<Team> Teams { get; set; }



        public DbSet<PlayersAdress> PlayersAddress { get; set; }

        public DbSet<Sponsore> Sponsor { get; set; }





    }

}
