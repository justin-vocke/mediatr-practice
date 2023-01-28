using MediatR;
using MediatrPractice.Application.Movies.Queries.GetMovies;
using MediatrPractice.Domain.DTOs.Responses.Movie;
using MediatrPractice.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace MediatrPractice.Application.Movies.Querie.GetMovie
{
    public class GetMovieQueryHandler : IRequestHandler<GetMovieQuery, GetMovieDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetMovieQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetMovieDto> Handle(GetMovieQuery request, CancellationToken cancellationToken)
        {
            var movie = await _dbContext.Movies.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (movie != null)
            {
                var movieItem = movie.MapTo();
                return movieItem;
            }
            return null;
        }

    }
}
