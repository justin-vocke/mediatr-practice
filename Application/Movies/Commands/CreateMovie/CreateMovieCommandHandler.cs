using MediatR;
using MediatrPractice.Domain.DTOs.Responses.Movie;
using MediatrPractice.Repository.Context;

namespace MediatrPractice.Application.Movies.Commands.CreateMovie
{
    public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, CreateMovieDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateMovieCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateMovieDto> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = request.CreateMovie();
            await _dbContext.Movies.AddAsync(movie);
            await _dbContext.SaveChangesAsync();

            return new CreateMovieDto(movie.Id);

        }
    }
}
