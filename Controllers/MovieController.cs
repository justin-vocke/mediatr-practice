using MediatR;
using MediatrPractice.Application.Movies.Commands.CreateMovie;
using MediatrPractice.Application.Movies.Querie.GetMovie;
using MediatrPractice.Application.Movies.Queries.GetMovies;
using MediatrPractice.Domain.DTOs.Requests.Movie;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatrPractice.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class MovieController: ControllerBase
    {
        private readonly IMediator _mediator;

        public MovieController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _mediator.Send(new GetMoviesQuery());
            return Ok(movies);
        }

        [HttpGet("/getmovies/{id}")]
        public async Task<IActionResult> GetMovie(long id)
        {
            var movie = await _mediator.Send(new GetMovieQuery(id));

            if (movie != null)
            {
                return Ok(movie);
            }

            return NotFound($"No movie in database with ID: {id}.");

        }
        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] CreateMovieRequest request)
        {
            var movie = await _mediator.Send(new CreateMovieCommand(
                request.Title,
                request.Description,
                request.Genre,
                request.Rating
                ));

            return Ok(movie);
        }
    }
}
