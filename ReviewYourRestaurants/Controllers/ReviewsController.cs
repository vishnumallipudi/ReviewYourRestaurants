﻿using ReviewYourRestaurants.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace ReviewYourRestaurants.Controllers
{
    public class ReviewsController : Controller
    {
        ReviewYourRestaurantDb _db = new ReviewYourRestaurantDb();
        // GET: Reviews
        public ActionResult Index([Bind(Prefix ="id")]int restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);
            if (restaurant!=null)
            {
                return View(restaurant);
            }

            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            
           
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index",new { id=review.RestaurantId});
            }
            return View(review);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }


        [HttpPost]
        public ActionResult Edit([Bind(Exclude = "ReviewerName")]RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index",new { id=review.RestaurantId});
            }
            return View(review);
        }
        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }

    }
        
}
