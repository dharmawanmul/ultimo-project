using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}