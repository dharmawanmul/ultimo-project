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

        public IEnumerable<NewTransactionDto> GetTransactions()
        {
            return _context.NewTransactions.Include(t => t.Customer).ToList().Select(Mapper.Map<NewTransaction, NewTransactionDto>);
        }

        public IHttpActionResult GetTransaction(int id)
        {

            var transaction = _context.NewTransactions.SingleOrDefault(c => c.Id == id);

            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<NewTransaction, NewTransactionDto>(transaction));
        }
    }
}
