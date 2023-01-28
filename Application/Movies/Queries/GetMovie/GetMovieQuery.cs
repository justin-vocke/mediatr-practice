using MediatR;
using MediatrPractice.Domain.DTOs.Responses.Movie;

namespace MediatrPractice.Application.Movies.Querie.GetMovie
{
    public class GetMovieQuery : IRequest<GetMovieDto>
    {
        public GetMovieQuery(long? id)
        {
            Id = id;
        }

        public long? Id { get; set; }
    }
}
