using MediatR;
using MediatrPractice.Domain.DTOs.Responses.Movie;

namespace MediatrPractice.Application.Movies.Queries.GetMovies
{
    public class GetMoviesQuery : IRequest<IList<GetMovieDto>>
    {
    }
}
