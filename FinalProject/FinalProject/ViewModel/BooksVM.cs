using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModel
{
    public class BooksVM
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Quantity { get; set; }
        public string BookImage { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public int Edition { get; set; }
        public int BookIssued { get; set; }
        public int CategoryId { get; set; }
    }
}
