using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Lab5_Jermaine.Models
{
    public class Teams
    {
        //Properties for the Teams
        public string numberOfPlayers { get; set; } // The Number of players on a team
        [Key]
        public string NBAteamName { get; set; } // The Team Name

        public string PlayerNames { get; set; } // The Players Name on the team 
    }
}
