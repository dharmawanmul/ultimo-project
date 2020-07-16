using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var schedule = _context.Schedules.ToList();
            var movies = _context.Movies.ToList();
            foreach (var s in schedule) {
                s.Movie = (Movie) movies.Where(m => m.Id == s.MovieId).FirstOrDefault();
            }
            var viewModel = new HomeViewModel(schedule, movies);
            return View(viewModel);
        }
    }
}