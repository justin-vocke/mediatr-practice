﻿using MediatrPractice.Core.Enums;

namespace MediatrPractice.Domain.DTOs.Responses.Movie
{
    public class GetMovieDto
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public MovieGenre? Genre { get; set; }
        public int? Rating { get; set; }
    }
}
