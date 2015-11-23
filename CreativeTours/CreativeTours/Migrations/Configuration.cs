namespace CreativeTours.Migrations
{
    using CreativeTours.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CreativeTours.Models.CreativeTourDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CreativeTours.Models.CreativeTourDB";
        }

        protected override void Seed(CreativeTours.Models.CreativeTourDB context)
        {

        }
    }
}
