using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class TransactionsController : ApiController
    {
        private ApplicationDbContext _context;
        public TransactionsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IEnumerable<TransactionDto> GetTransactions()
        {
            return _context.Transactions.Include(t => t.Customer).Include(t => t.Movie).ToList().Select(Mapper.Map<Transaction, TransactionDto>);
        }

        public IHttpActionResult GetTransaction(int id)
        {

            var transaction = _context.Transactions.SingleOrDefault(c => c.Id == id);

            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Transaction, TransactionDto>(transaction));
        }
    }
}
