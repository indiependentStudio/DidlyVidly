using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DidlyVidly.Models;
using DidlyVidly.ViewModels;

namespace DidlyVidly.Controllers
{
    public class MoviesController : Controller
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie { Id = 1, Name = "Shrek"},
            new Movie { Id = 2, Name = "Wall-E"}
        };

        // GET: Movies
        public ActionResult Index()
        {
            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }
    }
}