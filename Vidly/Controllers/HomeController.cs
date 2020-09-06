using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidlyc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var movie = new movie() { Name = "Movies" };

            var movies = new List<movie>
            {
                new movie {Name = "Shrek"},
                new movie {Name = "Wall-e"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Movies = movies
            };


            return View(ViewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}