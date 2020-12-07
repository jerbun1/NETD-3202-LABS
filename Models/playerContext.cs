using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab5_Jermaine.Models;


namespace Lab5_Jermaine.Models
{
    public class playerContext : DbContext
    {
        //constructor For PlayerContext
        public playerContext(DbContextOptions<playerContext> options): base(options)
        {

        }

        public DbSet<Players> Player { get; set; }
        public DbSet<Teams> Team { get; set; }


    }
}
