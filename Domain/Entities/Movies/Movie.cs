using MediatrPractice.Core.Enums;

namespace MediatrPractice.Domain.Entities.Movies
{
    public class Movie
    {
        public Movie(string? title, string? description, MovieGenre? genre, int? rating)
        {
            Title = title;
            Description = description;
            Genre = (MovieGenre)genre;
            Rating = rating;
        }
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public MovieGenre? Genre { get; set; }
        public int? Rating { get; set; }
    }
}
