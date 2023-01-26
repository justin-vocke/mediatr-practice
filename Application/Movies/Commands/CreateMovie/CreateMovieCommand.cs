using MediatR;
using MediatrPractice.Core.Enums;
using MediatrPractice.Domain.DTOs.Responses.Movie;

namespace MediatrPractice.Application.Movies.Commands.CreateMovie
{
    public class CreateMovieCommand : IRequest<CreateMovieDto>
    {
        public CreateMovieCommand(
            string title,
            string description,
            MovieGenre genre,
            int rating)
        {
            Title = title;
            Description = description;
            Genre = genre;
            Rating = rating;
        }

        public string? Title { get; set; }
        public string Description { get; set; }
        public int? Rating { get; set; }
        public MovieGenre? Genre { get; }
    }
}
