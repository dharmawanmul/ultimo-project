using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class ScheduleFormViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public int Id { get; set; }
        public int Day { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public List<Schedule> Jadwal { get; set; }

        public ScheduleFormViewModel(List<Schedule> j, int id)
        {
            Jadwal = j;
            MovieId = id;
        }

        public ScheduleFormViewModel()
        {
        }

        public ScheduleFormViewModel(Schedule schedule)
        {
            Id = schedule.Id;
            Day = schedule.Day;
            MovieId = schedule.MovieId;
        }
    }
}