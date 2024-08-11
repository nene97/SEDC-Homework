using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HomeworkClass02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //Add GET method that returns all users


        [HttpGet("GetAllUsers")]
        public ActionResult<string> GetAll()
        {
            return Ok(StaticDb.UserNames);
        }

        //Add GET method that returns one user
        //by id
        //it can be by a set number
        //it can be random

        [HttpGet("GetOneUserById")]
        public ActionResult GetOneUser(int id)
        {
            try
            {
                if (id < 0)
                {
                    
                    return BadRequest("The index has negative value");
                }

                if (id >= StaticDb.UserNames.Count)
                {
                    return StatusCode(StatusCodes.Status404NotFound, $"There is no user  on id  {id}");
                }
               
                return StatusCode(StatusCodes.Status200OK, StaticDb.UserNames[id]);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured. Please contact your administrator");
            }
        }

        [HttpGet("GetOneUserRandom")]
        public ActionResult GetOneUserRandom()
        {
            try
            {
                Random rnd = new Random();

                int random = rnd.Next(0, 5);

               return Ok(StaticDb.UserNames[random]);

             
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured. Please contact your administrator");
            }
        }


    }
}
