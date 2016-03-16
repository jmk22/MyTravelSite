using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTravelSite01.Models
{
    public class MyTravelsContext : DbContext
    {
        public virtual DbSet<Destination> Destinations { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyTravels;integrated security=True");
        }
    }
}
