using MediatR;
using MediatrPractice.Domain.DTOs.Responses.Movie;
using MediatrPractice.Repository.Context;

namespace MediatrPractice.Application.Movies.Queries.GetMovie
{
    public class GetMovieQueryHandler : IRequestHandler<GetMoviesQuery, IList<GetMovieDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetMovieQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    
        public Task<IList<GetMovieDto>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
