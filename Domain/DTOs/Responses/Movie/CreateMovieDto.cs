﻿namespace MediatrPractice.Domain.DTOs.Responses.Movie
{
    public class CreateMovieDto
    {
        public CreateMovieDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}
