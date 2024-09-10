using MovieApp2.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.Services.Interface
{
    public interface IMovieServices
    {
        List<MovieDto> GetMovies();
        MovieDto GetMovieById(int id);
        void UpdateMovie(UpdateMovieDto updateMovieDto);
        List<MovieDto> Filter(int? year, int? genre);

        void AddMovie(AddMovieDto addMovieDto);

        void DeleteMovie (int id);

    }
}
