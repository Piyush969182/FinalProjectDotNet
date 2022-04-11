﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.models
{
    public class Books
    {
        [Key]
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
        public Category Category { get; set; }
       /* public virtual Users Users { get; set; }*/
    }
}
