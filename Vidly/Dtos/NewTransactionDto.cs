using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class NewTransactionDto
    {
        public int Id { get; set; }

        public CustomerDto Customer { get; set; }

        public int CustomerId { get; set; }

        public DateTime? TransactionDate { get; set; }

        public float TotalPrice { get; set; }
    }
}