using FinalProject.Infra;
using FinalProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.services
{
    
    public class BooksServices
    {
        IBooks _service;
        public BooksServices(IBooks service)
        {
            _service = service;
        }
        public List<Books> GetBooks()
        {
            return _service.GetBooks().ToList();
            //List<Supplier> supplier = _sservice.GetSupplier();
            // return supplier.ToList();
        }
        public Books GetBooksById(int BookId)
        {
            return _service.GetBookById(BookId);
        }
        public void AddBook(Books Books)
        {
            _service.AddBook(Books);
        }
        public void UpdateBook(Books Books)
        {
            _service.UpdateBook(Books);
        }
        public void DeleteBook(int Bookid)
        {
            _service.DeleteBook(Bookid);
        }
    }
}
