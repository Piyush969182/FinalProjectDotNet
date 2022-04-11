using FinalProject.models;
using FinalProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Utility
{
    public class ApplicationProfile :AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Category, CategoryVM>().ReverseMap();
            CreateMap<Books, BooksVM>().ReverseMap();
        }
    }
}
