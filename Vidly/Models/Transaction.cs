using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }

        public Movie Movie { get; set; }
        public int CustomerId { get; set; }

        public int MovieId { get; set; }

        public DateTime? TransactionDate { get; set; }

        public float TotalPrice { get; set; }

    }
}