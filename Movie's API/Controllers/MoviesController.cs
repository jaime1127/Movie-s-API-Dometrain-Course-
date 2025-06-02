using Microsoft.AspNetCore.Mvc;
using Movies.Application.Repositories;

namespace Movie_s_API.Controllers
{
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
    }
}
