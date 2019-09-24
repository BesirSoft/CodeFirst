using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
   public class FutballContext:DbContext
    {

        public FutballContext(): base("FutbolDbConStr")
        {
            
        }

        public DbSet<Team> Teams { get; set; }


        public DbSet<Player> Players { get; set; }
        public DbSet<PlayersAddress> PlayersAddress { get; set; }

        public DbSet<Sponsor> Sponsor { get; set; }



    }
}
