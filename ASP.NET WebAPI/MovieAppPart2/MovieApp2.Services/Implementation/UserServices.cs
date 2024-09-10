using Microsoft.IdentityModel.Tokens;
using MovieApp2.DataAccess.Interfaces;
using MovieApp2.Domain.Models;
using MovieApp2.DTOs;
using MovieApp2.Mappers;
using MovieApp2.Services.Interface;
using MovieApp2.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace MovieApp2.Services.Implementation
{
    public class UserServices : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRepository<Movie> _movieRepository;

        public UserServices(IUserRepository userRepository, IRepository<Movie> movieRepository)
        {
            _userRepository = userRepository;
            _movieRepository = movieRepository;
        }


        public void DeleteUsert(int id)
        {
            User userDb = _userRepository.GetById(id);
            if (userDb == null)
            {
                throw new Exception("User not found");

            }
            _userRepository.Delete(userDb);
        }

        public UserDto GetUserById(int id)
        {
            User userDb = _userRepository.GetById(id);
            if (userDb == null)
            {
                throw new Exception("User not found");

            }

            UserDto userDto = userDb.ToUserDto();
            return userDto;
        }

        public List<UserDto> GetUsers()
        {
            var usersDb = _userRepository.GetAll();
            return usersDb.Select(x => x.ToUserDto()).ToList();
        }

        public string Login(LoginUserDto loginUserDto)
        {
            if (loginUserDto == null)
            {
                throw new DataException("User cannt be null");

            }
            if (string.IsNullOrEmpty(loginUserDto.UserName) || string.IsNullOrEmpty(loginUserDto.Password))
            {
                throw new DataException("Username and password are reqired");

            }

            string hash = GennerateHash(loginUserDto.Password);
           

            User userDb = _userRepository.GetUserByUserNameAndPassword(loginUserDto.UserName, hash);

            if (userDb == null)
            {
                throw new Exception("Not found");

            }


            

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

            byte[] secretKeyBytes = Encoding.ASCII.GetBytes("Our secret secretttt secret  key");

            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.Now.AddHours(2),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes)
                                                                , SecurityAlgorithms.HmacSha256Signature),
                
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new[]
                   
                    {
                        new Claim("userFullName" , userDb.FirstName + ' ' + userDb.LastName),
                        new Claim(ClaimTypes.NameIdentifier, userDb.UserName),
                        new Claim(ClaimTypes.Role , userDb.Role.ToString())
                    }
                    )


            };

           
            SecurityToken token = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);


            

            string resultToken = jwtSecurityTokenHandler.WriteToken(token);
            return resultToken;
        }

        public void RegisterUser(RegisterUserDto registerUserDto)
        {
            if (registerUserDto == null)
            {
                throw new Exception("User cant be null");
            }

            ValidationHelper.ValidateReqiredStrings(registerUserDto.FirstName, "FirstName", 50);
            ValidationHelper.ValidateReqiredStrings(registerUserDto.LastName, "LastName", 70);
            ValidationHelper.ValidateReqiredStrings(registerUserDto.UserName, "UserName", 50);

            if (string.IsNullOrEmpty(registerUserDto.Password) || string.IsNullOrEmpty(registerUserDto.ConfirmPassword))
            {
                throw new DataException("Password is reqired");
            }

            if (registerUserDto.Password != registerUserDto.ConfirmPassword)
            {
                throw new DataException("Password must match");

            }


            User userDb = _userRepository.GetUserByUserName(registerUserDto.UserName);
            if (userDb != null)
            {
                throw new DataException($"Username {registerUserDto.UserName} is already in use");
            }



            string hash = GennerateHash(registerUserDto.Password);
            User newUser = registerUserDto.ToUser(hash);
             _userRepository.Add(newUser);

            
        }

        public void UpdateUser(UpdateUserDto updateUserDto)
        {
            User userdb = _userRepository.GetById(updateUserDto.Id);
            if(userdb == null)
            {
                throw new Exception("No user found");

            }



            ValidationHelper.ValidateReqiredStrings(updateUserDto.FirstName, "FirstName", 50);
            ValidationHelper.ValidateReqiredStrings(updateUserDto.LastName, "LastName", 70);

            if (string.IsNullOrEmpty(updateUserDto.Password) || string.IsNullOrEmpty(updateUserDto.ConfirmPassword))
            {
                throw new DataException("Password is reqired");
            }

            if (updateUserDto.Password != updateUserDto.ConfirmPassword)
            {
                throw new DataException("Password must match");

            }


            string hash = GennerateHash(updateUserDto.Password);

            userdb.FirstName = updateUserDto.FirstName;
            userdb.LastName = updateUserDto.LastName;
            userdb.Password = hash;
            userdb.Role = updateUserDto.Role;
            userdb.FavouriteGenre = updateUserDto.FavouriteGenre;

            _userRepository.Update(userdb);

        }



        public void AddMovieToList(AddMovieToListDto addMovieToListDto)

        {
            User user = _userRepository.GetById(addMovieToListDto.UserId);
            if (user == null)
            {
                throw new Exception("No user found");
            }

            Movie movie = _movieRepository.GetById(addMovieToListDto.Id);
                if (movie == null)
            {
                throw new Exception("No movie found");

            }
            _userRepository.AddMovieToList(addMovieToListDto);
           
            
        }






















        private static string GennerateHash(string password)
        {
            MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();


            
            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);


            
            byte[] hashedBytes = mD5CryptoServiceProvider.ComputeHash(passwordBytes);


            
            string hash = Encoding.ASCII.GetString(hashedBytes);
            return hash;

        }

        
    }
}
