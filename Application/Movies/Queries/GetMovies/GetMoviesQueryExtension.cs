using MediatrPractice.Domain.DTOs.Responses.Movie;
using MediatrPractice.Domain.Entities.Movies;

namespace MediatrPractice.Application.Movies.Queries.GetMovies
{
    public static class GetMoviesQueryExtension
    {
        public static GetMovieDto MapTo(this Movie movie)
        {
            return new GetMovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Genre = movie.Genre,
                Rating = movie.Rating
            };
        }
    }
}
