using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class TransactionController : Controller
    {
        private ApplicationDbContext _context;
        public TransactionController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Transaction
        public ActionResult Index(int id)
        {
            var scheds = _context.Schedules.ToList();
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var movie = _context.Movies.ToList();
            var viewModel = new TransactionFormViewModel()
            {
                Schedules = scheds,
                Customer = customer,
                MoviesCheckBox = new List<MovieCheckBox>()
            };
            return View("TransactionForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(TransactionFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }
            var transaction = new NewTransaction()
            {
                CustomerId = viewModel.CustomerId,
                TransactionDate = DateTime.Now
            };
            _context.NewTransactions.Add(transaction);
            var details = new TransactionDetails()
            {
                NewTransactionId = transaction.Id,
            };
            foreach (var i in viewModel.MoviesCheckBox.Where(m => m.Value == true))
            {
                details.MovieId = i.Id;
                _context.TransactionDetails.Add(details);
                transaction.TotalPrice += Movie.GetMovies().SingleOrDefault(m => m.Id == i.Id).Price;
                _context.SaveChanges();
            }


            return View("TransactionTable");
        }

        public ActionResult TransactionTable()
        {
            var transaction = _context.Transactions.ToList();
            var customer = _context.Customers.ToList();
            var movie = _context.Movies.ToList();
            var scheds = _context.Schedules.ToList();
            var viewModel = new TransactionFormViewModel()
            {
                Transactions = transaction,
                Customers = customer,
                Schedules = scheds
            };
            return View(viewModel);
        }
    }
}