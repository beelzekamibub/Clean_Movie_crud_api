using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

//in no way linked to the infrastructure

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviessController : ControllerBase
    {
        //depends in the IMovieService
        private readonly IMovieService _service;

        public MoviessController(IMovieService service)
        {
            _service = service;
        }
        // GET: api/<MoviessController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesFromService = _service.GetAllMovies();
            return Ok(moviesFromService);
        }
        [HttpPost]
        public ActionResult<Movie> Post(Movie movie)
        {
            var res=_service.CreateMovie(movie);
            return Ok(res);
        }

    }
}
