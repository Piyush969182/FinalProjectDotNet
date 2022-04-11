using AutoMapper;
using FinalProject.models;
using FinalProject.services;
using FinalProject.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  /*  [Authorize]*/
    public class BooksController : Controller
    {
        /* public IActionResult Index()
         {
             return View();
         }*/
        BooksServices _repo;
        IMapper _mapper;
        public BooksController(BooksServices repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
   /*     [AllowAnonymous]*/
        [HttpGet]
        [Route("GetBooks")]
        public IActionResult GetBooks()
        {
            var books = _repo.GetBooks();
            return Ok(books);
        }
        [HttpGet]
        [Route("GetBooksById")]
        public IActionResult GetBookById(int BookId)
        {
            var book_by_id = _repo.GetBooksById(BookId);
            return Ok(book_by_id);
        }
        [HttpPost]
        [Route("AddBooks")]
        public IActionResult AddBooks(BooksVM BooksVM)
        {
            var Books = _mapper.Map<Books>(BooksVM);
            _repo.AddBook(Books);
            return Ok(new Response { Status = "Success", Message = "Book Added successfully" });
        }
        [HttpPut]
        [Route("UpdateBooks")]
        public IActionResult UpdateBook(BooksVM BooksVM)
        {
            var Books = _mapper.Map<Books>(BooksVM);
            _repo.UpdateBook(Books);
            return Ok(new Response { Status = "Success", Message = "Book Updated successfully" });
        }
        [HttpDelete]
        [Route("DeleteBooks")]
        public IActionResult DeleteSupplier(int BookId)
        {
            _repo.DeleteBook(BookId);
            return Ok(new Response { Status = "Success", Message = "Book Deleted successfully" });
        }
    }
}
