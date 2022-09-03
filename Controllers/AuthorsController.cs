using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy.Services;
using Udemy.ViewModels;

namespace Udemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private AuthorsService _authorsService;

        public AuthorsController(AuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorsService.AddAuthor(author);
            return Ok();
        }

        //[HttpPut("update-author-by-id/{id}")]
        //public IActionResult UpdateAuthorById(int id, [FromBody] AuthorVM author)
        //{
        //    var updatedAuthor = _authorsService.UpdateAuthorById(id, author);
        //    return Ok(updatedAuthor);
        //}

        //[HttpDelete("delete-Author-by-id/{id}")]
        //public IActionResult DeleteAuthorById(int id)
        //{
        //    _authorsService.DeleteAuthorById(id);
        //    return Ok();
        //}

        [HttpGet("get-all-authors")]
        public IActionResult GetAllAuthors()
        {
            return Ok(_authorsService.GetAllAuthors());
        }

        //[HttpGet("get-author-by-id/{id}")]
        //public IActionResult GetAuthorById(int id)
        //{
        //    return Ok(_authorsService.GetAuthorById(id));
        //}

        [HttpGet("get-author-with-books-by-id/{id}")]
        public IActionResult GetAuthorWithBooks(int id)
        {
            return Ok(_authorsService.GetAuthorWithBooks(id));
        }
    }
}
