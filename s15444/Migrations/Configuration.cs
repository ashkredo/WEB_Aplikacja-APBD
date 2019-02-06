namespace s15444.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<s15444.Models.OsobyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(s15444.Models.OsobyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Types.AddOrUpdate(m => m.Rabat, new Models.Type { Rabat = "10%" },
                new Models.Type { Rabat = "15%" }, new Models.Type { Rabat = "25%" },
                new Models.Type { Rabat = "50%" }, new Models.Type { Rabat = "75%" });
            //context.SaveChanges();  
        }
    }
}
