using BooksApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        [HttpGet]
        ////http://localhost:[port]/api/Books
        public ActionResult<List<Book>> GetAllBooks()
        {
            try
            {
                return Ok(StaticDb.Books);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpGet("GetBookQueryString")]
        // //http://localhost:[port]/api/Books/GetBookQueryString?index=1
        public ActionResult<Book> GetBook(int? index)
        {

            try
            {
                if (index == null)
                {
                    return BadRequest("The index is required");
                }

                if (index < 0)
                {
                    return BadRequest("The index cannot be negative");
                }

                if (index >= StaticDb.Books.Count)
                {
                    return NotFound($"There is no book  on index {index}");
                }

                return Ok(StaticDb.Books[index.Value]);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpGet("GetBookQueryStringFiltered")]
        // //http://localhost:[port]/api/Books/GetBookQueryStringFiltered?author=[author]&title=[title]
        //http://localhost:[5246]/api/Books/GetBookQueryStringFiltered?author=Jane%20Austen
        // http://localhost:[5246]/api/Books/GetBookQueryStringFiltered?title=Pride%20and%20Prejudice
        //http://localhost:[5246]/api/Books/GetBookQueryStringFiltered?author=Jane%20Austen&title=Pride%20and%20Prejudice



        public ActionResult<Book> GetOneBookFiltered(string? author , string? title ) 
        {

            try
            {
                if (string.IsNullOrEmpty(author) && string.IsNullOrEmpty(title)) 
                { 
                    return BadRequest("you need one parametar");
                }
                if (string.IsNullOrEmpty(title)) 
                {
                    Book bookByAuthor = StaticDb.Books.FirstOrDefault(x => x.Author.ToLower() == author.ToLower());

                    return Ok(bookByAuthor);    
                }

                if (string.IsNullOrEmpty(author))
                {
                    Book bookByTitle = StaticDb.Books.FirstOrDefault(x => x.Title.ToLower() == title.ToLower());

                    return Ok(bookByTitle);
                }

                Book book = StaticDb.Books.FirstOrDefault(x => x.Author.ToLower() == author.ToLower() 
                                                        && x.Title.ToLower() == title.ToLower());
                return Ok(book);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody]Book book)
        {
            try
            {
                if (book == null)
                {
                    return BadRequest("Book cannot be null");
                }

                if (string.IsNullOrEmpty(book.Author))
                {
                    return BadRequest("Each book must have  author");
                }

                if (string.IsNullOrEmpty(book.Title))
                {
                    return BadRequest("Each book must have  title");
                }


                StaticDb.Books.Add(book);
                return StatusCode(StatusCodes.Status201Created, "Book addded!");

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


    }
}
