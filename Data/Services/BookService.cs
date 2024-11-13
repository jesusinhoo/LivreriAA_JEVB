using LivreriAA_JEVB.Data.ViewModels;
using LivreriAA_JEVB.Data.Models;

namespace LivreriAA_JEVB.Data.Services
{
    public class BookService
    {
        private AppDbContext _context;
        public BookService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookVM book)
        {
           
        }
    }
}
