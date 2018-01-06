using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModels;

namespace Vidly1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!"};

            var customers = new List<Customer>
            {
                new Customer {Name = "customer 1"},
                new Customer {Name = "customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }
    }
}