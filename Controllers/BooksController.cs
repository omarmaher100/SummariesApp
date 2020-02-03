using Microsoft.AspNetCore.Mvc;
using Summaries.Data;

namespace Summaries.Controllers
{
    [Route("Api/[controller]")]
    public class BooksController :Controller
    {
        private IBookService  _service;
        public BooksController(IBookService service)
        {
            _service = service;
        }

        //Create Add New Book
        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody]Book book)
        {
            _service.AddBook(book);
            return Ok("Added");
        }

        //Read All Books
        [HttpGet("[action]")]
        public IActionResult GetAllBooks()
        {
            return Ok ( _service.GetAllBooks());
        }

        //UpdateBook
        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id , [FromBody]Book newBook)
        {
            _service.UpdateBook(id,newBook);
            return Ok(newBook);
        }

        //Delete Book
        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _service.DeleteBook(id);
            return Ok("Deleted");
        }

        //Get Single Book
        [HttpGet("SingleBook/{id}")]
        public IActionResult GetSingleBook(int id)
        {
            return Ok (_service.GetBookById(id));
        }
        
    }
}