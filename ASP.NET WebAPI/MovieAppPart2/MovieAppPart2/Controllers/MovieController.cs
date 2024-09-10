using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp2.DTOs;
using MovieApp2.Services.Interface;

namespace MovieAppPart2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServices _movieServices;

        public MovieController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }

        [HttpGet]
        public ActionResult<List<MovieDto>> GetAll()
        {
            try
            {

                return Ok(_movieServices.GetMovies());



            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        public IActionResult AddMovie([FromBody] AddMovieDto addMovieDto)
        {


            try
            {

                _movieServices.AddMovie(addMovieDto);
                return StatusCode(StatusCodes.Status201Created, "Movie added");



            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<MovieDto>GetById(int id)
        {
            try
            {

                var movieDto = _movieServices.GetMovieById(id);
                return Ok(movieDto);



            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("Filter")]
        public IActionResult Filter(int? year, int? genre)
        {
            try
            {

                var movies = _movieServices.Filter(year, genre);
                return Ok(movies);


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPut]
        public IActionResult UpdateMovie([FromBody] UpdateMovieDto updateMovieDto)
        {
            try
            {
                _movieServices.UpdateMovie(updateMovieDto);
                return StatusCode(StatusCodes.Status201Created, "ok");


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteMovie(int id)
        {
            try
            {
                _movieServices.DeleteMovie(id);
                return Ok("Movie deleted");
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }
    }
}
