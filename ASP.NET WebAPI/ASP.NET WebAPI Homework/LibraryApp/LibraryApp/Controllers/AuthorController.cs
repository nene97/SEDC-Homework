using LibraryApp.DTOs;
using LibraryApp.Services.Implementations;
using LibraryApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LibraryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController (IAuthorService authorService)
        {
            _authorService = authorService;
        }


        [HttpPost]
        public IActionResult AddAuthor([FromBody] AddAuthorDto addAuthorDto)
        {
            try           {
                _authorService.AddAuthor(addAuthorDto);
                return Ok("Author Added");

            }
            
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteAuthor(int id)
        {
            try
            {
                _authorService.DeleteAuthor(id);
                return Ok("Author deleted");

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("getall")]
      

        public ActionResult <List<AuthorDto>> GetAuthors()
        {
            try
            {

                return Ok(_authorService.GetAllAuthors());

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpGet("{id}")]
        public ActionResult<BookDto> GetBook(int id)
        {
            try
            {

                return Ok(_authorService.GetAuthorById(id));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut]
        public IActionResult UpdateAuthor([FromBody] UpdateAuthorDto updateAuthorDto)
        {
            try
            {
                _authorService.UpdateAuthor(updateAuthorDto);
                return StatusCode(StatusCodes.Status201Created, "ok");



            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
