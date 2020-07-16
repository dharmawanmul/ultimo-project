using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Generator;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class ScheduleController : Controller
    {
        private ApplicationDbContext _context;
        public ScheduleController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Schedule
        public ActionResult Index(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            var j = _context.Schedules.Where(m => m.MovieId == id).ToList();

            var viewModel = new ScheduleFormViewModel(j, id)
            {
                Movie = movie
            };
            return View("ScheduleForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Schedule schedule)
        {
            if (!ModelState.IsValid)
            {
                return View("ScheduleForm");
            }
            _context.Schedules.Add(schedule);
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}