using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Team
    {

        public int id { get; set; }

        public string Ad { get; set; }
        public short KurulusYili { get; set; }

        public ICollection<Player> Players { get; set; }

        public ICollection<Sponsor> Sponsors { get; set; }

    }

}
