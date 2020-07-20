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
    public class TransactionDetailsController : ApiController
    {
        private ApplicationDbContext _context;
        public TransactionDetailsController()
        {
            _context = new ApplicationDbContext(); 
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IEnumerable<TransactionDetailsDto> GetTransactionDetails()
        {
            return _context.TransactionDetails.Include(t => t.NewTransaction).Include(t => t.Movie).ToList().Select(Mapper.Map<TransactionDetails, TransactionDetailsDto>);
        }

        public IHttpActionResult GetTransaction(int id)
        {

            var transaction = _context.TransactionDetails.Include(t => t.NewTransaction).Include(t => t.Movie).SingleOrDefault(c => c.Id == id);

            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<TransactionDetails, TransactionDetailsDto>(transaction));
        }
    }
}
