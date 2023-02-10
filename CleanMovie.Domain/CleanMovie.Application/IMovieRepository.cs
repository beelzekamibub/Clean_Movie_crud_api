using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    //gets the data for us
    public interface IMovieRepository
    {
        //dictates the business layer and depened only on the domain layer
        //what to implement
        //use cases
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
    }
}
