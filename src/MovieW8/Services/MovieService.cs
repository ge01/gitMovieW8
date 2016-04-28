using MovieW8.Infrastructure;
using MovieW8.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieW8.Services
{
    public class MovieService
    {
        private MovieRepository _movieRepo;

        public MovieService(MovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }

        public ICollection<MovieDTO> GetFeaturedMovies()
        {
            return (from c in _movieRepo.List()
                    select new MovieDTO()
                    {
                        Title = c.Title,
                        Director = c.Director
                    }).ToList();
        }
    }
}
