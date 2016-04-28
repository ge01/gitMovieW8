using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using MovieW8.Models;
using MovieW8.Services;
using MovieW8.Services.Models;

namespace MovieW8.Controllers
{
    [Produces("application/json")]
    [Route("api/Movies")]
    public class MoviesController : Controller
    {
        private MovieService _movieService;

        public MoviesController(MovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/Movies
        [HttpGet]
        public ICollection<MovieDTO> GetFeaturedMovies()
        {
            return _movieService.GetFeaturedMovies();
        }        
    }
}