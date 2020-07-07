using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class VidlyViewModel
    {
        public List<Customer> Customers { get; set; }

        public Movie Movie { get; set; }
    }
}