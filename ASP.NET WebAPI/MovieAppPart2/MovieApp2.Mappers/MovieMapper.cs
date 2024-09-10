using MovieApp2.Domain.Models;
using MovieApp2.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.Mappers
{
    public static class MovieMapper
    {
        public static MovieDto ToMovieDto(this Movie movie)
        {
            return new MovieDto
            {
                Title = movie.Title,
                Description = movie.Description,
                Year = movie.Year,
                Genre = movie.Genre
               

            };
        }

        public static Movie ToMovie(this AddMovieDto addMovieDto)
        {
            return new Movie
            {
                Title = addMovieDto.Title,
                Description = addMovieDto.Description,
                Year = addMovieDto.Year,
                Genre = addMovieDto.Genre
            };
        }
    }
}
