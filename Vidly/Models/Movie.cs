using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        //private ApplicationDbContext _context;
        //public Movie()
        //{
        //    _context = new ApplicationDbContext();
        //}


        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
        [Display(Name = "Number In Stock")]
        [Range(0,20)]
        public int Stock { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        public float Price { get; set; }
        public Movie()
        {
            Id = 0;
        }

        public static List<Movie> GetMovies() {
            ApplicationDbContext _context = new ApplicationDbContext();
            return _context.Movies.ToList();
        }
    }
}