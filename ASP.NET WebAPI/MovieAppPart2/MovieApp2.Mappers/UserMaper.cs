using MovieApp2.Domain.Models;
using MovieApp2.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.Mappers
{
    public static class UserMaper
    {
        public static UserDto ToUserDto(this User user)
        {
            return new UserDto
            {
                UserName = user.UserName,
                FullName = user.FirstName + " " + user.LastName,    
                FavouriteGenre = user.FavouriteGenre,
                Role = user.Role,
                MovieList = user.MovieList.Select(m => new MovieDto
                {
                  
                    Title = m.Title,
                    Description = m.Description,
                    Year = m.Year,
                    Genre = m.Genre
                   
                }).ToList()


            };
        }

        public static User ToUser(this RegisterUserDto registerUserDto , string hash)
        {
            return new User
            {
                UserName= registerUserDto.UserName,
                FirstName = registerUserDto.FirstName,
                LastName = registerUserDto.LastName,
                Role=registerUserDto.Role,
                Password = hash,
                FavouriteGenre= registerUserDto.FavouriteGenre

            };

        }

        public static User ToUser(this UpdateUserDto registerUserDto, string hash)
        {
            return new User
            {
                FirstName = registerUserDto.FirstName,
                LastName = registerUserDto.LastName,
                Role = registerUserDto.Role,
                Password = hash,
                FavouriteGenre = registerUserDto.FavouriteGenre

            };

        }


    }
}
