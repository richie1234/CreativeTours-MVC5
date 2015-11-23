using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeTours.Models
{
    public class CreativeTourDB : DbContext
    {
        public CreativeTourDB() : base("name=DefaultConnection")
        {

        }

        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourReview> Reviews { get; set; }

    }
}
