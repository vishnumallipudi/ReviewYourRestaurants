﻿using System.ComponentModel.DataAnnotations;

namespace ReviewYourRestaurants.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }       

        [Range(1,10)]
        [Required]
        public int Rating { get; set; }


        [Required]
        [StringLength(1024)]
        public string Body { get; set; }


        [Display(Name ="User Name")]
        [DisplayFormat(NullDisplayText ="Anonymous")]
        public string ReviewerName { get; set; }



        public int RestaurantId { get; set; }

    }
}