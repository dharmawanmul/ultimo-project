using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class TransactionFormViewModel
    {
        public Transaction Transaction { get; set; }
        public Movie Movie { get; set; }
        public Customer Customer { get; set; }

        public List<Transaction> Transactions { get; set; }
        //public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }

        public List<Schedule> Schedules { get; set; }

        public List<MovieCheckBox> MoviesCheckBox { get; set; }

        public int CustomerId { get; set; }

        public int MovieId { get; set; }

        public DateTime? TransactionDate { get; set; }

        public float TotalPrice { get; set; }

        public TransactionFormViewModel()
        {
        }
    }
}