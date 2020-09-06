using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace vidlyMvc.Controllers
{
    public class MoviesController : Controller
    {
        // Routa: Movies/random
        public ActionResult Main()
        {
            var customer = new customer() { Name = "Customer"};

            var Customers = new List<customer>
            {
                 new customer {Name = "John Smith"},
                new customer {Name = "Mary Williams"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                customer = customer,
                Customers = Customers
            };

            return View(ViewModel);
        }
        public ActionResult Random()
        {
            var movie = new movie() { Name = "Shrek!" };

            var customers = new List<customer>
            {
              new customer {Name = "Customer 1"},
              new customer {Name = "Customer 2"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

             return View(ViewModel);


        }

        public ActionResult Customers()
        {
            var customer = new customer() {Name = "customer" };

            var customersList = new List<customer>()
            {
                new customer {Name = "John Smith"},
                new customer {Name = "Mary Williams"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Customers = customersList,
                customer = customer
            };
            return View(ViewModel);
        }

        public ActionResult Movies()
        {
            var movie = new movie() {Name = "Movie" };

            var moviesList = new List<movie>
            {
                new movie {Name = "Shrek"},
                new movie {Name = "Wall-e"},
                new movie {Name = "Troy"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
            Movies = moviesList
            };

            return View(ViewModel);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if(string.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name"; 
            }
            return Content(string.Format("pageIndex={0} & sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/month:regex(\\d{4}) : range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month); 
        }  
    }
}