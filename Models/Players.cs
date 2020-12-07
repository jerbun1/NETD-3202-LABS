using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5_Jermaine.Models
{
    public class Players
    {
        //Properties for Players
        [Key]
        public string PlayerName { get; set; }// The Players Name

        public int PlayerNumber { get; set; } // The Players Number

        public string PlayerTeam { get; set; } // The Players Team

        public string PlayerPosition { get; set; } // The Players Position

        public string PlayerCondition { get; set; } // The Players Condition

        public string NBAteamName { get; set; } // The Players Team



    }

   


}
