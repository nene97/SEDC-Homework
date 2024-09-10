using MovieApp2.DataAccess.Interfaces;
using MovieApp2.Domain.Models;
using MovieApp2.DTOs;
using MovieApp2.Mappers;
using MovieApp2.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.Services.Implementation
{
    public class MovieServices : IMovieServices
    {
        private readonly IRepository<Movie> _movieRepository;

        public MovieServices(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void AddMovie(AddMovieDto addMovieDto)
        {
            if(addMovieDto == null)
            {
                throw new Exception("Cant be null");
            }
            if(string.IsNullOrEmpty(addMovieDto.Title) && addMovieDto.Title.Length > 50 || string.IsNullOrEmpty(addMovieDto.Description) && addMovieDto.Description.Length > 250)
            {
                throw new Exception("Please fill the title and description accordingly");

            }
            Movie newMovie  = addMovieDto.ToMovie();
            _movieRepository.Add(newMovie);
        }

        public void DeleteMovie(int id)
        {
            Movie movieDb = _movieRepository.GetById(id);
            if(movieDb ==  null)
            {
                throw new Exception("Mobie not found");
            }
            _movieRepository.Delete(movieDb);   
        }

        public List<MovieDto> Filter(int? year, int? genre)
        {
          List<Movie> movies = _movieRepository.Filter(year, genre);
            
            List<MovieDto> movieDtos = movies.Select(x => x.ToMovieDto()).ToList();
            return movieDtos;
        }

        public MovieDto GetMovieById(int id)
        {
            Movie movieDb = _movieRepository.GetById(id);
            if (movieDb == null)
            {
                throw new Exception($"Movie {id} not found");
            }
            MovieDto movieDto = movieDb.ToMovieDto();
            return movieDto;
        }

        public List<MovieDto> GetMovies()
        {
           var moviesDb = _movieRepository.GetAll();
            return moviesDb.Select(x => x.ToMovieDto()).ToList();

        }

        public void UpdateMovie(UpdateMovieDto updateMovieDto)
        {
            Movie movieDb = _movieRepository.GetById(updateMovieDto.Id);
            if (movieDb == null)
            {
                throw new Exception("Movie not found");
            }
            if (string.IsNullOrEmpty(updateMovieDto.Title))
            {
                throw new Exception("Movie must have title");

            }
            if (updateMovieDto.Description.Length > 250)
            {
                throw new Exception("Decription is more than 250 charactrs");
            }
            movieDb.Title = updateMovieDto.Title;
            movieDb.Description = updateMovieDto.Description;
            movieDb.Year = updateMovieDto.Year;
            movieDb.Genre = updateMovieDto.Genre;

            _movieRepository.Update(movieDb);
        }
    }
    }

