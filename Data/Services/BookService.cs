using LivreriAA_JEVB.Data.ViewModels;
using LivreriAA_JEVB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var _book = new Book()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBks() => _context.Books.ToList();
        public Book GetBookById(int bookid) => _context.Books.FirstOrDefault(n => n.Id == bookid);
    }
}
