using System.Web.Mvc;

namespace ReviewYourRestaurants.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            return View(); 
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //static List<RestaurantReview> _reviews = new List<RestaurantReview>
        //{
        //    new RestaurantReview {
        //        Id=1,
        //        Name="Cinnamon club",
        //        City="Seattle",
        //        Country="UK",
        //        Rating=10
        //    },
        //    new RestaurantReview {
        //        Id=2,
        //        Name="Biryani Point",
        //        City="Bellevue",
        //        Country="USA",
        //        Rating=10
        //    },
        //    new RestaurantReview {
        //        Id=3,
        //        Name="Paradise",
        //        City="Milford",
        //        Country="USA",
        //        Rating=10
        //    },new RestaurantReview {
        //        Id=4,
        //        Name="Shangrilla",
        //        City="Bridgeport",
        //        Country="USA",
        //        Rating=9
        //    }
        //};
    }
}
