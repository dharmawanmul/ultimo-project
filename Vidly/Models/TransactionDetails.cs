using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class TransactionDetails
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public NewTransaction NewTransaction { get; set; }
        public int NewTransactionId { get; set; }
    }
}