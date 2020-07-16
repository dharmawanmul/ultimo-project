using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class HomeViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Schedule> Schedule { get; set; }

        public HomeViewModel(List<Schedule> schedules, List<Movie> movies)
        {
            Schedule = schedules;
            Movies = movies;
        }
    }
}