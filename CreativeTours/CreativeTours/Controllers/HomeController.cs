using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreativeTours.Models;

namespace CreativeTours.Controllers
{
    public class HomeController : Controller
    {

        CreativeTourDB _db = new CreativeTourDB();

        public ActionResult Index(string searchTerm = null)
        {

            //var model =
            //    from r in _db.Tours
            //    orderby r.Reviews.Average(review => review.Rating) descending 
            //    select  new TourListViewModel
            //                {
            //                    Id = r.Id,
            //                    Name = r.Name,
            //                    City = r.City,
            //                    Country = r.Country,
            //                    CountOfReviews = r.Reviews.Count()
            //                };


            var model =
                _db.Tours
                   .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                   .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                   .Take(10)
                   .Select(r => new TourListViewModel
                   {
                       Id = r.Id,
                       Name = r.Name,
                       City = r.City,
                       Country = r.Country,
                       CountOfReviews = r.Reviews.Count()
                   }
                   );



            return View(model);
        }

        public ActionResult About()
        {

            var model = new AboutModel();
            model.Name = "Ruchitha";
            model.Location = "Melbourne Australia";

            ViewBag.Message = "Your application description page.";
            ViewBag.Location = "Sydney Australia";

            return View(model);
        }

        public ActionResult Documentation()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}