using FinalProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Infra
{
    public interface IBooks
    {
        public List<Books> GetBooks();
        public Books GetBookById(int BookId);
        public void AddBook(Books Books);
        public void UpdateBook(Books Books);
        public void DeleteBook(int BookId);
    }
}
