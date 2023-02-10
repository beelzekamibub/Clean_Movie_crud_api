using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Domain
{
    public class Movie
    {
        //what is a domain
        //domain are things that are domain specific can be different for movies and different for tv shows
        //what we can do woth or without software
        //can be done in hardware as well
        //domain doesnt depend on any other project
        public int MovieId { get; set; }
        public string  MovieName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }
        public IList<MovieRental> MovieRentals { get; set; }
    }
}