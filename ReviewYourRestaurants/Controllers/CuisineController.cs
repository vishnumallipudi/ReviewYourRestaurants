using System.Web.Mvc;

namespace ReviewYourRestaurants.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search()
        {
            return Content("hello from search");
        }
    }
}