using LivreriAA_JEVB.Data.Services;
using LivreriAA_JEVB.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            _bookService.AddBook(book);
            return Ok();
        }
    }
}
