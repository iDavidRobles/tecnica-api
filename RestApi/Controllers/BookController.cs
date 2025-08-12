using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        // GET: api/book
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            // Placeholder for getting all books
            return Ok(new { message = "Get all books" });
        }

        // GET: api/book/{id}
        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            // Placeholder for getting a book by id
            return Ok(new { message = $"Get book with id {id}" });
        }

        // POST: api/book
        [HttpPost]
        public IActionResult CreateBook([FromBody] object book)
        {
            // Placeholder for creating a new book
            return CreatedAtAction(nameof(GetBookById), new { id = 1 }, book);
        }

        // PUT: api/book/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] object book)
        {
            // Placeholder for updating a book
            return Ok(new { message = $"Update book with id {id}" });
        }

        // DELETE: api/book/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            // Placeholder for deleting a book
            return Ok(new { message = $"Delete book with id {id}" });
        }
    }
}