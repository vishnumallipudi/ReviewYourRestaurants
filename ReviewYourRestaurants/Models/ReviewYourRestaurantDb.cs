using System.Data.Entity;

namespace ReviewYourRestaurants.Models
{
    public class ReviewYourRestaurantDb:DbContext
    {
        public ReviewYourRestaurantDb():base("name=DefaultConnection")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }


    }
}