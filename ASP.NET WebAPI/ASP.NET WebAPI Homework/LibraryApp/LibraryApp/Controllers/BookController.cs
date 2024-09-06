using LibraryApp.Domain.Models;
using LibraryApp.Domain.Models.Enums;
using LibraryApp.DTOs;
using LibraryApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


        [HttpPost]
        public IActionResult AddBook([FromBody] AddBookDto addBookDto)
        {
            try
            {
                _bookService.AddBook(addBookDto);
                return StatusCode(StatusCodes.Status201Created, "Book created");



            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }


        }

        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                _bookService.DeleteBook(id);
                return Ok("Book deleted");

            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        [HttpGet("{id}")]

        public ActionResult<BookDto> GetBook(int id)
        {
            try
            {
              var bookDto =   _bookService.GetBookById(id);
                return Ok(bookDto);
              

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpGet]
        public ActionResult<List<BookDto>> GetBooks()
        {
            try
            {
                return Ok(_bookService.GetAllBooks());


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }



        [HttpGet("Filter")]
        public ActionResult <List<BookDto>> Filter(GenreEnum? genre , int? author)
        {
            try
            {
                return Ok(_bookService.Filter(genre, author));  


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPut]
        public IActionResult UpdateBook([FromBody]UpdateBookDto updateBookDto)
        {
            try
            {
                _bookService.UpdateBook(updateBookDto);
                return StatusCode(StatusCodes.Status201Created, "ok");



            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }





    }
}
