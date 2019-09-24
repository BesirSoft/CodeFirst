using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
public    class Sponsore
    {


        public int Id { get; set; }

        public string Ad { get; set; }
        public ICollection<Team> Tems { get; set; }

    }
}
