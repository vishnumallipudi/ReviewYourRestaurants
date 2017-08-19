namespace ReviewYourRestaurants.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ReviewYourRestaurants.Models.ReviewYourRestaurantDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ReviewYourRestaurants.Models.ReviewYourRestaurantDb";
        }

        protected override void Seed(ReviewYourRestaurants.Models.ReviewYourRestaurantDb context)
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

            context.Restaurants.AddOrUpdate(r=>r.Name,
                new Restaurant { Name="Seattle's Best",City="Seattle",Country="USA"},
                new Restaurant { Name = "Biryani Point", City = "Bellevue", Country = "UK" },
                new Restaurant {
                    Name = "Saaka",
                    City = "Hyderabad",
                    Country = "IND",
                    Reviews=
                        new List<RestaurantReview> {
                        new RestaurantReview { Rating=9, Body="Great Food!", ReviewerName="Vishnu"}
                    }
                });

            for (int i = 0;i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(
                    r=>r.Name,
                    new Restaurant { Name=i.ToString(),City="Nowhere",Country="USA"});
            }

        }
    }
}
