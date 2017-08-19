﻿using ReviewYourRestaurants.Models;
using System.Linq;
using System.Web.Mvc;

namespace ReviewYourRestaurants.Controllers
{

    public class HomeController : Controller
    {

        ReviewYourRestaurantDb _db = new ReviewYourRestaurantDb();
        public ActionResult Index(string searchTerm=null)
        {
            
            var model = _db.Restaurants.
                    OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                    .Where(r=>searchTerm==null || r.Name.StartsWith(searchTerm))
                    .Select(r => new RestaurantListViewModel
                    {
                        Id = r.Id,
                        Name = r.Name,
                        City = r.City,
                        Country = r.Country,
                        CountOfReviews = r.Reviews.Count()
                    });
            if (Request.IsAjaxRequest())
            {
                return PartialView("_RestaurantList", model);
            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (_db!=null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}