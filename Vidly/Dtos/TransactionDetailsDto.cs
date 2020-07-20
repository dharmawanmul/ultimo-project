using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Dtos;

namespace Vidly.Models
{
    public class TransactionDetailsDto
    {
        public int Id { get; set; }
        public MovieDto Movie { get; set; }
        public int MovieId { get; set; }
        public NewTransactionDto NewTransaction { get; set; }
        public int NewTransactionId { get; set; }
    }
}