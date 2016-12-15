namespace Furst_Alpha_1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Furst_Alpha_1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Furst_Alpha_1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Furst_Alpha_1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Assets.AddOrUpdate(
                  p => p.Asset_Id,
                  new Asset
                  {
                      Asset_Id = 0000001,
                      Vendor_Id = 001,
                      Category_Id = 0001,
                      Type_Id = 0001,
                      Make_Id = 0001,
                      Model_Id = 01,
                      Image ="https://www.pictures.com",
                      Year_Purchased = 2015,
                      Rental_Price = 199.99,
                      Num_Techs_Req = 0,
                      Availability = true,
                  },
                 
            );

        }
    }
}
