using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp2.Domain.Models.Enums;
using MovieApp2.DTOs;
using MovieApp2.Services.Interface;
using System.Data;
using System.Security.Claims;

namespace MovieAppPart2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [AllowAnonymous]
        [HttpPost("register")]

        public   IActionResult RegisterUser([FromBody] RegisterUserDto registerUserDto)
        {
            try
            {

                 _userService.RegisterUser(registerUserDto);
                return StatusCode(StatusCodes.Status201Created, "User rgisterd");



            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        [AllowAnonymous] //client doesnt need to provide a  token
        [HttpPost("login")]

        public ActionResult<string> Login([FromBody] LoginUserDto loginUserDto)
        {

            try
            {
                string token = _userService.Login(loginUserDto);
                return Ok(token);



            }
            catch (DataException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet("{id}")]

        public ActionResult<UserDto> GetById(int id)
        {
            try
            {

                var userDto = _userService.GetUserById(id);
                return Ok(userDto);



            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }



        }


        [Authorize]//user must be logged in to accses method
        [HttpGet("getall")]
        public ActionResult<List<UserDto>> GetAll()
        {
            try
            {
                // Get the ClaimsIdentity from HttpContext
                var identity = HttpContext.User.Identity as ClaimsIdentity;

                // Retrieve the role claim from the identity
                var roleClaim = identity?.FindFirst(ClaimTypes.Role)?.Value;

                // Ensure the role claim exists and parse it as an enum
                if (roleClaim == null || !Enum.TryParse(roleClaim, out RoleEnum userRole))
                {
                    return StatusCode(StatusCodes.Status403Forbidden, "Role is not present in the token.");
                }

                // Check if the user role is not 'Admin'
                if (userRole != RoleEnum.Admin)
                {
                    return StatusCode(StatusCodes.Status403Forbidden, "You do not have permission to access this resource.");
                }

                // If the user is 'Admin', proceed to get the list of users
                return Ok(_userService.GetUsers());



            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        [Authorize]
        [HttpDelete("deleteUser")]
        public IActionResult DeleteUser(int id)
        {
            try
            {

               
                var identity = HttpContext.User.Identity as ClaimsIdentity;

                
                var roleClaim = identity?.FindFirst(ClaimTypes.Role)?.Value;

                
                if (roleClaim == null || !Enum.TryParse(roleClaim, out RoleEnum userRole))
                {
                    return StatusCode(StatusCodes.Status403Forbidden, "Role is not present in the token.");
                }

                
                if (userRole != RoleEnum.Admin)
                {
                    return StatusCode(StatusCodes.Status403Forbidden, "You do not have permission to access this resource.");
                }


                _userService.DeleteUsert(id);
                return Ok("User deleted");


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }




        }


        [AllowAnonymous]
        [HttpPost("addmovietolist")]

        public ActionResult AddMovieToList([FromBody] AddMovieToListDto movieToListDto)
        {

            try
            {

              _userService.AddMovieToList(movieToListDto);
                return Ok("Movie added to list");


            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [Authorize]
        [HttpPut("updateUser")]
        public IActionResult UpdateNote([FromBody] UpdateUserDto updateUserDto)
        {
            try
            {
                _userService.UpdateUser(updateUserDto);
                return StatusCode(StatusCodes.Status201Created, "User updated");


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
