using MovieW8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieW8.Infrastructure
{
    public class MovieRepository : GenericRepository<Movie>
    {
        public MovieRepository(ApplicationDbContext db) : base(db) { }
    }
}
