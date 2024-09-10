using MovieApp2.Domain.Models;
using MovieApp2.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.DataAccess.Interfaces
{
    public interface IUserRepository :IRepository<User>
    {
        public void AddMovieToList(AddMovieToListDto addMovieToListDto);
        User GetUserByUserName(string userName);
        User GetUserByUserNameAndPassword(string userName, string password);

    }
}
