using MovieApp2.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.Services.Interface
{
    public interface IUserService
    {
        List<UserDto> GetUsers();
        UserDto GetUserById(int id);

        void RegisterUser(RegisterUserDto registerUserDto);
        string Login(LoginUserDto loginUserDto);

        void UpdateUser(UpdateUserDto updateUserDto);
        void DeleteUsert(int id);
        void AddMovieToList(AddMovieToListDto addMovieToListDto);
        
    }
}
