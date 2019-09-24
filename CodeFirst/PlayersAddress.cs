using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
  public  class PlayersAddress
    {


        [ForeignKey("Player")]
        [Key]
        public int PlayersAdressid { get; set; }

        public string City { get; set; }
        public int Street { get; set; }

        public int PostCode { get; set; }

        public Player Player { get; set; }
    }




}

