using Microsoft.EntityFrameworkCore;
using MovieApp2.DataAccess.Interfaces;
using MovieApp2.Domain.Models;
using MovieApp2.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.DataAccess.Implementation
{
    public class UserRepository : IUserRepository
    {

        private readonly MovieAppDbContext _dbContext;

        public UserRepository(MovieAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(User entity)
        {

            _dbContext.Users.Add(entity);
             _dbContext.SaveChanges();
        }

        public void Delete(User entity)
        {
            _dbContext.Users.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<User> Filter(int? year, int? genre)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return _dbContext.Users
               .Include(x => x.MovieList)
               .ToList();
        }

        public User GetById(int id)
        {
            return _dbContext.Users.Include(x => x.MovieList).FirstOrDefault(x => x.Id == id);


        }

        public void Update(User entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }





        public void AddMovieToList(AddMovieToListDto addMovieToListDto)
        {
            User user = _dbContext.Users.FirstOrDefault(x => x.Id == addMovieToListDto.UserId);
            Movie movie = _dbContext.Movies.FirstOrDefault(x => x.Id == addMovieToListDto.Id);
            user.MovieList.Add(movie);
            _dbContext.SaveChanges();
        }





















        public User GetUserByUserName(string userName)
        {
            return _dbContext.Users.FirstOrDefault(x => x.UserName == userName);

        }

        public User GetUserByUserNameAndPassword(string userName, string password)
        {
            return _dbContext.Users.FirstOrDefault(x => x.UserName.ToLower() == userName.ToLower() && x.Password == password);

        }

       
    }
}
