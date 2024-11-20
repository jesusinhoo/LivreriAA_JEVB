using LivreriAA_JEVB.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using LivreriAA_JEVB.Data.Models;
using LivreriAA_JEVB.Data.Services;

namespace LivreriAA_JEVB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks() 
        {
            var allbooks = _bookService.GetAllBks();
            return Ok(allbooks);
        
        }


        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBooksById(int id)
        {
            var book = _bookService.GetBookById(id);
            return Ok(book);

        }


        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            _bookService.AddBook(book);
            return Ok();
        }
    }
}
