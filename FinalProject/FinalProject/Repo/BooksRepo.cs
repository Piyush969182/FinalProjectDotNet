using FinalProject.Data;
using FinalProject.Infra;
using FinalProject.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Repo
{
    public class BooksRepo : IBooks
    {
        DataBaseContext _context;
        public BooksRepo(DataBaseContext context)
        {
            _context = context;
           /* _contextt = contextt;*/
        }
        public List<Books> GetBooks()
        {
            /*           var result = (from e in _context.Books
                                     join b
                               in _context.Category on e.CategoryId equals b.CategoryId
                                     select new
                                     {
                                         CategoryName = b.CategoryName,
                                         BookId = e.BookId,
                                         BookName = e.BookName,
                                         AuthorName = e.AuthorName,
                                         Quantity = e.Quantity,
                                         BookImage = e.BookImage,
                                         Description = e.Description,
                                         PublishDate = e.PublishDate,
                                         Edition = e.Edition,
                                         BookIssued = e.BookIssued,
                                      });
                       return (List<Books>)result;*/
            var books = _context.Books.Include(a => a.Category).ToList();
            return books;
        }
        public Books GetBookById(int BookId)
        {
            return _context.Books.FirstOrDefault(e => e.BookId == BookId);
        }
        public void AddBook(Books Books)
        {
            _context.Add(Books);
            _context.SaveChanges();
        }
        public void UpdateBook(Books Books)
        {
            _context.Update(Books);
            _context.SaveChanges();
        }
        public void DeleteBook(int BookId)
        {
            var User = _context.Books.Where(s => s.BookId == BookId).FirstOrDefault();
            if (User != null)
            {
                _context.Remove(User);
                _context.SaveChanges();
            }
        }
    }
}
