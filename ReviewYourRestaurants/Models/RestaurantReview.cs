﻿namespace ReviewYourRestaurants.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }       

        public int Rating { get; set; }

        public string Body { get; set; }
        public string ReviewerName { get; set; }

        public int RestuarantId { get; set; }

    }
}