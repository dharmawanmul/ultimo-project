using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class NewTransaction
    {
        public int Id { get; set; }
        public DateTime? TransactionDate { get; set; }
        public float TotalPrice { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}